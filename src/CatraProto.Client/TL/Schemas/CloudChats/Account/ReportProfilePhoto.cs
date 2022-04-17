using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using CatraProto.TL.Results;
using System.Diagnostics.CodeAnalysis;

using System.Linq;

#nullable disable

namespace CatraProto.Client.TL.Schemas.CloudChats.Account
{
	public partial class ReportProfilePhoto : IMethod
	{


        [Newtonsoft.Json.JsonIgnore]
        public static int ConstructorId { get => -91437323; }
        
[Newtonsoft.Json.JsonIgnore]
		ParserTypes IMethod.Type { get; init; } = ParserTypes.Bool;

[Newtonsoft.Json.JsonProperty("peer")]
		public CatraProto.Client.TL.Schemas.CloudChats.InputPeerBase Peer { get; set; }

[Newtonsoft.Json.JsonProperty("photo_id")]
		public CatraProto.Client.TL.Schemas.CloudChats.InputPhotoBase PhotoId { get; set; }

[Newtonsoft.Json.JsonProperty("reason")]
		public CatraProto.Client.TL.Schemas.CloudChats.ReportReasonBase Reason { get; set; }

[Newtonsoft.Json.JsonProperty("message")]
		public string Message { get; set; }

        
        #nullable enable
 public ReportProfilePhoto (CatraProto.Client.TL.Schemas.CloudChats.InputPeerBase peer,CatraProto.Client.TL.Schemas.CloudChats.InputPhotoBase photoId,CatraProto.Client.TL.Schemas.CloudChats.ReportReasonBase reason,string message)
{
 Peer = peer;
PhotoId = photoId;
Reason = reason;
Message = message;
 
}
#nullable disable
                
        internal ReportProfilePhoto() 
        {
        }
        
		public void UpdateFlags() 
		{

		}

		public WriteResult Serialize(Writer writer)
		{
writer.WriteInt32(ConstructorId);
var checkpeer = 			writer.WriteObject(Peer);
if(checkpeer.IsError){
 return checkpeer; 
}
var checkphotoId = 			writer.WriteObject(PhotoId);
if(checkphotoId.IsError){
 return checkphotoId; 
}
var checkreason = 			writer.WriteObject(Reason);
if(checkreason.IsError){
 return checkreason; 
}

			writer.WriteString(Message);

return new WriteResult();

		}

		public ReadResult<IObject> Deserialize(Reader reader)
		{
			var trypeer = reader.ReadObject<CatraProto.Client.TL.Schemas.CloudChats.InputPeerBase>();
if(trypeer.IsError){
return ReadResult<IObject>.Move(trypeer);
}
Peer = trypeer.Value;
			var tryphotoId = reader.ReadObject<CatraProto.Client.TL.Schemas.CloudChats.InputPhotoBase>();
if(tryphotoId.IsError){
return ReadResult<IObject>.Move(tryphotoId);
}
PhotoId = tryphotoId.Value;
			var tryreason = reader.ReadObject<CatraProto.Client.TL.Schemas.CloudChats.ReportReasonBase>();
if(tryreason.IsError){
return ReadResult<IObject>.Move(tryreason);
}
Reason = tryreason.Value;
			var trymessage = reader.ReadString();
if(trymessage.IsError){
return ReadResult<IObject>.Move(trymessage);
}
Message = trymessage.Value;
return new ReadResult<IObject>(this);

		}

		public override string ToString()
		{
		    return "account.reportProfilePhoto";
		}

		public int GetConstructorId()
		{
			return ConstructorId;
		}
	}
}