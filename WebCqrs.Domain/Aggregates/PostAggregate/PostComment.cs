﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCqrs.Domain.Aggregates.PostAggregate
{
    public class PostComment
    {
        public Guid CommentId { get; private set; }

        public Guid PostId { get; private set; }

        public string Text { get; private set; }

        public Guid UserProfileId { get; private set; }

        public DateTime DateCreated { get; private set; }

        public DateTime LastModified { get; private set; }

        // Factories
        public static PostComment CreatePostComment(Guid postId, string text, Guid userProfileId) { 
            return new PostComment { 
                PostId = postId, 
                Text = text, 
                UserProfileId = userProfileId,
                DateCreated = DateTime.Now,
                LastModified = DateTime.Now
            }; 
        }

        //public methods
        public void UpdateCommentText(string text)
        {
            Text = text;
            LastModified = DateTime.Now;
        }
    }
}
