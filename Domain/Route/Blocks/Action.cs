using System;
using Shared.Route;
using Shared.Route.Blocks;

namespace Domain.Route.Blocks
{
  public class Action : BaseBlock
  {
    public override Guid TypeGuid => new Guid("54E2676D-5CEF-4D15-92EB-11B09D8E346C");

    public Action()
    {
      BlockType = BlockType.Action;
    }

    public override void BeforeStart()
    {

    }

    public override void AfterEnd()
    {

    }
  }
}