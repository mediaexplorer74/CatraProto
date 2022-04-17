using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using CatraProto.TL.Results;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats.Messages
{
	public partial class DiscussionMessage : CatraProto.Client.TL.Schemas.CloudChats.Messages.DiscussionMessageBase
	{
		[Flags]
		public enum FlagsEnum 
		{
			MaxId = 1 << 0,
			ReadInboxMaxId = 1 << 1,
			ReadOutboxMaxId = 1 << 2
		}

        [Newtonsoft.Json.JsonIgnore]
        public static int ConstructorId { get => -1506535550; }
        
[Newtonsoft.Json.JsonIgnore]
		public int Flags { get; set; }

[Newtonsoft.Json.JsonProperty("messages")]
		public sealed override List<CatraProto.Client.TL.Schemas.CloudChats.MessageBase> Messages { get; set; }

[Newtonsoft.Json.JsonProperty("max_id")]
		public sealed override int? MaxId { get; set; }

[Newtonsoft.Json.JsonProperty("read_inbox_max_id")]
		public sealed override int? ReadInboxMaxId { get; set; }

[Newtonsoft.Json.JsonProperty("read_outbox_max_id")]
		public sealed override int? ReadOutboxMaxId { get; set; }

[Newtonsoft.Json.JsonProperty("unread_count")]
		public sealed override int UnreadCount { get; set; }

[Newtonsoft.Json.JsonProperty("chats")]
		public sealed override List<CatraProto.Client.TL.Schemas.CloudChats.ChatBase> Chats { get; set; }

[Newtonsoft.Json.JsonProperty("users")]
		public sealed override List<CatraProto.Client.TL.Schemas.CloudChats.UserBase> Users { get; set; }


        #nullable enable
 public DiscussionMessage (List<CatraProto.Client.TL.Schemas.CloudChats.MessageBase> messages,int unreadCount,List<CatraProto.Client.TL.Schemas.CloudChats.ChatBase> chats,List<CatraProto.Client.TL.Schemas.CloudChats.UserBase> users)
{
 Messages = messages;
UnreadCount = unreadCount;
Chats = chats;
Users = users;
 
}
#nullable disable
        internal DiscussionMessage() 
        {
        }
		
		public override void UpdateFlags() 
		{
			Flags = MaxId == null ? FlagsHelper.UnsetFlag(Flags, 0) : FlagsHelper.SetFlag(Flags, 0);
			Flags = ReadInboxMaxId == null ? FlagsHelper.UnsetFlag(Flags, 1) : FlagsHelper.SetFlag(Flags, 1);
			Flags = ReadOutboxMaxId == null ? FlagsHelper.UnsetFlag(Flags, 2) : FlagsHelper.SetFlag(Flags, 2);

		}

		public override WriteResult Serialize(Writer writer)
		{
writer.WriteInt32(ConstructorId);
			UpdateFlags();

			writer.WriteInt32(Flags);
var checkmessages = 			writer.WriteVector(Messages, false);
if(checkmessages.IsError){
 return checkmessages; 
}
			if(FlagsHelper.IsFlagSet(Flags, 0))
			{
writer.WriteInt32(MaxId.Value);
			}

			if(FlagsHelper.IsFlagSet(Flags, 1))
			{
writer.WriteInt32(ReadInboxMaxId.Value);
			}

			if(FlagsHelper.IsFlagSet(Flags, 2))
			{
writer.WriteInt32(ReadOutboxMaxId.Value);
			}

writer.WriteInt32(UnreadCount);
var checkchats = 			writer.WriteVector(Chats, false);
if(checkchats.IsError){
 return checkchats; 
}
var checkusers = 			writer.WriteVector(Users, false);
if(checkusers.IsError){
 return checkusers; 
}

return new WriteResult();

		}

		public override ReadResult<IObject> Deserialize(Reader reader)
		{
			var tryflags = reader.ReadInt32();
if(tryflags.IsError){
return ReadResult<IObject>.Move(tryflags);
}
Flags = tryflags.Value;
			var trymessages = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.MessageBase>(ParserTypes.Object, nakedVector: false, nakedObjects: false);
if(trymessages.IsError){
return ReadResult<IObject>.Move(trymessages);
}
Messages = trymessages.Value;
			if(FlagsHelper.IsFlagSet(Flags, 0))
			{
				var trymaxId = reader.ReadInt32();
if(trymaxId.IsError){
return ReadResult<IObject>.Move(trymaxId);
}
MaxId = trymaxId.Value;
			}

			if(FlagsHelper.IsFlagSet(Flags, 1))
			{
				var tryreadInboxMaxId = reader.ReadInt32();
if(tryreadInboxMaxId.IsError){
return ReadResult<IObject>.Move(tryreadInboxMaxId);
}
ReadInboxMaxId = tryreadInboxMaxId.Value;
			}

			if(FlagsHelper.IsFlagSet(Flags, 2))
			{
				var tryreadOutboxMaxId = reader.ReadInt32();
if(tryreadOutboxMaxId.IsError){
return ReadResult<IObject>.Move(tryreadOutboxMaxId);
}
ReadOutboxMaxId = tryreadOutboxMaxId.Value;
			}

			var tryunreadCount = reader.ReadInt32();
if(tryunreadCount.IsError){
return ReadResult<IObject>.Move(tryunreadCount);
}
UnreadCount = tryunreadCount.Value;
			var trychats = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.ChatBase>(ParserTypes.Object, nakedVector: false, nakedObjects: false);
if(trychats.IsError){
return ReadResult<IObject>.Move(trychats);
}
Chats = trychats.Value;
			var tryusers = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.UserBase>(ParserTypes.Object, nakedVector: false, nakedObjects: false);
if(tryusers.IsError){
return ReadResult<IObject>.Move(tryusers);
}
Users = tryusers.Value;
return new ReadResult<IObject>(this);

		}
		
		public override string ToString()
		{
		    return "messages.discussionMessage";
		}

		public override int GetConstructorId()
		{
			return ConstructorId;
		}
	}
}