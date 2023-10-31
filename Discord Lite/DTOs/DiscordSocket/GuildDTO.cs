using System;
using System.Collections.Generic;

namespace Discord_Lite.DTOs.DiscordSocket;

public class GuildDTO
{
    public int Version { get; set; }
    public List<GuildDTOSticker> Stickers { get; set; }
    public List<GuildDTORole> Roles { get; set; }
    public GuildDTOProperties Properties { get; set; }
    public int Premium_Subscription_Count { get; set; }
    public int Member_Count { get; set; }
    public bool Lazy { get; set; }
    public bool Large { get; set; }
    public DateTime Joined_At { get; set; }
    public string Id { get; set; }
    public string Data_Mode { get; set; }
    public List<GuildDTOChannel> Channels { get; set; }
    
}

public class GuildDTOSticker
{
    public int Type { get; set; }
    public string Tags { get; set; }
    public string Name { get; set; }
    public string Id { get; set; }
    public string Guild_Id { get; set; }
    public int Format_Type { get; set; }
    public string Description { get; set; }
    public bool Available { get; set; }
    public string Asset { get; set; }
}

public class GuildDTORole
{
    public int Position { get; set; }
    public string Permissions { get; set; }
    public string Name { get; set; }
    public bool Mentionable { get; set; }
    public bool Managed { get; set; }
    public string Id { get; set; }
    public string? Icon { get; set; }
    public bool Hoist { get; set; }
    public int Flags { get; set; }
    public int Color { get; set; }
}

public class GuildDTOChannel
{
    public int? User_Limit { get; set; }
    public int Type { get; set; }
    public string? Rtc_Region { get; set; }
    public int? Rate_Limit_Per_User { get; set; }
    public int Position { get; set; }
    public string? Parent_Id { get; set; }
    public string Name { get; set; }
    public string? Last_Message_Id { get; set; }
    public string Id { get; set; }
    public GuildDTOChannelIcon Icon_Emoji { get; set; }
    public int Flags { get; set; }
    public int Bitrate { get; set; }
}

public class GuildDTOChannelIcon
{
    public string Name { get; set; }
    public string? Id { get; set; }
}

public class GuildDTOProperties
{
    public string? System_Channel_Id { get; set; }
    public string? Afk_Channel_Id { get; set; }
    public string? Descovery_Splash { get; set; }
    public string Id { get; set; }
    public string? Banned { get; set; }
    public int Default_Message_Notifications { get; set; }
    public int System_Channel_Flags { get; set; }
    public string Name { get; set; }
    public bool Premium_Progress_Bar_Enabled { get; set; }
    public string Icon { get; set; }
    public int Max_Members { get; set; }
    public string? Rules_Channel_Id { get; set; }
    public int Mfa_Level { get; set; }
    public string? Splash { get; set; }
    public string? Description { get; set; }
    public string? Vanity_Url_Code { get; set; }
    public int Max_Stage_Video_Channel_Users { get; set; }
    public string? Application_Id { get; set; }
    public int Afk_Timeout { get; set; }
    public bool Nsfw { get; set; }
    public string? Home_Header { get; set; }
    public string? Latest_Onboarding_Question_Id { get; set; }
    public int Premium_Tier { get; set; }
    public List<string> Features { get; set; }
    public int Explicit_Content_Filter { get; set; }
    public string Owner_Id { get; set; }
    public string Preferred_Locale { get; set; }
    public int Max_Video_Channel_Users { get; set; }
    public string? Public_Updates_Channel_Id { get; set; }
    public int Verification_Level { get; set; }
    public int Nsfw_Level { get; set; }
}