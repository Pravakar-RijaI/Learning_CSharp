﻿using System;
using System.Collections.Generic;

namespace Cookies
{
    internal class HttpCookie
    {
        private readonly Dictionary<string,string> _dictionary = new Dictionary<string,string>();
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
