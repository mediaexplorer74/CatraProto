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
	public partial class SendMessageUploadPhotoAction : CatraProto.Client.TL.Schemas.CloudChats.SendMessageActionBase
	{


        [Newtonsoft.Json.JsonIgnore]
        public static int ConstructorId { get => -774682074; }
        
[Newtonsoft.Json.JsonProperty("progress")]
		public int Progress { get; set; }


        #nullable enable
 public SendMessageUploadPhotoAction (int progress)
{
 Progress = progress;
 
}
#nullable disable
        internal SendMessageUploadPhotoAction() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override WriteResult Serialize(Writer writer)
		{
writer.WriteInt32(ConstructorId);
writer.WriteInt32(Progress);

return new WriteResult();

		}

		public override ReadResult<IObject> Deserialize(Reader reader)
		{
			var tryprogress = reader.ReadInt32();
if(tryprogress.IsError){
return ReadResult<IObject>.Move(tryprogress);
}
Progress = tryprogress.Value;
return new ReadResult<IObject>(this);

		}
		
		public override string ToString()
		{
		    return "sendMessageUploadPhotoAction";
		}

		public override int GetConstructorId()
		{
			return ConstructorId;
		}
	}
}