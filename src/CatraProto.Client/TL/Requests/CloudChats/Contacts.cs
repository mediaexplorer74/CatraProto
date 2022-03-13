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
	public partial class Contacts
	{
		
	    private readonly MessagesQueue _messagesQueue;
        private readonly TelegramClient _client;
	    
	    internal Contacts(TelegramClient client, MessagesQueue messagesQueue)
	    {
	        _client = client;
	        _messagesQueue = messagesQueue;
	        
	    }
	    
	    public async Task<RpcMessage<CatraProto.Client.MTProto.Rpc.Vectors.RpcVector<int>>> GetContactIDsAsync(long hash, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.MTProto.Rpc.Vectors.RpcVector<int>>(
new CatraProto.Client.MTProto.Rpc.Vectors.RpcVector<int>()
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.GetContactIDs(){
Hash = hash,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.MTProto.Rpc.Vectors.RpcVector<CatraProto.Client.TL.Schemas.CloudChats.ContactStatusBase>>> GetStatusesAsync( CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.MTProto.Rpc.Vectors.RpcVector<CatraProto.Client.TL.Schemas.CloudChats.ContactStatusBase>>(
new CatraProto.Client.MTProto.Rpc.Vectors.RpcVector<CatraProto.Client.TL.Schemas.CloudChats.ContactStatusBase>()
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.GetStatuses(){
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.ContactsBase>> GetContactsAsync(long hash, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.ContactsBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.GetContacts(){
Hash = hash,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.ImportedContactsBase>> ImportContactsAsync(IList<CatraProto.Client.TL.Schemas.CloudChats.InputContactBase> contacts, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.ImportedContactsBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.ImportContacts(){
Contacts = contacts,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>> DeleteContactsAsync(IList<CatraProto.Client.TL.Schemas.CloudChats.InputUserBase> id, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.DeleteContacts(){
Id = id,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<bool>> DeleteByPhonesAsync(IList<string> phones, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<bool>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.DeleteByPhones(){
Phones = phones,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<bool>> BlockAsync(CatraProto.Client.TL.Schemas.CloudChats.InputPeerBase id, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<bool>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.Block(){
Id = id,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<bool>> UnblockAsync(CatraProto.Client.TL.Schemas.CloudChats.InputPeerBase id, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<bool>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.Unblock(){
Id = id,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.BlockedBase>> GetBlockedAsync(int offset, int limit, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.BlockedBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.GetBlocked(){
Offset = offset,
Limit = limit,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.FoundBase>> SearchAsync(string q, int limit, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.FoundBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.Search(){
Q = q,
Limit = limit,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.ResolvedPeerBase>> ResolveUsernameAsync(string username, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.ResolvedPeerBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.ResolveUsername(){
Username = username,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.TopPeersBase>> GetTopPeersAsync(int offset, int limit, long hash, bool correspondents = true, bool botsPm = true, bool botsInline = true, bool phoneCalls = true, bool forwardUsers = true, bool forwardChats = true, bool groups = true, bool channels = true, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.Contacts.TopPeersBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.GetTopPeers(){
Offset = offset,
Limit = limit,
Hash = hash,
Correspondents = correspondents,
BotsPm = botsPm,
BotsInline = botsInline,
PhoneCalls = phoneCalls,
ForwardUsers = forwardUsers,
ForwardChats = forwardChats,
Groups = groups,
Channels = channels,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<bool>> ResetTopPeerRatingAsync(CatraProto.Client.TL.Schemas.CloudChats.TopPeerCategoryBase category, CatraProto.Client.TL.Schemas.CloudChats.InputPeerBase peer, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<bool>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.ResetTopPeerRating(){
Category = category,
Peer = peer,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<bool>> ResetSavedAsync( CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<bool>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.ResetSaved(){
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.MTProto.Rpc.Vectors.RpcVector<CatraProto.Client.TL.Schemas.CloudChats.SavedContactBase>>> GetSavedAsync( CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.MTProto.Rpc.Vectors.RpcVector<CatraProto.Client.TL.Schemas.CloudChats.SavedContactBase>>(
new CatraProto.Client.MTProto.Rpc.Vectors.RpcVector<CatraProto.Client.TL.Schemas.CloudChats.SavedContactBase>()
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.GetSaved(){
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<bool>> ToggleTopPeersAsync(bool enabled, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<bool>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.ToggleTopPeers(){
Enabled = enabled,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>> AddContactAsync(CatraProto.Client.TL.Schemas.CloudChats.InputUserBase id, string firstName, string lastName, string phone, bool addPhonePrivacyException = true, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.AddContact(){
Id = id,
FirstName = firstName,
LastName = lastName,
Phone = phone,
AddPhonePrivacyException = addPhonePrivacyException,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>> AcceptContactAsync(CatraProto.Client.TL.Schemas.CloudChats.InputUserBase id, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.AcceptContact(){
Id = id,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>> GetLocatedAsync(CatraProto.Client.TL.Schemas.CloudChats.InputGeoPointBase geoPoint, bool background = true, int? selfExpires = null, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.GetLocated(){
GeoPoint = geoPoint,
Background = background,
SelfExpires = selfExpires,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>> BlockFromRepliesAsync(int msgId, bool deleteMessage = true, bool deleteHistory = true, bool reportSpam = true, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.BlockFromReplies(){
MsgId = msgId,
DeleteMessage = deleteMessage,
DeleteHistory = deleteHistory,
ReportSpam = reportSpam,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>> DeleteContactsAsync(IList<long> id, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var idResolved = new List<CatraProto.Client.TL.Schemas.CloudChats.InputUserBase>();
for (var i = 0; i < id.Count; i++){
var idToResolveOut = id[i];
var idToResolve = _client.DatabaseManager.PeerDatabase.ResolveUser(idToResolveOut);
if(idToResolve is null) {
return RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>.FromError(new CantResolvePeer(idToResolveOut, CatraProto.Client.MTProto.PeerType.User));
}
idResolved.Add(idToResolve);
}
var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.DeleteContacts(){
Id = idResolved,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<bool>> BlockAsync(CatraProto.Client.MTProto.PeerId id, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var idToResolve = _client.DatabaseManager.PeerDatabase.ResolvePeer(id);
if(idToResolve is null) {
return RpcMessage<bool>.FromError(new CantResolvePeer(id.Id, id.Type));
}
var idResolved = idToResolve;
var rpcResponse = new RpcMessage<bool>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.Block(){
Id = idResolved,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<bool>> UnblockAsync(CatraProto.Client.MTProto.PeerId id, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var idToResolve = _client.DatabaseManager.PeerDatabase.ResolvePeer(id);
if(idToResolve is null) {
return RpcMessage<bool>.FromError(new CantResolvePeer(id.Id, id.Type));
}
var idResolved = idToResolve;
var rpcResponse = new RpcMessage<bool>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.Unblock(){
Id = idResolved,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<bool>> ResetTopPeerRatingAsync(CatraProto.Client.TL.Schemas.CloudChats.TopPeerCategoryBase category, CatraProto.Client.MTProto.PeerId peer, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var peerToResolve = _client.DatabaseManager.PeerDatabase.ResolvePeer(peer);
if(peerToResolve is null) {
return RpcMessage<bool>.FromError(new CantResolvePeer(peer.Id, peer.Type));
}
var peerResolved = peerToResolve;
var rpcResponse = new RpcMessage<bool>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.ResetTopPeerRating(){
Category = category,
Peer = peerResolved,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>> AddContactAsync(long id, string firstName, string lastName, string phone, bool addPhonePrivacyException = true, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var idToResolve = _client.DatabaseManager.PeerDatabase.ResolveUser(id);
if(idToResolve is null) {
return RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>.FromError(new CantResolvePeer(id, CatraProto.Client.MTProto.PeerType.User));
}
var idResolved = idToResolve;
var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.AddContact(){
Id = idResolved,
FirstName = firstName,
LastName = lastName,
Phone = phone,
AddPhonePrivacyException = addPhonePrivacyException,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}
public async Task<RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>> AcceptContactAsync(long id, CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions? messageSendingOptions = null, CancellationToken cancellationToken = default)
		{

var idToResolve = _client.DatabaseManager.PeerDatabase.ResolveUser(id);
if(idToResolve is null) {
return RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>.FromError(new CantResolvePeer(id, CatraProto.Client.MTProto.PeerType.User));
}
var idResolved = idToResolve;
var rpcResponse = new RpcMessage<CatraProto.Client.TL.Schemas.CloudChats.UpdatesBase>(
);
messageSendingOptions ??= new CatraProto.Client.Connections.MessageScheduling.MessageSendingOptions(isEncrypted: true);
var methodBody = new CatraProto.Client.TL.Schemas.CloudChats.Contacts.AcceptContact(){
Id = idResolved,
};

_messagesQueue.EnqueueMessage(methodBody, messageSendingOptions, rpcResponse, out var taskCompletionSource, cancellationToken);
await taskCompletionSource!;
return rpcResponse;
}

	}
}