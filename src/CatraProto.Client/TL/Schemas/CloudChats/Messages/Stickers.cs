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
	public partial class Stickers : CatraProto.Client.TL.Schemas.CloudChats.Messages.StickersBase
	{


        [Newtonsoft.Json.JsonIgnore]
        public static int ConstructorId { get => 816245886; }
        
[Newtonsoft.Json.JsonProperty("hash")]
		public long Hash { get; set; }

[Newtonsoft.Json.JsonProperty("stickers")]
		public List<CatraProto.Client.TL.Schemas.CloudChats.DocumentBase> StickersField { get; set; }


        #nullable enable
 public Stickers (long hash,List<CatraProto.Client.TL.Schemas.CloudChats.DocumentBase> stickersField)
{
 Hash = hash;
StickersField = stickersField;
 
}
#nullable disable
        internal Stickers() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override WriteResult Serialize(Writer writer)
		{
writer.WriteInt32(ConstructorId);
writer.WriteInt64(Hash);
var checkstickersField = 			writer.WriteVector(StickersField, false);
if(checkstickersField.IsError){
 return checkstickersField; 
}

return new WriteResult();

		}

		public override ReadResult<IObject> Deserialize(Reader reader)
		{
			var tryhash = reader.ReadInt64();
if(tryhash.IsError){
return ReadResult<IObject>.Move(tryhash);
}
Hash = tryhash.Value;
			var trystickersField = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.DocumentBase>(ParserTypes.Object, nakedVector: false, nakedObjects: false);
if(trystickersField.IsError){
return ReadResult<IObject>.Move(trystickersField);
}
StickersField = trystickersField.Value;
return new ReadResult<IObject>(this);

		}
		
		public override string ToString()
		{
		    return "messages.stickers";
		}

		public override int GetConstructorId()
		{
			return ConstructorId;
		}
	}
}