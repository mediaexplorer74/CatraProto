using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats
{
	public partial class Folder : CatraProto.Client.TL.Schemas.CloudChats.FolderBase
	{
		[Flags]
		public enum FlagsEnum 
		{
			AutofillNewBroadcasts = 1 << 0,
			AutofillPublicGroups = 1 << 1,
			AutofillNewCorrespondents = 1 << 2,
			Photo = 1 << 3
		}

        public static int StaticConstructorId { get => -11252123; }
        [Newtonsoft.Json.JsonIgnore]
        public int ConstructorId { get => StaticConstructorId; }
        
[Newtonsoft.Json.JsonIgnore]
		public int Flags { get; set; }

[Newtonsoft.Json.JsonProperty("autofill_new_broadcasts")]
		public sealed override bool AutofillNewBroadcasts { get; set; }

[Newtonsoft.Json.JsonProperty("autofill_public_groups")]
		public sealed override bool AutofillPublicGroups { get; set; }

[Newtonsoft.Json.JsonProperty("autofill_new_correspondents")]
		public sealed override bool AutofillNewCorrespondents { get; set; }

[Newtonsoft.Json.JsonProperty("id")]
		public sealed override int Id { get; set; }

[Newtonsoft.Json.JsonProperty("title")]
		public sealed override string Title { get; set; }

[Newtonsoft.Json.JsonProperty("photo")]
		public sealed override CatraProto.Client.TL.Schemas.CloudChats.ChatPhotoBase Photo { get; set; }


        #nullable enable
 public Folder (int id,string title)
{
 Id = id;
Title = title;
 
}
#nullable disable
        internal Folder() 
        {
        }
		
		public override void UpdateFlags() 
		{
			Flags = AutofillNewBroadcasts ? FlagsHelper.SetFlag(Flags, 0) : FlagsHelper.UnsetFlag(Flags, 0);
			Flags = AutofillPublicGroups ? FlagsHelper.SetFlag(Flags, 1) : FlagsHelper.UnsetFlag(Flags, 1);
			Flags = AutofillNewCorrespondents ? FlagsHelper.SetFlag(Flags, 2) : FlagsHelper.UnsetFlag(Flags, 2);
			Flags = Photo == null ? FlagsHelper.UnsetFlag(Flags, 3) : FlagsHelper.SetFlag(Flags, 3);

		}

		public override void Serialize(Writer writer)
		{
writer.Write(ConstructorId);
			UpdateFlags();
			writer.Write(Flags);
			writer.Write(Id);
			writer.Write(Title);
			if(FlagsHelper.IsFlagSet(Flags, 3))
			{
				writer.Write(Photo);
			}


		}

		public override void Deserialize(Reader reader)
		{
			Flags = reader.Read<int>();
			AutofillNewBroadcasts = FlagsHelper.IsFlagSet(Flags, 0);
			AutofillPublicGroups = FlagsHelper.IsFlagSet(Flags, 1);
			AutofillNewCorrespondents = FlagsHelper.IsFlagSet(Flags, 2);
			Id = reader.Read<int>();
			Title = reader.Read<string>();
			if(FlagsHelper.IsFlagSet(Flags, 3))
			{
				Photo = reader.Read<CatraProto.Client.TL.Schemas.CloudChats.ChatPhotoBase>();
			}


		}
				
		public override string ToString()
		{
		    return "folder";
		}
	}
}