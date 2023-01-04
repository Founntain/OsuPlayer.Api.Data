namespace OsuPlayer.Api.Data.API.Models;

public class ApiStatisticsModel
{
    public ulong TotalUsers { get; set; }
    public ulong TotalTranslators { get; set; }
    public ulong TotalSongsPlayed { get; set; }
    public ulong TotalCommunityXp { get; set; }
    public ulong CommunityLevel { get; set; }
    public ulong CommunityXpLeft { get; set; }
    public ulong TotalBeatmaps { get; set; }
}