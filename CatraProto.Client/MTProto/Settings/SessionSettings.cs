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

using CatraProto.Client.MTProto.Session.Interfaces;

namespace CatraProto.Client.MTProto.Settings
{
    public class SessionSettings
    {
        public string SessionName { get; }
        public DatabaseSettings DatabaseSettings { get; }
        internal IAsyncSessionSerializer SessionSerializer { get; }
        public SessionSettings(IAsyncSessionSerializer sessionSerializer, DatabaseSettings databaseSettings, string sessionName)
        {
            DatabaseSettings = databaseSettings;
            SessionSerializer = sessionSerializer;
            SessionName = sessionName;
        }
    }
}