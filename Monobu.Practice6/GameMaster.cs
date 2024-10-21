using Monobu.Practice6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monobu.Practice6
{
    public static class GameMaster
    {
        public static int CurrentNumber = 1;

        public static bool IsDone(List<PanelControl> panelControls)
        {
            return panelControls.All(a => ((PanelViewModel)a.DataContext).PanelStatus == PanelStatus.Correct);
        }
    }
}
