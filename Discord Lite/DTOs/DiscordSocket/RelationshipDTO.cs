using System;
using System.Collections.Generic;

namespace Discord_Lite.DTOs.DiscordSocket;

public class RelationshipDTO
{
    public string User_Id { get; set; }
    public int Type { get; set; }
    public DateTime Since { get; set; }
    public string? Nickname { get; set; }
    public string Id { get; set; }
}