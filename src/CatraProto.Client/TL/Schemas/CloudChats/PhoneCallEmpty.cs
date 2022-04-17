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
	public partial class PhoneCallEmpty : CatraProto.Client.TL.Schemas.CloudChats.PhoneCallBase
	{


        [Newtonsoft.Json.JsonIgnore]
        public static int ConstructorId { get => 1399245077; }
        
[Newtonsoft.Json.JsonProperty("id")]
		public sealed override long Id { get; set; }


        #nullable enable
 public PhoneCallEmpty (long id)
{
 Id = id;
 
}
#nullable disable
        internal PhoneCallEmpty() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override WriteResult Serialize(Writer writer)
		{
writer.WriteInt32(ConstructorId);
writer.WriteInt64(Id);

return new WriteResult();

		}

		public override ReadResult<IObject> Deserialize(Reader reader)
		{
			var tryid = reader.ReadInt64();
if(tryid.IsError){
return ReadResult<IObject>.Move(tryid);
}
Id = tryid.Value;
return new ReadResult<IObject>(this);

		}
		
		public override string ToString()
		{
		    return "phoneCallEmpty";
		}

		public override int GetConstructorId()
		{
			return ConstructorId;
		}
	}
}