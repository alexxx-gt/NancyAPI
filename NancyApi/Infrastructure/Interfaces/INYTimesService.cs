using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NancyApi.DTOs;

namespace NancyApi.Infrastructure.Interfaces
{
    public interface INYTimesService
    {
        List<ArticleView> GetList(string section);
        ArticleView GetFirst(string section);
        List<ArticleView> GetFilteredByUpadtedDate(string section);
        List<ArticleView> GetList(string section);
        List<ArticleView> GetList(string section);
    }
}
