using System;
using System.Collections.Generic;

namespace Discord_Lite.DTOs.DiscordSocket;

public class PrivateChannelDTO
{
    public int Type { get; set; }
    public List<string> Recipient_Ids { get; set; }
    public string? Owner_Id { get; set; }
    public string? Name { get; set; }
    public DateTime? Last_Pin_Timestamp { get; set; }
    public bool? Is_Spam { get; set; }
    public string Last_Message_Id { get; set; }
    public string Id { get; set; }
    public string? Icon { get; set; }
    public int Flags { get; set; }
}