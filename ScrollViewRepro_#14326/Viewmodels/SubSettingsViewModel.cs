using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ScrollViewRepro__14326.Viewmodels
{
    public class SubSettingsViewModel : ObservableObject
    {
        private bool _isVisible;
        public bool IsVisible
        {
            get { return _isVisible; }
            set { SetProperty(ref _isVisible, value); }
        }

        IRelayCommand _showControlCommand;
        public IRelayCommand ShowControlCommand
        {
            get
            {
                return _showControlCommand ??=
                   new RelayCommand(() => { IsVisible = true; });
            }
        }

        IRelayCommand _hideControlCommand;
        public IRelayCommand HideControlCommand
        {
            get
            {
                return _hideControlCommand ??=
                   new RelayCommand(() => { IsVisible = false; });
            }
        }
    }
}
