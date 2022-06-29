using OsuPlayer.Data.API.EntityModels;

namespace OsuPlayer.Data.API.RequestModels.User;

public class EditUserModel
{
    public UserModel User { get; set; }
    public string Password { get; set; }
    public string? NewPassword { get; set; }
}