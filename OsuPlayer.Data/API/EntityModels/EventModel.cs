namespace OsuPlayer.Data.API.EntityModels;

public class EventModel : BaseModel
{
    public DateTime CreationTime { get; set; }
    
    public bool IsTimespan { get; set; }
    public bool IsRepeatingAnnually { get; set; }
    
    public DateTime ValidFrom { get; set; }
    public DateTime? ValidUntil { get; set; }
    
    public int XpModified { get; set; }
    public string Title { get; set; }
    public string? Descrption { get; set; }
}