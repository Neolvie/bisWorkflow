using System.Collections.Generic;
using Shared.Entities.Core;

namespace Shared.Route.Blocks
{
  public interface IBlock : IEntity
  {
    List<IBlock> Prev { get; set; }
    List<IBlock> Next { get; set; }
    BlockType BlockType { get; set; }
    string ResultText { get; set; }
    BlockResult? Result { get; set; }
    BlockState? State { get; set; }

    void BeforeStart();
    void AfterEnd();
  }
}