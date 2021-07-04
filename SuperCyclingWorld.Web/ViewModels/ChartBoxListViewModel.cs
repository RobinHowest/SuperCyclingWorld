using SuperCyclingWorld.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCyclingWorld.Web.ViewModels
{
    public class ChartBoxListViewModel
    {
        public List<ChartBoxViewModel> ChartBoxViewModels { get; set; } = new List<ChartBoxViewModel>();
    }
}
