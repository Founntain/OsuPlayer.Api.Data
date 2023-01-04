using OsuPlayer.Api.Data.API.Enums;

namespace OsuPlayer.Api.Data.API.EntityModels;

public class UserModel : BaseModel
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public UserRole Role { get; set; }
    public DateTime JoinDate { get; set; }
    public DateTime LastActivity { get; set; }
    public DateTime LastSeen { get; set; }
    public int Level { get; set; }
    public int Xp { get; set; }
    public int TotalXp { get; set; }
    public bool HasXpLock { get; set; }
    public int SongsPlayed { get; set; }
    public string? OsuProfile { get; set; }
    
    public bool IsDonator { get; set; }
    public double AmountDonated { get; set; }
    public string? CustomRolename { get; set; }
    public string? CustomRoleColor { get; set; }
    public string? CustomBannerUrl { get; set; }
    
    public string? Version { get; set; }

    public List<BadgeModel> Badges { get; set; } = new();
}