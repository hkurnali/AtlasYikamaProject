﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtlasYikamaProject.DAL.Entitys
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}