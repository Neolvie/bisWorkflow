using System;
using System.Collections.Generic;
using Shared.Entities.Performers;
using Shared.Route;
using Shared.Route.Blocks;

namespace Domain.Route.Blocks
{
  public class Notice : BaseBlock
  {
    public override Guid TypeGuid => new Guid("4327BBC2-D683-4FCE-A889-35CB48A6E39C");

    public List<Performer> Performers = new List<Performer>(); 
    public string Subject { get; set; }
    public string Text { get; set; }

    public Notice()
    {
      BlockType = BlockType.Notice;
    }

    public override void BeforeStart()
    {

    }

    public override void AfterEnd()
    {

    }
  }
}