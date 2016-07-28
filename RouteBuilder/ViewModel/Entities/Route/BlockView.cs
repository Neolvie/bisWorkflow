using System.Collections.ObjectModel;

using RouteBuilder.ViewModel.Entities.Base;
using Shared.Route.Blocks;

namespace RouteBuilder.ViewModel.Entities.Route
{
  public class BlockView : BlockBaseView<IBlock>
  {
    public BlockView()
    {
      
    }

    public BlockView(IBlock entity)
    {
      if (entity == null)
        return;

      Entity = entity;

      Prev = new ObservableCollection<BlockView>();

      foreach (var block in Entity.Prev)
      {
        var blockView = new BlockView { Entity = block };
        Prev.Add(blockView);
      }

      Next = new ObservableCollection<BlockView>();

      foreach (var block in Entity.Next)
      {
        var blockView = new BlockView { Entity = block };
        Next.Add(blockView);
      }
    }

  }
}