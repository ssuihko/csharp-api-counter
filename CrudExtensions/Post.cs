﻿namespace CrudExtensions
{
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
