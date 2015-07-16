﻿// ***********************************************************************
// Copyright (c) 2015, Anshoo Arora (Relevant Codes). All rights reserved.
//
// Copyrights licensed under the New BSD License.
//
// See the accompanying LICENSE file for terms.
// ***********************************************************************

namespace RelevantCodes.ExtentReports.Model
{
    using System;
    using System.Collections.Generic;

    internal class SystemProperties
    {
        public Dictionary<string, string> Info;

        public SystemProperties()
        {
            Info = new Dictionary<string, string>();
        }
    }
}