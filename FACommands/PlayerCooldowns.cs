namespace FACommands;

internal sealed class PlayerCooldowns
{
    private readonly TimeProvider _time;
    private readonly Dictionary<string, (long Started, int Duration)> _cooldowns = new();

    public PlayerCooldowns(TimeProvider time = TimeProvider.System) => _time = time;

    // True means the command may run. Use monotonic time so clock changes cannot extend cooldowns.
    public bool CheckCooldown(string command, int cooldown, out int left)
    {
        left = 0;
        // Ignore the check if the cooldown is currently zero or less, or the cooldown has changed since
        if (cooldown <= 0 || !_cooldowns.TryGetValue(command, out var previous) || previous.Duration != cooldown)
            return true;

        var remaining = cooldown - _time.GetElapsedTime(previous.Started).TotalSeconds;
        if (remaining <= 0) return true;
        left = (int)Math.Ceiling(remaining);
        return false;
    }

    public void SetCooldown(string command, int cooldown) =>
        _cooldowns[command] = (_time.GetTimestamp(), cooldown);
}
