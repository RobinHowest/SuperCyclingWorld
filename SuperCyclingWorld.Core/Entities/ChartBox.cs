﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SuperCyclingWorld.Core.Entities
{
    public class ChartBox
    {

        public string Name { get; set; }
        public string Picture { get; set; }

        public string ContentText { get; set; }

        public ChartBox(string name, string picture, string contentText)
        {
            Name = name;
            Picture = picture;
            ContentText = contentText;
        }
    }
}