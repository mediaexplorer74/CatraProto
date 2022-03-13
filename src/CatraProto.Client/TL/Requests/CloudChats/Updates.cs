using System;
using System.Threading;
using System.Threading.Tasks;
using CatraProto.Client.Connections;
using CatraProto.Client.Connections.MessageScheduling;
using CatraProto.Client.MTProto.Rpc;
using CatraProto.TL.Interfaces;
using CatraProto.Client;
using CatraProto.Client.MTProto.Rpc.RpcErrors.CatraErrors;
using System.Collections.Generic;
using System.Numerics;


namespace CatraProto.Client.TL.Requests.CloudChats
{
	public partial class Updates
	{
		
	    private readonly MessagesQueue _messagesQueue;
        private readonly TelegramClient _client;
	    
	    internal Updates(TelegramClient client, MessagesQueue messagesQueue)
	    {
	        _client = client;
	        _messagesQueue = messagesQueue;
	        
	    }
	    
	    public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Updates.StateBase>> GetStateAsync( CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Updates.StateBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Updates.GetState(){
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Updates.DifferenceBase>> GetDifferenceAsync(int pts, int date, int qts, int? ptsTotalLimit = null, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Updates.DifferenceBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Updates.GetDifference(){
Pts = pts,
Date = date,
Qts = qts,
PtsTotalLimit = ptsTotalLimit,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Updates.ChannelDifferenceBase>> GetChannelDifferenceAsync(CatraProto.Client.TL.Schemas.CloudChats.InputChannelBase channel, CatraProto.Client.TL.Schemas.CloudChats.ChannelMessagesFilterBase filter, int pts, int limit, bool force = true, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Updates.ChannelDifferenceBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Updates.GetChannelDifference(){
Channel = channel,
Filter = filter,
Pts = pts,
Limit = limit,
Force = force,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Updates.ChannelDifferenceBase>> GetChannelDifferenceAsync(long channel, CatraProto.Client.TL.Schemas.CloudChats.ChannelMessagesFilterBase filter, int pts, int limit, bool force = true, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var channelToResolve = _client.DatabaseManager.PeerDatabase.ResolveChannel(channel);
if(channelToResolve is null) {
return RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Updates.ChannelDifferenceBase>.FromError(new CantResolvePeer(channel, CatraProto.Client.MTProto.PeerType.Channel));
}
var channelResolved = channelToResolve;
var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Updates.ChannelDifferenceBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Updates.GetChannelDifference(){
Channel = channelResolved,
Filter = filter,
Pts = pts,
Limit = limit,
Force = force,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}

	}
}