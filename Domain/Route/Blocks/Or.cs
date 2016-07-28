using System;
using Shared.Route;
using Shared.Route.Blocks;

namespace Domain.Route.Blocks
{
  public class Or : BaseBlock
  {
    public override Guid TypeGuid => new Guid("E38CDE20-DB41-4347-846A-C9A0B06339C4");

    public Or()
    {
      BlockType = BlockType.Or;
    }

    public override void BeforeStart()
    {

    }

    public override void AfterEnd()
    {

    }
  }
}