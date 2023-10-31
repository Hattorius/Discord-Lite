using System;
using System.Collections.Generic;

namespace Discord_Lite.DTOs.DiscordSocket;

public class ReadStateDTO
{
    public int Version { get; set; }
    public bool Partial { get; set; }
    public List<ReadStateDTOEntry> Entries { get; set; }
}

public class ReadStateDTOEntry
{
    public int Mention_Count { get; set; }
    public DateTime Last_Pin_Timestamp { get; set; }
    public string Last_Message_Id { get; set; }
    public string Id { get; set; }
    public int Flags { get; set; }
}