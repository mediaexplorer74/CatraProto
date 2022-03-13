using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats
{
	public partial class SendMessageHistoryImportAction : CatraProto.Client.TL.Schemas.CloudChats.SendMessageActionBase
	{


        public static int StaticConstructorId { get => -606432698; }
        [Newtonsoft.Json.JsonIgnore]
        public int ConstructorId { get => StaticConstructorId; }
        
[Newtonsoft.Json.JsonProperty("progress")]
		public int Progress { get; set; }


        #nullable enable
 public SendMessageHistoryImportAction (int progress)
{
 Progress = progress;
 
}
#nullable disable
        internal SendMessageHistoryImportAction() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override void Serialize(Writer writer)
		{
writer.Write(ConstructorId);
			writer.Write(Progress);

		}

		public override void Deserialize(Reader reader)
		{
			Progress = reader.Read<int>();

		}
				
		public override string ToString()
		{
		    return "sendMessageHistoryImportAction";
		}
	}
}