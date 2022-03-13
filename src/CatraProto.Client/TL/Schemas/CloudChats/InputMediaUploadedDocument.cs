using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
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

        public static int StaticConstructorId { get => 1530447553; }
        [Newtonsoft.Json.JsonIgnore]
        public int ConstructorId { get => StaticConstructorId; }
        
[Newtonsoft.Json.JsonIgnore]
		public int Flags { get; set; }

[Newtonsoft.Json.JsonProperty("nosound_video")]
		public bool NosoundVideo { get; set; }

[Newtonsoft.Json.JsonProperty("force_file")]
		public bool ForceFile { get; set; }

[Newtonsoft.Json.JsonProperty("file")]
		public CatraProto.Client.TL.Schemas.CloudChats.InputFileBase File { get; set; }

[Newtonsoft.Json.JsonProperty("thumb")]
		public CatraProto.Client.TL.Schemas.CloudChats.InputFileBase Thumb { get; set; }

[Newtonsoft.Json.JsonProperty("mime_type")]
		public string MimeType { get; set; }

[Newtonsoft.Json.JsonProperty("attributes")]
		public IList<CatraProto.Client.TL.Schemas.CloudChats.DocumentAttributeBase> Attributes { get; set; }

[Newtonsoft.Json.JsonProperty("stickers")]
		public IList<CatraProto.Client.TL.Schemas.CloudChats.InputDocumentBase> Stickers { get; set; }

[Newtonsoft.Json.JsonProperty("ttl_seconds")]
		public int? TtlSeconds { get; set; }


        #nullable enable
 public InputMediaUploadedDocument (CatraProto.Client.TL.Schemas.CloudChats.InputFileBase file,string mimeType,IList<CatraProto.Client.TL.Schemas.CloudChats.DocumentAttributeBase> attributes)
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

		public override void Serialize(Writer writer)
		{
writer.Write(ConstructorId);
			UpdateFlags();
			writer.Write(Flags);
			writer.Write(File);
			if(FlagsHelper.IsFlagSet(Flags, 2))
			{
				writer.Write(Thumb);
			}

			writer.Write(MimeType);
			writer.Write(Attributes);
			if(FlagsHelper.IsFlagSet(Flags, 0))
			{
				writer.Write(Stickers);
			}

			if(FlagsHelper.IsFlagSet(Flags, 1))
			{
				writer.Write(TtlSeconds.Value);
			}


		}

		public override void Deserialize(Reader reader)
		{
			Flags = reader.Read<int>();
			NosoundVideo = FlagsHelper.IsFlagSet(Flags, 3);
			ForceFile = FlagsHelper.IsFlagSet(Flags, 4);
			File = reader.Read<CatraProto.Client.TL.Schemas.CloudChats.InputFileBase>();
			if(FlagsHelper.IsFlagSet(Flags, 2))
			{
				Thumb = reader.Read<CatraProto.Client.TL.Schemas.CloudChats.InputFileBase>();
			}

			MimeType = reader.Read<string>();
			Attributes = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.DocumentAttributeBase>();
			if(FlagsHelper.IsFlagSet(Flags, 0))
			{
				Stickers = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.InputDocumentBase>();
			}

			if(FlagsHelper.IsFlagSet(Flags, 1))
			{
				TtlSeconds = reader.Read<int>();
			}


		}
				
		public override string ToString()
		{
		    return "inputMediaUploadedDocument";
		}
	}
}