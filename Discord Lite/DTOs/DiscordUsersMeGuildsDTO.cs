using System.Collections.Generic;

namespace Discord_Lite.DTOs;

public class DiscordUsersMeGuildsDTO
{
    public List<DiscordUserMeGuildsDTOGuild> Guild_affinities;
}

public class DiscordUserMeGuildsDTOGuild
{
    public double Affinity { get; set; }
    public string Guild_id { get; set; }
}