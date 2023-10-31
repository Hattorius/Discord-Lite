namespace Discord_Lite.DTOs;

public class DiscordUsersMeDTO
{
    public string Id { get; set; }
    public string Username { get; set; }
    public string Avatar { get; set; }
    public string Discriminator { get; set; }
    public int Public_flags { get; set; }
    public int Premium_Type { get; set; }
    public int Flags { get; set; }
    public string Banner { get; set; }
    public int Accent_color { get; set; }
    public string Global_name { get; set; }
    public string Banner_color { get; set; }
    public bool Mfa_enabled { get; set; }
    public string Locale { get; set; }
    public string Email { get; set; }
    public bool Verified { get; set; }
    public string Phone { get; set; }
    public bool Nsfw_allowed { get; set; }
    public int Premium_usage_flags { get; set; }
    public int Purchased_flags { get; set; }
    public string Bio { get; set; }
}