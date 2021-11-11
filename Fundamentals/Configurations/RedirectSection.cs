﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Fundamentals.Configurations
{
    public class RedirectSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(RedirectCollection))]
        public RedirectCollection Redirects { get { return (RedirectCollection)base[""]; } }
    }
}