using System;
using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using System.Linq;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats.Photos
{
	public partial class ApiPhotos : CatraProto.Client.TL.Schemas.CloudChats.Photos.PhotosBase
	{


        public static int StaticConstructorId { get => -1916114267; }
        [Newtonsoft.Json.JsonIgnore]
        public int ConstructorId { get => StaticConstructorId; }
        
[Newtonsoft.Json.JsonProperty("photos")]
		public sealed override IList<CatraProto.Client.TL.Schemas.CloudChats.PhotoBase> Photos { get; set; }

[Newtonsoft.Json.JsonProperty("users")]
		public sealed override IList<CatraProto.Client.TL.Schemas.CloudChats.UserBase> Users { get; set; }


        #nullable enable
 public ApiPhotos (IList<CatraProto.Client.TL.Schemas.CloudChats.PhotoBase> photos,IList<CatraProto.Client.TL.Schemas.CloudChats.UserBase> users)
{
 Photos = photos;
Users = users;
 
}
#nullable disable
        internal ApiPhotos() 
        {
        }
		
		public override void UpdateFlags() 
		{

		}

		public override void Serialize(Writer writer)
		{
writer.Write(ConstructorId);
			writer.Write(Photos);
			writer.Write(Users);

		}

		public override void Deserialize(Reader reader)
		{
			Photos = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.PhotoBase>();
			Users = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.UserBase>();

		}
				
		public override string ToString()
		{
		    return "photos.photos";
		}
	}
}