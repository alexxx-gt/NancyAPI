using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NancyApi.DTOs
{
    public class ArticleGroupByDateView
    {
        public string Date { get; set; }
        public int Total { get; set; }
    }
}
