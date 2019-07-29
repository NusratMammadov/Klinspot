using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klinspot.ViewModels
{
    public class PageHeader
    {
        public string Name { get; set; }

        public string BackgroundPhoto { get; set; }

        public Dictionary<string,string> Breadcrumbs { get; set; }
    }
}