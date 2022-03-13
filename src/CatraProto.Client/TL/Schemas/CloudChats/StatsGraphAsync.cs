using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats
{
	public partial class StatsGraphAsync : CatraProto.Client.TL.Schemas.CloudChats.StatsGraphBase
	{


        public static int StaticConstructorId { get => 1244130093; }
        [Newtonsoft.Json.JsonIgnore]
        public int ConstructorId { get => StaticConstructorId; }
        
[Newtonsoft.Json.JsonProperty("token")]
		public string Token { get; set; }


        #nullable enable
 public StatsGraphAsync (string token)
{
 Token = token;
 
}
#nullable disable
        internal StatsGraphAsync() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override void Serialize(Writer writer)
		{
writer.Write(ConstructorId);
			writer.Write(Token);

		}

		public override void Deserialize(Reader reader)
		{
			Token = reader.Read<string>();

		}
				
		public override string ToString()
		{
		    return "statsGraphAsync";
		}
	}
}