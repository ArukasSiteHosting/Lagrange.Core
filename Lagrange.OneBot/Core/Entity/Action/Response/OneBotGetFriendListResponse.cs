using Lagrange.Core.Internal.Packets.Message;
using System.Text.Json.Serialization;

namespace Lagrange.OneBot.Core.Entity.Action.Response;

[Serializable]
public class OneBotGetFriendListResponse(long userId, string nickname, string remark) {
    [JsonPropertyName("user_id")] public long userId { get; set; } = userId;
    [JsonPropertyName("nickname")] public string nickname { get; set; } = nickname;
    [JsonPropertyName("remark")] public string remark { get; set; } = remark;
}