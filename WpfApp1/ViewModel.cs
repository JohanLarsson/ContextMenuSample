namespace WpfApp1
{
    using System.Collections.ObjectModel;
    using System.Windows;
    using System.Windows.Input;

    public class ViewModel
    {
        public ObservableCollection<Player> Players { get; } = new ObservableCollection<Player> { new Player() };

        public ICommand MyCommand { get; } = new RelayCommand(_ => MessageBox.Show("someone clicked"));
    }
}