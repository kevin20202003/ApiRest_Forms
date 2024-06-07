using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRest_Forms.ApiModel
{
    public class Apis
    {
        public string UrlPost { get; set; }
        public Apis()
        {
            this.UrlPost = "https://jsonplaceholder.typicode.com/posts";
        }
    }
    
}
