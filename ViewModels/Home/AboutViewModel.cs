using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNetCore.Models;

namespace TestNetCore.ViewModels.Home
{
    public class AboutViewModel
    {
        public AboutViewModel()
        {
            Developers = new List<Developer>();
        }

        public string Heading { get; set; }
        public List<Developer> Developers { get; set; }
    }
}
