﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrapping.Model
{
    public class Site
    {
        public string Resolve;
        public string ContentSelector;
        public string LinkSelector;
        public string NameSelector;
        public string[] WrongParts;
    }
}