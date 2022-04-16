﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatraProto.Client.MTProto.Rpc.Interfaces;

namespace CatraProto.Client.MTProto.Rpc.RpcErrors.ClientErrors
{
    class SerializationFailed : RpcError
    {
        public override string ErrorDescription { get; }

        public SerializationFailed(string parserError) : base("An error occured while TL-serializing the request", -10400)
        {
            ErrorDescription = parserError;
        }
    }
}