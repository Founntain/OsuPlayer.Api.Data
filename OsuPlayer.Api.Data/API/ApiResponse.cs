namespace OsuPlayer.Api.Data.API;

public class ApiResponse<TReponseType>
{
    public DateTime RequestTime { get; } = DateTime.UtcNow;
    public List<string>? Errors { get; set; } = new ();
    public TReponseType? Value { get; set; }

    public ApiResponse()
    {
        
    }

    public ApiResponse(string errorMessage)
    {
        Errors = new List<string>
        {
            errorMessage
        };
    }

    public ApiResponse(TReponseType? value)
    {
        Value = value;
    }
}