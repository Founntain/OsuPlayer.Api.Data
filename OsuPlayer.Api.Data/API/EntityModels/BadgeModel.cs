namespace OsuPlayer.Api.Data.API.EntityModels;

public class BadgeModel : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ulong Icon { get; set; }
    public string IconName { get; set; }
}