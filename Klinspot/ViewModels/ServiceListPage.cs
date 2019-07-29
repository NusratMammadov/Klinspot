using Klinspot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klinspot.ViewModels
{
    public class ServiceListPage
    {
        public PageHeader PageHeader { get; set; }

        public List<Service> Services { get; set; }

        public List<Package> Packages { get; set; }
    }
}