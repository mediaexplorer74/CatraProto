using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats.Messages
{
	public partial class AvailableReactionsNotModified : CatraProto.Client.TL.Schemas.CloudChats.Messages.AvailableReactionsBase
	{


        public static int StaticConstructorId { get => -1626924713; }
        [Newtonsoft.Json.JsonIgnore]
        public int ConstructorId { get => StaticConstructorId; }
        

        
        public AvailableReactionsNotModified() 
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
		    return "messages.availableReactionsNotModified";
		}
	}
}