using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using ATagsCounter.Infrastructure;
using ATagsCounter.Models;

namespace ATagsCounter.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private DelegateCommand _startAndPauseCommand;
        private string _startAndPauseButtonContent = "Start";
        
        private CancellationTokenSource _cancellationTokenSource = new();
        private IEnumerable<UrlItem>? _urlItems;
        private string? _urlFilePath;

        public MainWindowViewModel()
        {
            _startAndPauseCommand = new DelegateCommand(Start);

        }

        public IEnumerable<UrlItem>? UrlItems
        {
            get => _urlItems;
            set
            {
                if (Equals(value, _urlItems)) return;
                _urlItems = value;
                OnPropertyChanged();
            }
        }

        public string? UrlFilePath
        {
            get => _urlFilePath;
            set
            {
                if (value == _urlFilePath) return;
                _urlFilePath = value;
                OnPropertyChanged();
            }
        }

        public string StartAndPauseButtonContent
        {
            get => _startAndPauseButtonContent;
            set
            {
                _startAndPauseButtonContent = value;
                OnPropertyChanged();
            }
        }
        
        public DelegateCommand StartAndPauseCommand
        {
            get => _startAndPauseCommand;
            set
            {
                _startAndPauseCommand = value;
                OnPropertyChanged();
            }
        }

        private async void Start()
        {
            
        }
        
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}