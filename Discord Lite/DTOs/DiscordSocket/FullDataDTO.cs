using System.Collections.Generic;

namespace Discord_Lite.DTOs.DiscordSocket;

public class FullDataDTO
{
    public string T { get; set; }
    public int S { get; set; }
    public int Op { get; set; }
    public FullDataDTOData D { get; set; }
}

public class FullDataDTOData
{
    public int V { get; set; }
    public List<UserDTO> Users { get; set; }
    public GuildSettingsDTO User_Guild_Settings { get; set; }
    public CurrentUserDTO User { get; set; }
    public string Session_Type { get; set; }
    public string Session_Id { get; set; }
    public string Resume_Gateway_Url { get; set; }
    public List<RelationshipDTO> Relationships { get; set; }
    public ReadStateDTO Read_State { get; set; }
    public List<PrivateChannelDTO> Private_Channels { get; set; }
}