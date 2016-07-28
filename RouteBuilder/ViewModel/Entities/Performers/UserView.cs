using Domain.Entities.Performers;
using RouteBuilder.ViewModel.Entities.Base;
using RouteBuilder.ViewModel.Entities.Core;

namespace RouteBuilder.ViewModel.Entities.Performers
{
  public class UserView : PerformerBaseView<User>
  {
    public string LastName
    {
      get { return Entity.LastName; }
      set
      {
        Entity.LastName = value;
        OnPropertyChanged();
      }
    }

    public LoginView Login { get; set; }

    public UserView()
    {
      Login = new LoginView {Entity = Entity.Login};
    }
  }
}