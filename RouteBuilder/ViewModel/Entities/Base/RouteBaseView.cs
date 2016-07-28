using System.Collections.ObjectModel;
using RouteBuilder.ViewModel.Entities.Route;
using Shared.Route;
using Shared.Route.Blocks;

namespace RouteBuilder.ViewModel.Entities.Base
{
  public abstract class RouteBaseView<T> : EntityBaseView<T> where T : IRoute
  {
    public bool IsValid
    {
      get { return Entity.IsValid; }
      set
      {
        Entity.IsValid = value;
        OnPropertyChanged();
      }
    }

    public ObservableCollection<BlockView> Blocks { get; set; }

    public RouteBaseView()
    {

    }

    public RouteBaseView(T entity)
    {
      Entity = entity;

      Blocks = new ObservableCollection<BlockView>();

      foreach (var block in Entity.Blocks)
      {
        var blockView = new BlockView { Entity = block };
        Blocks.Add(blockView);
      }
    }
  }
}