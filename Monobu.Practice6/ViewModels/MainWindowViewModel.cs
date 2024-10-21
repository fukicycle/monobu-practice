using Monobu.Practice6.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Input;

namespace Monobu.Practice6.ViewModels
{
    public sealed class MainWindowViewModel : ViewModelBase
    {
        private int[] _numbers = Enumerable.Range(1, 25).ToArray();

        private List<PanelControl> _panelControls = new List<PanelControl>();
        public List<PanelControl> PanelControls
        {
            get { return _panelControls; }
            set
            {
                SetProperty(ref _panelControls, value);
            }
        }

        private string _time = "00:00.0";

        public string Time
        {
            get { return _time; }
            set { SetProperty(ref _time, value); }
        }

        private string _score = "0";

        public string Score
        {
            get { return _score; }
            set { SetProperty(ref _score, value); }
        }


        public System.Timers.Timer Timer { get; }
        private int _timeCount = 0;


        public MainWindowViewModel()
        {
            foreach (int i in _numbers.OrderBy(a => Guid.NewGuid()))
            {
                PanelControl panelControl = new PanelControl(i);
                PanelViewModel panelViewModel = (PanelViewModel)panelControl.DataContext;
                panelViewModel.OnClicked = PanelClicked;
                _panelControls.Add(panelControl);
            }
            Timer = new System.Timers.Timer(100);
            Timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object? sender, ElapsedEventArgs e)
        {
            TimeSpan ts = TimeSpan.FromMilliseconds(_timeCount * 100);
            Time = ts.ToString(@"mm\:ss\.f");
            _timeCount++;
        }

        private void PanelClicked(int number, PanelStatus panelStatus)
        {
            if (panelStatus == PanelStatus.Initial)
            {
                _timeCount = _timeCount + 50;
            }
            if (number == 1)
            {
                Timer.Start();
            }
            if (number == 25)
            {
                Timer.Stop();
                Score = (100000 / _timeCount).ToString();
            }
        }
    }
}
