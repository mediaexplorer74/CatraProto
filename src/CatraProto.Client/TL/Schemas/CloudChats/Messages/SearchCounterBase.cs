using CatraProto.TL;
using CatraProto.TL.Results;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using CatraProto.TL.Interfaces;
#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats.Messages
{
    public abstract class SearchCounterBase : IObject
    {

[Newtonsoft.Json.JsonProperty("inexact")]
		public abstract bool Inexact { get; set; }

[Newtonsoft.Json.JsonProperty("filter")]
		public abstract CatraProto.Client.TL.Schemas.CloudChats.MessagesFilterBase Filter { get; set; }

[Newtonsoft.Json.JsonProperty("count")]
		public abstract int Count { get; set; }

        public abstract void UpdateFlags();
        public abstract ReadResult<IObject> Deserialize(Reader reader);
        public abstract WriteResult Serialize(Writer writer);
        public abstract int GetConstructorId();
    }
}
