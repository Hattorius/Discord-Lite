namespace Discord_Lite.DTOs.DiscordSocket;

public class CurrentUserDTO
{
    public bool Verified { get; set; }
    public string Username { get; set; }
    public int Purchased_Flags { get; set; }
    public int Public_Flags { get; set; }
    public string Pronouns { get; set; }
    public int Premium_Usage_Flags { get; set; }
    public int Premium_Type { get; set; }
    public bool Premium { get; set; }
    public string Phone { get; set; }
    public bool Nsfw_Allowed { get; set; }
    public bool Mobile { get; set; }
    public bool Mfa_Enabled { get; set; }
    public string Id { get; set; }
    public string Global_Name { get; set; }
    public int Flags { get; set; }
    public string Email { get; set; }
    public string Discriminator { get; set; }
    public bool Desktop { get; set; }
    public string Bio { get; set; }
    public string Banner_Color { get; set; }
    public string Banner { get; set; }
    public string Avatar { get; set; }
    public int Accent_color { get; set; }
}