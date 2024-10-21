using Monobu.Practice6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Monobu.Practice6.Commands
{
    public sealed class OnClickCommand : ICommand
    {
        private readonly PanelViewModel _panelViewModel;

        public OnClickCommand(PanelViewModel panelViewModel)
        {
            _panelViewModel = panelViewModel;
            _panelViewModel.PropertyChanged += (s, e) => CanExecuteChanged?.Invoke(s, e);
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return _panelViewModel.PanelStatus == PanelStatus.Initial;
        }

        public void Execute(object? parameter)
        {
            if (GameMaster.CurrentNumber == _panelViewModel.Content)
            {
                _panelViewModel.PanelStatus = PanelStatus.Correct;
                GameMaster.CurrentNumber = _panelViewModel.Content + 1;
            }
            else
            {
                _panelViewModel.PanelStatus = PanelStatus.Initial;
            }
            _panelViewModel.OnClicked.Invoke(_panelViewModel.Content, _panelViewModel.PanelStatus);
        }
    }
}
