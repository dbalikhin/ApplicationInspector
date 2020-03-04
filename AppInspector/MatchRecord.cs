﻿// Copyright (C) Microsoft. All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

using Microsoft.ApplicationInspector.RulesEngine;


namespace Microsoft.ApplicationInspector.Commands
{
    public class MatchRecord
    {
        public LanguageInfo Language { get; set; }
        public string Filename { get; set; }
        public int Filesize { get; set; }
        public string TextSample { get; set; }
        public Issue Issue { get; set; }
        public string Excerpt { get; set; }
    }

}