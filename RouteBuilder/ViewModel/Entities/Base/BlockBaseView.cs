using System.Collections.ObjectModel;
using RouteBuilder.ViewModel.Entities.Route;
using Shared.Entities.Core;
using Shared.Route.Blocks;

namespace RouteBuilder.ViewModel.Entities.Base
{
  public abstract class BlockBaseView<T> : EntityBaseView<T> where T : IBlock
  {
    public ObservableCollection<BlockView> Prev { get; set; }
    public ObservableCollection<BlockView> Next { get; set; }

    public BlockType BlockType
    {
      get { return Entity.BlockType; }
      set
      {
        Entity.BlockType = value;
        OnPropertyChanged();
      }
    }

    public string ResultText
    {
      get { return Entity.ResultText; }
      set
      {
        Entity.ResultText = value;
        OnPropertyChanged();
      }
    }

    public BlockResult? Result
    {
      get { return Entity.Result; }
      set
      {
        Entity.Result = value;
        OnPropertyChanged();
      }
    }

    public BlockState? State
    {
      get { return Entity.State; }
      set
      {
        Entity.State = value;
        OnPropertyChanged();
      }
    }
  }
}