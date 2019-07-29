using Klinspot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klinspot.ViewModels
{
    public class NewsListPage
    {
        public PageHeader PageHeader { get; set; }

        public List<Blog> Blogs { get; set; }

        public int TotalPage { get; set; }

        public int ActivePage { get; set; }
    }
}