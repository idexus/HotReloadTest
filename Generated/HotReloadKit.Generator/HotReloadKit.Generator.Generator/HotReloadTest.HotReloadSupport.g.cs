﻿//
// <auto-generated>
//

using System;
using System.Net;

namespace HotReloadTestApp
{
    public static class HotReloadSupport
    {

        public static IPAddress[] IdeIPs =
#if DEBUG
        {
            new IPAddress(new byte[] {127, 0, 0, 1}),
            new IPAddress(new byte[] {10, 0, 5, 2}),
        };
#else
        { };
#endif
    }
}

