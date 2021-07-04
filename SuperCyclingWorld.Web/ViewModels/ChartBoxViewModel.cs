using SuperCyclingWorld.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.ViewModels
{
    public class ChartBoxViewModel
    {
        public string ChartName { get; set; }
        public string ChartPicture { get; set; }

        public ChartBoxViewModel(ChartBox chartBox)
        {
            ChartName = chartBox.Name;
            ChartPicture = chartBox.Picture;
        }
    }
}
