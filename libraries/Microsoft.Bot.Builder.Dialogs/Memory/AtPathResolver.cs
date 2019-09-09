﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Microsoft.Bot.Builder.Dialogs.Memory
{
    /// <summary>
    /// Maps @ => turn.recognized.entitites.xxx[0].
    /// </summary>
    public class AtPathResolver : AliasPathResolver
    {
        public AtPathResolver()
            : base(alias: "@", prefix: "turn.recognized.entities.", postfix: "[0]")
        {
        }

        public override bool Matches(string path)
        {
            // override to make sure it doesn't match @@
            path = path.Trim();
            return path.StartsWith("@") && !path.StartsWith("@@");
        }
    }
}
