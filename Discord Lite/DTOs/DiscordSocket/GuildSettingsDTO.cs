using System.Collections.Generic;

namespace Discord_Lite.DTOs.DiscordSocket;

public class GuildSettingsDTO
{
    public int Version { get; set; }
    public bool Partial { get; set; }
    public List<GuildSettingsGuild> Entries { get; set; }
}

public class GuildSettingsGuild
{
    public int Version { get; set; }
    public bool Suppress_Roles { get; set; }
    public bool Suppress_Everyone { get; set; }
    public int Notify_Highlights { get; set; }
    public bool Muted { get; set; }
    public bool Mute_Scheduled_Events { get; set; }
    public GuildSettingsMuteConfig? Mute_Config { get; set; }
    public bool Mobile_Push { get; set; }
    public int Message_Notifications { get; set; }
    public bool Hid_Muted_Channels { get; set; }
    public string? Guild_Id { get; set; }
    public int Flags { get; set; }
    public List<GuildSettingsChannelOverride> Channel_Overrides { get; set; }
}

public class GuildSettingsChannelOverride
{
    public bool Muted { get; set; }
    public GuildSettingsMuteConfig? Mute_Config { get; set; }
    public int Message_Notifications { get; set; }
    public bool Collapsed { get; set; }
    public long Channel_Id { get; set; }
}

public class GuildSettingsMuteConfig
{
    public int? Selected_Time_Window { get; set; }
    public int? End_ime { get; set; }
}