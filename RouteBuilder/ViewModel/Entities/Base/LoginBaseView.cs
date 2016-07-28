using Shared.Entities.Core;

namespace RouteBuilder.ViewModel.Entities.Base
{
  public abstract class LoginBaseView<T> : EntityBaseView<T> where T : ILogin
  {
    public string Username
    {
      get { return Entity.Username; }
      set { Entity.Username = value; }
    }

    public string Password
    {
      get { return Entity.Password; }
      set
      {
        Entity.Password = value;
        OnPropertyChanged();
      }
    }
  }

}