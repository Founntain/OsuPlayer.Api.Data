using OsuPlayer.Api.Data.API.EntityModels;

namespace OsuPlayer.Api.Data.API.RequestModels.User;

public class EditUserModel
{
    public UserModel User { get; set; }
    public string? NewUsername { get; set; }
    public string? NewPassword { get; set; }
}