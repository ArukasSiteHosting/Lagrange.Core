using System.Text.Json;
using System.Text.Json.Nodes;
using Lagrange.Core;
using Lagrange.Core.Common.Interface.Api;
using Lagrange.Core.Internal.Packets.Message;
using Lagrange.OneBot.Core.Entity;
using Lagrange.OneBot.Core.Entity.Action;
using Lagrange.OneBot.Core.Entity.Action.Response;

namespace Lagrange.OneBot.Core.Operation.Generic;

[Operation("get_friend_list")]
public class GetFriendListOperation : IOperation
{
    public async Task<OneBotResult> HandleOperation(BotContext context, JsonObject? payload) {

        var result = await context.FetchFriends();
        return new OneBotResult(result.Select(x => new OneBotGetFriendListResponse(x.Uin, x.Nickname, x.Remarks)), 0, "ok");
    }
}