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
	public partial class KeyboardButtonRow : CatraProto.Client.TL.Schemas.CloudChats.KeyboardButtonRowBase
	{


        [Newtonsoft.Json.JsonIgnore]
        public static int ConstructorId { get => 2002815875; }
        
[Newtonsoft.Json.JsonProperty("buttons")]
		public sealed override List<CatraProto.Client.TL.Schemas.CloudChats.KeyboardButtonBase> Buttons { get; set; }


        #nullable enable
 public KeyboardButtonRow (List<CatraProto.Client.TL.Schemas.CloudChats.KeyboardButtonBase> buttons)
{
 Buttons = buttons;
 
}
#nullable disable
        internal KeyboardButtonRow() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override WriteResult Serialize(Writer writer)
		{
writer.WriteInt32(ConstructorId);
var checkbuttons = 			writer.WriteVector(Buttons, false);
if(checkbuttons.IsError){
 return checkbuttons; 
}

return new WriteResult();

		}

		public override ReadResult<IObject> Deserialize(Reader reader)
		{
			var trybuttons = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.KeyboardButtonBase>(ParserTypes.Object, nakedVector: false, nakedObjects: false);
if(trybuttons.IsError){
return ReadResult<IObject>.Move(trybuttons);
}
Buttons = trybuttons.Value;
return new ReadResult<IObject>(this);

		}
		
		public override string ToString()
		{
		    return "keyboardButtonRow";
		}

		public override int GetConstructorId()
		{
			return ConstructorId;
		}
	}
}