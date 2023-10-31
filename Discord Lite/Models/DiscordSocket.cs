using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Discord_Lite.DTOs.DiscordSocket;
using Newtonsoft.Json;

namespace Discord_Lite.Models;

public class DiscordSocket
{
    private Discord _master;
    private ClientWebSocket _webSocket;
    private CancellationTokenSource _cancellationTokenSource;
    private CancellationToken _cancellationToken;

    public DiscordSocket(Discord master)
    {
        _master = master;
        _webSocket = new();
        _cancellationTokenSource = new();
        _cancellationToken = _cancellationTokenSource.Token;
    }

    public void Cancel()
    {
        _cancellationTokenSource.Cancel();
    }

    public async Task Stop()
    {
        await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Connection closed by the client.", _cancellationToken);
    }

    public async Task Start()
    {
        Uri serverUri = new("wss://gateway.discord.gg/?encoding=json&v=9");
        await _webSocket.ConnectAsync(serverUri, _cancellationToken);
        
        await SendData(JsonConvert.SerializeObject(new
        {
            d = new
            {
                capabilities = 16381,
                client_state = new
                {
                    api_code_version = 0,
                    guild_versions = new {},
                    highest_last_message_id = "0",
                    private_channels_version = "0",
                    read_state_version = 0,
                    user_guild_settings_version = -1,
                    user_settings_version = -1
                },
                compress = false,
                presence = new
                {
                    activities = new ArrayList(),
                    afk = false,
                    since = 0,
                    status = "online"
                },
                properties = new
                {
                    browser = "chrome",
                    browser_user_agent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36",
                    browser_version = "118.0.0.0",
                    client_build_number = 241602,
                    device = "",
                    os = "Mac OS X",
                    os_version = "0.15.7",
                    referrer = "",
                    referrer_current = "",
                    referring_domain = "",
                    referring_domain_current = "",
                    release_channel = "stable",
                    system_locale = "en-GB"
                },
                token = _master.AuthenticationToken
            },
            op = 2
        }));

        await SendData(JsonConvert.SerializeObject(new
        {
            op = 4,
            d = new
            {
                channel_id = (string)null,
                flags = 2,
                guild_id = (string)null,
                self_deaf = false,
                self_mute = true,
                self_video = false
            }
        }));
        
        // heartbeat interval: 41250

        await ReceiveData();
    }

    public async Task SendData(string message)
    {
        ArraySegment<byte> messageBuffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(message));
        await _webSocket.SendAsync(messageBuffer, WebSocketMessageType.Text, true, _cancellationToken);
    }
    
    public async Task ReceiveData()
    {
        while (true)
        {
            string receivedMessage = "";

            while (true)
            {
                byte[] receiveBuffer = new byte[1024];
                ArraySegment<byte> buffer = new ArraySegment<byte>(receiveBuffer);
                WebSocketReceiveResult result = await _webSocket.ReceiveAsync(buffer, _cancellationToken);
                receivedMessage += Encoding.UTF8.GetString(receiveBuffer, 0, result.Count);

                if (result.EndOfMessage)
                {
                    break;
                }
            }

            string TCode = JsonConvert.DeserializeObject<DataDTO>(receivedMessage).T;
            
            if (TCode == "READY")
            {
                HandleFullData(JsonConvert.DeserializeObject<FullDataDTO>(receivedMessage));
            } else
            {
                Debug.WriteLine(receivedMessage);
            }
        }
    }

    public void HandleFullData(FullDataDTO data)
    {
        
    }
}