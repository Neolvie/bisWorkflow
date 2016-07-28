using System.Collections.Generic;
using Shared.Entities.Core;
using Shared.Extenders;

namespace Shared.Route.Blocks
{
  public abstract class BaseBlock : Entity, IBlock
  {
    public List<IBlock> Prev { get; set; }
    public List<IBlock> Next { get; set; }
    public BlockType BlockType { get; set; }
    public string ResultText { get; set; }
    public BlockResult? Result { get; set; }
    public BlockState? State { get; set; }

    public override string Name => BlockType.GetDescription();

    public abstract void BeforeStart();
    public abstract void AfterEnd();
  }
}