using System;
using Shared.Route;
using Shared.Route.Blocks;

namespace Domain.Route.Blocks
{
  public class Condition : BaseBlock
  {
    public override Guid TypeGuid => new Guid("8D597DA1-97EC-40D9-B592-15407997192B");

    public string Text { get; set; }

    public Condition()
    {
      BlockType = BlockType.Condition;
    }

    public override void BeforeStart()
    {

    }

    public override void AfterEnd()
    {

    }
  }
}