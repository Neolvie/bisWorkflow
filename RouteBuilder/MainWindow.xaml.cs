using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Domain.Route;
using Domain.Route.Blocks;
using RouteBuilder.ViewModel.Entities.Route;
using Shared.Extenders;

namespace RouteBuilder
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window, INotifyPropertyChanged
  {
    private RouteView _route;

    public RouteView Route
    {
      get { return _route; }
      set
      {
        _route = value;
        OnPropertyChanged();
      }
    }

    public MainWindow()
    {
      InitializeComponent();

      this.DataContext = this;

      var route = new Route();

      route.Blocks.Add(new Action());
      route.Blocks.Add(new Assignment());
      route.Blocks.Add(new Or());
      route.Blocks.Add(new Domain.Route.Blocks.Condition());

      Route = new RouteView(route);

    }

    private void Exit_OnClick(object sender, RoutedEventArgs e)
    {
      Application.Current.Shutdown();
    }

    private void AddBlock_OnClick(object sender, RoutedEventArgs e)
    {
      var blockForm = new BlockForm { Owner = this };
      blockForm.ShowDialog();
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      var handler = PropertyChanged;

      handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion

  }
}
