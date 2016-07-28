using RouteBuilder.ViewModel.Entities.Base;
using Shared.Route;

namespace RouteBuilder.ViewModel.Entities.Route
{
  public class RouteView : RouteBaseView<IRoute>
  {
    public RouteView()
    {
      
    }

    public RouteView(IRoute entity) : base(entity)
    {
      
    }
  }
}