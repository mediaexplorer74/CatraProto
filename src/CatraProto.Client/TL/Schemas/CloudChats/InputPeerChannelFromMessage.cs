using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats
{
	public partial class InputPeerChannelFromMessage : CatraProto.Client.TL.Schemas.CloudChats.InputPeerBase
	{


        public static int StaticConstructorId { get => -1121318848; }
        [Newtonsoft.Json.JsonIgnore]
        public int ConstructorId { get => StaticConstructorId; }
        
[Newtonsoft.Json.JsonProperty("peer")]
		public CatraProto.Client.TL.Schemas.CloudChats.InputPeerBase Peer { get; set; }

[Newtonsoft.Json.JsonProperty("msg_id")]
		public int MsgId { get; set; }

[Newtonsoft.Json.JsonProperty("channel_id")]
		public long ChannelId { get; set; }


        #nullable enable
 public InputPeerChannelFromMessage (CatraProto.Client.TL.Schemas.CloudChats.InputPeerBase peer,int msgId,long channelId)
{
 Peer = peer;
MsgId = msgId;
ChannelId = channelId;
 
}
#nullable disable
        internal InputPeerChannelFromMessage() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override void Serialize(Writer writer)
		{
writer.Write(ConstructorId);
			writer.Write(Peer);
			writer.Write(MsgId);
			writer.Write(ChannelId);

		}

		public override void Deserialize(Reader reader)
		{
			Peer = reader.Read<CatraProto.Client.TL.Schemas.CloudChats.InputPeerBase>();
			MsgId = reader.Read<int>();
			ChannelId = reader.Read<long>();

		}
				
		public override string ToString()
		{
		    return "inputPeerChannelFromMessage";
		}
	}
}