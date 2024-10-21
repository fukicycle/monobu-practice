using Monobu.Practice6.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Media;

namespace Monobu.Practice6.ViewModels
{
    public sealed class PanelViewModel : ViewModelBase
    {
        public PanelViewModel()
        {
            OnClick = new OnClickCommand(this);
        }
        private int _content;

        public int Content
        {
            get { return _content; }
            set
            {
                SetProperty(ref _content, value);
            }
        }

        private PanelStatus _panelStatus = PanelStatus.Initial;
        public PanelStatus PanelStatus
        {
            get { return _panelStatus; }
            set
            {
                SetProperty(ref _panelStatus, value);
            }
        }
        public ICommand OnClick { get; set; }

        public Action<int, PanelStatus> OnClicked { get; set; } = null!;
    }
}
