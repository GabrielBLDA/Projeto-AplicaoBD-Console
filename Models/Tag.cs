﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Table ("[Tag]")]
    internal class Tag
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
