﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUI
{
    public class PlatformOperations : IPlatformOperations
    {
        public string GetOrientation()
        {
#if NETFX_CORE
            return Windows.Graphics.Display.DisplayInformation.GetForCurrentView().CurrentOrientation.ToString();
#else
            return null;
#endif
        }
    }
}
