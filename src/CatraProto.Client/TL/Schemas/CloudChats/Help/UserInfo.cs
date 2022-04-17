using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using CatraProto.TL.Results;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats.Help
{
	public partial class UserInfo : CatraProto.Client.TL.Schemas.CloudChats.Help.UserInfoBase
	{


        [Newtonsoft.Json.JsonIgnore]
        public static int ConstructorId { get => 32192344; }
        
[Newtonsoft.Json.JsonProperty("message")]
		public string Message { get; set; }

[Newtonsoft.Json.JsonProperty("entities")]
		public List<CatraProto.Client.TL.Schemas.CloudChats.MessageEntityBase> Entities { get; set; }

[Newtonsoft.Json.JsonProperty("author")]
		public string Author { get; set; }

[Newtonsoft.Json.JsonProperty("date")]
		public int Date { get; set; }


        #nullable enable
 public UserInfo (string message,List<CatraProto.Client.TL.Schemas.CloudChats.MessageEntityBase> entities,string author,int date)
{
 Message = message;
Entities = entities;
Author = author;
Date = date;
 
}
#nullable disable
        internal UserInfo() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override WriteResult Serialize(Writer writer)
		{
writer.WriteInt32(ConstructorId);

			writer.WriteString(Message);
var checkentities = 			writer.WriteVector(Entities, false);
if(checkentities.IsError){
 return checkentities; 
}

			writer.WriteString(Author);
writer.WriteInt32(Date);

return new WriteResult();

		}

		public override ReadResult<IObject> Deserialize(Reader reader)
		{
			var trymessage = reader.ReadString();
if(trymessage.IsError){
return ReadResult<IObject>.Move(trymessage);
}
Message = trymessage.Value;
			var tryentities = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.MessageEntityBase>(ParserTypes.Object, nakedVector: false, nakedObjects: false);
if(tryentities.IsError){
return ReadResult<IObject>.Move(tryentities);
}
Entities = tryentities.Value;
			var tryauthor = reader.ReadString();
if(tryauthor.IsError){
return ReadResult<IObject>.Move(tryauthor);
}
Author = tryauthor.Value;
			var trydate = reader.ReadInt32();
if(trydate.IsError){
return ReadResult<IObject>.Move(trydate);
}
Date = trydate.Value;
return new ReadResult<IObject>(this);

		}
		
		public override string ToString()
		{
		    return "help.userInfo";
		}

		public override int GetConstructorId()
		{
			return ConstructorId;
		}
	}
}