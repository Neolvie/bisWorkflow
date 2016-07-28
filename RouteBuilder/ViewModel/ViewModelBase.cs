using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RouteBuilder.ViewModel
{
  public class ViewModelBase<T> : INotifyPropertyChanged
  {
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