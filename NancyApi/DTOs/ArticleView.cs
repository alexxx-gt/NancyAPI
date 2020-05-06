using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NancyApi.DTOs
{
    public class ArticleView
    {
        public string Heading { get; set; }
        public DateTime Updated { get; set; }
        public string Link { get; set; }
    }
}
