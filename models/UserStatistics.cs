namespace TunavBackend.Models;
public class UserStatistics
{
    public int Id { get; set; }

    public int Visitors { get; set; } = 0;

    public int SignUps { get; set; } = 0;

    public int Logins { get; set; } = 0;

    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
}
