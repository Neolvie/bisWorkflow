using System;
using Shared.Route;
using Shared.Route.Blocks;

namespace Domain.Route.Blocks
{
  public class And : BaseBlock
  {
    public override Guid TypeGuid => new Guid("92007027-1F7C-47BD-B350-53F035B068F9");

    public And()
    {
      BlockType = BlockType.And;
    }

    public override void BeforeStart()
    {

    }

    public override void AfterEnd()
    {

    }
  }
}