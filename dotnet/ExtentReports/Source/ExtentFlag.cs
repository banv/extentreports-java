﻿// ***********************************************************************
// Copyright (c) 2015, Anshoo Arora (Relevant Codes). All rights reserved.
//
// Copyrights licensed under the New BSD License.
//
// See the accompanying LICENSE file for terms.
// ***********************************************************************

namespace RelevantCodes.ExtentReports.Source
{
    using System;

    internal class ExtentFlag
    {
        public static string GetPlaceHolder(string flag)
        {
            return "<!--%%" + flag.ToUpper() + "%%-->";
        }
    }
}