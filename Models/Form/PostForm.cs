﻿namespace il_mio_primo_blog.Models.Form
{
    public class PostForm
    {
        //model del db che con le views: create, read (list, details), update
        public Post Post { get; set; }

        //views: create, update, 
        public List<Category>? Categories { get; set; }

    }
}
