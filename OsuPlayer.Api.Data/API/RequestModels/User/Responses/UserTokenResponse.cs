using OsuPlayer.Api.Data.API.EntityModels;

namespace OsuPlayer.Api.Data.API.RequestModels.User.Responses;

public class UserTokenResponse
{
    public string Token { get; set; }
    public UserModel User { get; set; }
}