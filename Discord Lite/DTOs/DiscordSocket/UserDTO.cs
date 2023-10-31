namespace Discord_Lite.DTOs.DiscordSocket;

public class UserDTO
{
    public string Username { get; set; }
    public int Public_Flags { get; set; }
    public string Id { get; set; }
    public string Global_Name { get; set; }
    public string Display_Name { get; set; }
    public string Discriminator { get; set; }
    public bool Bot { get; set; }
    public string Avatar { get; set; }
}