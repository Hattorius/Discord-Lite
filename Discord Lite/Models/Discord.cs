using System.Threading.Tasks;
using Discord_Lite.DTOs;
using Flurl.Http;

namespace Discord_Lite.Models;

public class Discord
{
    public bool IsLoggedIn;
    public DiscordUsersMeDTO? CurrentUser;
    public DiscordUsersMeGuildsDTO? Guilds;

    private DiscordSocket _socket;
    public string AuthenticationToken;

    public Discord(string authenticationToken)
    {
        AuthenticationToken = authenticationToken;
    }

    public async Task<DiscordUsersMeDTO?> GetMe()
    {
        var response = await "https://discord.com/api/v9/users/@me"
            .WithHeader("Authorization", AuthenticationToken)
            .AllowAnyHttpStatus()
            .GetAsync();

        if (response.StatusCode != 200)
        {
            return null;
        }

        IsLoggedIn = true;
        CurrentUser ??= await response.GetJsonAsync<DiscordUsersMeDTO>();
        return CurrentUser;
    }

    public async Task Start()
    {
        _socket = new(this);
        await _socket.Start();
    }
}