using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats
{
	public partial class MessageEntityStrike : CatraProto.Client.TL.Schemas.CloudChats.MessageEntityBase
	{


        public static int StaticConstructorId { get => -1090087980; }
        [Newtonsoft.Json.JsonIgnore]
        public int ConstructorId { get => StaticConstructorId; }
        
[Newtonsoft.Json.JsonProperty("offset")]
		public sealed override int Offset { get; set; }

[Newtonsoft.Json.JsonProperty("length")]
		public sealed override int Length { get; set; }


        #nullable enable
 public MessageEntityStrike (int offset,int length)
{
 Offset = offset;
Length = length;
 
}
#nullable disable
        internal MessageEntityStrike() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override void Serialize(Writer writer)
		{
writer.Write(ConstructorId);
			writer.Write(Offset);
			writer.Write(Length);

		}

		public override void Deserialize(Reader reader)
		{
			Offset = reader.Read<int>();
			Length = reader.Read<int>();

		}
				
		public override string ToString()
		{
		    return "messageEntityStrike";
		}
	}
}