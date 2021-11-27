﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Post : AuditableNetity
    {


        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Post()
        {
        }

        public Post(int id, string title, string content)
        {
            (Id, Title, Content) = (id, title, content);
        }
    }
}