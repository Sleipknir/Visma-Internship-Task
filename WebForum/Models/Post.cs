﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebForum.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        
        public string UserNameId { get; set; }
        public virtual ApplicationUser UserName { get; set; }
        public virtual Forum Forum { get; set; }
        public virtual IEnumerable<PostReply> Replies { get; set; }

    }
}
