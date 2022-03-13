using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats
{
	public partial class SendMessageEmojiInteractionSeen : CatraProto.Client.TL.Schemas.CloudChats.SendMessageActionBase
	{


        public static int StaticConstructorId { get => -1234857938; }
        [Newtonsoft.Json.JsonIgnore]
        public int ConstructorId { get => StaticConstructorId; }
        
[Newtonsoft.Json.JsonProperty("emoticon")]
		public string Emoticon { get; set; }


        #nullable enable
 public SendMessageEmojiInteractionSeen (string emoticon)
{
 Emoticon = emoticon;
 
}
#nullable disable
        internal SendMessageEmojiInteractionSeen() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override void Serialize(Writer writer)
		{
writer.Write(ConstructorId);
			writer.Write(Emoticon);

		}

		public override void Deserialize(Reader reader)
		{
			Emoticon = reader.Read<string>();

		}
				
		public override string ToString()
		{
		    return "sendMessageEmojiInteractionSeen";
		}
	}
}