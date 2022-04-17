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
	public partial class InputMediaUploadedDocument : CatraProto.Client.TL.Schemas.CloudChats.InputMediaBase
	{
		[Flags]
		public enum FlagsEnum 
		{
			NosoundVideo = 1 << 3,
			ForceFile = 1 << 4,
			Thumb = 1 << 2,
			Stickers = 1 << 0,
			TtlSeconds = 1 << 1
		}

        [Newtonsoft.Json.JsonIgnore]
        public static int ConstructorId { get => 1530447553; }
        
[Newtonsoft.Json.JsonIgnore]
		public int Flags { get; set; }

[Newtonsoft.Json.JsonProperty("nosound_video")]
		public bool NosoundVideo { get; set; }

[Newtonsoft.Json.JsonProperty("force_file")]
		public bool ForceFile { get; set; }

[Newtonsoft.Json.JsonProperty("file")]
		public CatraProto.Client.TL.Schemas.CloudChats.InputFileBase File { get; set; }

[MaybeNull]
[Newtonsoft.Json.JsonProperty("thumb")]
		public CatraProto.Client.TL.Schemas.CloudChats.InputFileBase Thumb { get; set; }

[Newtonsoft.Json.JsonProperty("mime_type")]
		public string MimeType { get; set; }

[Newtonsoft.Json.JsonProperty("attributes")]
		public List<CatraProto.Client.TL.Schemas.CloudChats.DocumentAttributeBase> Attributes { get; set; }

[MaybeNull]
[Newtonsoft.Json.JsonProperty("stickers")]
		public List<CatraProto.Client.TL.Schemas.CloudChats.InputDocumentBase> Stickers { get; set; }

[Newtonsoft.Json.JsonProperty("ttl_seconds")]
		public int? TtlSeconds { get; set; }


        #nullable enable
 public InputMediaUploadedDocument (CatraProto.Client.TL.Schemas.CloudChats.InputFileBase file,string mimeType,List<CatraProto.Client.TL.Schemas.CloudChats.DocumentAttributeBase> attributes)
{
 File = file;
MimeType = mimeType;
Attributes = attributes;
 
}
#nullable disable
        internal InputMediaUploadedDocument() 
        {
        }
		
		public override void UpdateFlags() 
		{
			Flags = NosoundVideo ? FlagsHelper.SetFlag(Flags, 3) : FlagsHelper.UnsetFlag(Flags, 3);
			Flags = ForceFile ? FlagsHelper.SetFlag(Flags, 4) : FlagsHelper.UnsetFlag(Flags, 4);
			Flags = Thumb == null ? FlagsHelper.UnsetFlag(Flags, 2) : FlagsHelper.SetFlag(Flags, 2);
			Flags = Stickers == null ? FlagsHelper.UnsetFlag(Flags, 0) : FlagsHelper.SetFlag(Flags, 0);
			Flags = TtlSeconds == null ? FlagsHelper.UnsetFlag(Flags, 1) : FlagsHelper.SetFlag(Flags, 1);

		}

		public override WriteResult Serialize(Writer writer)
		{
writer.WriteInt32(ConstructorId);
			UpdateFlags();

			writer.WriteInt32(Flags);
var checkfile = 			writer.WriteObject(File);
if(checkfile.IsError){
 return checkfile; 
}
			if(FlagsHelper.IsFlagSet(Flags, 2))
			{
var checkthumb = 				writer.WriteObject(Thumb);
if(checkthumb.IsError){
 return checkthumb; 
}
			}


			writer.WriteString(MimeType);
var checkattributes = 			writer.WriteVector(Attributes, false);
if(checkattributes.IsError){
 return checkattributes; 
}
			if(FlagsHelper.IsFlagSet(Flags, 0))
			{
var checkstickers = 				writer.WriteVector(Stickers, false);
if(checkstickers.IsError){
 return checkstickers; 
}
			}

			if(FlagsHelper.IsFlagSet(Flags, 1))
			{
writer.WriteInt32(TtlSeconds.Value);
			}


return new WriteResult();

		}

		public override ReadResult<IObject> Deserialize(Reader reader)
		{
			var tryflags = reader.ReadInt32();
if(tryflags.IsError){
return ReadResult<IObject>.Move(tryflags);
}
Flags = tryflags.Value;
			NosoundVideo = FlagsHelper.IsFlagSet(Flags, 3);
			ForceFile = FlagsHelper.IsFlagSet(Flags, 4);
			var tryfile = reader.ReadObject<CatraProto.Client.TL.Schemas.CloudChats.InputFileBase>();
if(tryfile.IsError){
return ReadResult<IObject>.Move(tryfile);
}
File = tryfile.Value;
			if(FlagsHelper.IsFlagSet(Flags, 2))
			{
				var trythumb = reader.ReadObject<CatraProto.Client.TL.Schemas.CloudChats.InputFileBase>();
if(trythumb.IsError){
return ReadResult<IObject>.Move(trythumb);
}
Thumb = trythumb.Value;
			}

			var trymimeType = reader.ReadString();
if(trymimeType.IsError){
return ReadResult<IObject>.Move(trymimeType);
}
MimeType = trymimeType.Value;
			var tryattributes = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.DocumentAttributeBase>(ParserTypes.Object, nakedVector: false, nakedObjects: false);
if(tryattributes.IsError){
return ReadResult<IObject>.Move(tryattributes);
}
Attributes = tryattributes.Value;
			if(FlagsHelper.IsFlagSet(Flags, 0))
			{
				var trystickers = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.InputDocumentBase>(ParserTypes.Object, nakedVector: false, nakedObjects: false);
if(trystickers.IsError){
return ReadResult<IObject>.Move(trystickers);
}
Stickers = trystickers.Value;
			}

			if(FlagsHelper.IsFlagSet(Flags, 1))
			{
				var tryttlSeconds = reader.ReadInt32();
if(tryttlSeconds.IsError){
return ReadResult<IObject>.Move(tryttlSeconds);
}
TtlSeconds = tryttlSeconds.Value;
			}

return new ReadResult<IObject>(this);

		}
		
		public override string ToString()
		{
		    return "inputMediaUploadedDocument";
		}

		public override int GetConstructorId()
		{
			return ConstructorId;
		}
	}
}