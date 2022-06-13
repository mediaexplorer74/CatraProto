/*
CatraProto, a C# library that implements the MTProto protocol and the Telegram API.
Copyright (C) 2022 Aquatica <aquathing@protonmail.com>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using System.Collections.Generic;
using CatraProto.TL;
using CatraProto.TL.Interfaces;
using CatraProto.TL.Results;

#nullable disable
namespace CatraProto.Client.TL.Schemas.CloudChats.Messages
{
    public partial class ChatInviteImporters : CatraProto.Client.TL.Schemas.CloudChats.Messages.ChatInviteImportersBase
    {


        [Newtonsoft.Json.JsonIgnore]
        public static int ConstructorId { get => -2118733814; }

        [Newtonsoft.Json.JsonProperty("count")]
        public sealed override int Count { get; set; }

        [Newtonsoft.Json.JsonProperty("importers")]
        public sealed override List<CatraProto.Client.TL.Schemas.CloudChats.ChatInviteImporterBase> Importers { get; set; }

        [Newtonsoft.Json.JsonProperty("users")]
        public sealed override List<CatraProto.Client.TL.Schemas.CloudChats.UserBase> Users { get; set; }


#nullable enable
        public ChatInviteImporters(int count, List<CatraProto.Client.TL.Schemas.CloudChats.ChatInviteImporterBase> importers, List<CatraProto.Client.TL.Schemas.CloudChats.UserBase> users)
        {
            Count = count;
            Importers = importers;
            Users = users;

        }
#nullable disable
        internal ChatInviteImporters()
        {
        }

        public override void UpdateFlags()
        {

        }

        public override WriteResult Serialize(Writer writer)
        {
            writer.WriteInt32(ConstructorId);
            writer.WriteInt32(Count);
            var checkimporters = writer.WriteVector(Importers, false);
            if (checkimporters.IsError)
            {
                return checkimporters;
            }
            var checkusers = writer.WriteVector(Users, false);
            if (checkusers.IsError)
            {
                return checkusers;
            }

            return new WriteResult();

        }

        public override ReadResult<IObject> Deserialize(Reader reader)
        {
            var trycount = reader.ReadInt32();
            if (trycount.IsError)
            {
                return ReadResult<IObject>.Move(trycount);
            }
            Count = trycount.Value;
            var tryimporters = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.ChatInviteImporterBase>(ParserTypes.Object, nakedVector: false, nakedObjects: false);
            if (tryimporters.IsError)
            {
                return ReadResult<IObject>.Move(tryimporters);
            }
            Importers = tryimporters.Value;
            var tryusers = reader.ReadVector<CatraProto.Client.TL.Schemas.CloudChats.UserBase>(ParserTypes.Object, nakedVector: false, nakedObjects: false);
            if (tryusers.IsError)
            {
                return ReadResult<IObject>.Move(tryusers);
            }
            Users = tryusers.Value;
            return new ReadResult<IObject>(this);

        }

        public override string ToString()
        {
            return "messages.chatInviteImporters";
        }

        public override int GetConstructorId()
        {
            return ConstructorId;
        }

#nullable enable
        public override IObject? Clone()
        {
            var newClonedObject = new ChatInviteImporters
            {
                Count = Count,
                Importers = new List<CatraProto.Client.TL.Schemas.CloudChats.ChatInviteImporterBase>()
            };
            foreach (var importers in Importers)
            {
                var cloneimporters = (CatraProto.Client.TL.Schemas.CloudChats.ChatInviteImporterBase?)importers.Clone();
                if (cloneimporters is null)
                {
                    return null;
                }
                newClonedObject.Importers.Add(cloneimporters);
            }
            newClonedObject.Users = new List<CatraProto.Client.TL.Schemas.CloudChats.UserBase>();
            foreach (var users in Users)
            {
                var cloneusers = (CatraProto.Client.TL.Schemas.CloudChats.UserBase?)users.Clone();
                if (cloneusers is null)
                {
                    return null;
                }
                newClonedObject.Users.Add(cloneusers);
            }
            return newClonedObject;

        }
#nullable disable
    }
}