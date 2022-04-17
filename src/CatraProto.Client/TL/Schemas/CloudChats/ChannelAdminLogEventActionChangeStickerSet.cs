using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using CatraProto.TL.Results;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats
{
	public partial class ChannelAdminLogEventActionChangeStickerSet : CatraProto.Client.TL.Schemas.CloudChats.ChannelAdminLogEventActionBase
	{


        [Newtonsoft.Json.JsonIgnore]
        public static int ConstructorId { get => -1312568665; }
        
[Newtonsoft.Json.JsonProperty("prev_stickerset")]
		public CatraProto.Client.TL.Schemas.CloudChats.InputStickerSetBase PrevStickerset { get; set; }

[Newtonsoft.Json.JsonProperty("new_stickerset")]
		public CatraProto.Client.TL.Schemas.CloudChats.InputStickerSetBase NewStickerset { get; set; }


        #nullable enable
 public ChannelAdminLogEventActionChangeStickerSet (CatraProto.Client.TL.Schemas.CloudChats.InputStickerSetBase prevStickerset,CatraProto.Client.TL.Schemas.CloudChats.InputStickerSetBase newStickerset)
{
 PrevStickerset = prevStickerset;
NewStickerset = newStickerset;
 
}
#nullable disable
        internal ChannelAdminLogEventActionChangeStickerSet() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override WriteResult Serialize(Writer writer)
		{
writer.WriteInt32(ConstructorId);
var checkprevStickerset = 			writer.WriteObject(PrevStickerset);
if(checkprevStickerset.IsError){
 return checkprevStickerset; 
}
var checknewStickerset = 			writer.WriteObject(NewStickerset);
if(checknewStickerset.IsError){
 return checknewStickerset; 
}

return new WriteResult();

		}

		public override ReadResult<IObject> Deserialize(Reader reader)
		{
			var tryprevStickerset = reader.ReadObject<CatraProto.Client.TL.Schemas.CloudChats.InputStickerSetBase>();
if(tryprevStickerset.IsError){
return ReadResult<IObject>.Move(tryprevStickerset);
}
PrevStickerset = tryprevStickerset.Value;
			var trynewStickerset = reader.ReadObject<CatraProto.Client.TL.Schemas.CloudChats.InputStickerSetBase>();
if(trynewStickerset.IsError){
return ReadResult<IObject>.Move(trynewStickerset);
}
NewStickerset = trynewStickerset.Value;
return new ReadResult<IObject>(this);

		}
		
		public override string ToString()
		{
		    return "channelAdminLogEventActionChangeStickerSet";
		}

		public override int GetConstructorId()
		{
			return ConstructorId;
		}
	}
}