using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWAppUsingConverters
{
    public class StatusBarViewModel
    {
        public string StatusMessage { get; set; }
        public bool IsWorking { get; set; }

        public StatusBarViewModel()
        {
            StatusMessage = "Working!";
            IsWorking = false;
        }


    }
}
