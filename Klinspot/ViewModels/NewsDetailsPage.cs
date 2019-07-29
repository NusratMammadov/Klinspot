using Klinspot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klinspot.ViewModels
{
    public class NewsDetailsPage
    {
        public PageHeader PageHeader { get; set; }

        public Blog Blog { get; set; }

        public string NextUrl { get; set; }

        public string PrevUrl { get; set; }
    }
}