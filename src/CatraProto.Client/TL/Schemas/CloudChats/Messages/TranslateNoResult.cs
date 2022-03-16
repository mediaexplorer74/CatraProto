using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats.Messages
{
	public partial class TranslateNoResult : CatraProto.Client.TL.Schemas.CloudChats.Messages.TranslatedTextBase
	{


        public static int StaticConstructorId { get => 1741309751; }
        [Newtonsoft.Json.JsonIgnore]
        public int ConstructorId { get => StaticConstructorId; }
        

        
        public TranslateNoResult() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override void Serialize(Writer writer)
		{
writer.Write(ConstructorId);

		}

		public override void Deserialize(Reader reader)
		{

		}
				
		public override string ToString()
		{
		    return "messages.translateNoResult";
		}
	}
}