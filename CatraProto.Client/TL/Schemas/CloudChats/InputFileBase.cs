using CatraProto.TL;
using CatraProto.TL.Results;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using CatraProto.TL.Interfaces;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats
{
    public abstract class InputFileBase : IObject
    {
        [Newtonsoft.Json.JsonProperty("id")] public abstract long Id { get; set; }

        [Newtonsoft.Json.JsonProperty("parts")]
        public abstract int Parts { get; set; }

        [Newtonsoft.Json.JsonProperty("name")] public abstract string Name { get; set; }

        public abstract void UpdateFlags();
        public abstract ReadResult<IObject> Deserialize(Reader reader);
        public abstract WriteResult Serialize(Writer writer);
        public abstract int GetConstructorId();
#nullable enable
        public abstract IObject? Clone();
        public abstract bool Compare(IObject other);
#nullable disable
    }
}