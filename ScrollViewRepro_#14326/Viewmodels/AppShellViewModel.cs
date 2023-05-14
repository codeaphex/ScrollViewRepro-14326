using CommunityToolkit.Mvvm.Input;
using ScrollViewRepro__14326.Views;
using System.Reflection;

namespace ScrollViewRepro__14326.Viewmodels
{
    public class AppShellViewModel
    {
        IRelayCommand<ContentView> _showSubSettingsCommand;
        public IRelayCommand<ContentView> ShowSubSettingsCommand
        {
            get
            {
                return _showSubSettingsCommand ??=
                    new RelayCommand<ContentView>(
                        (contentView) =>
                        {
                            contentView.Content = new SubView();
                        },
                        (contentView) => true
                        );
            }
        }

        public string Version =>
            $"VERSION:{Environment.NewLine}{typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion}";
    }
}

