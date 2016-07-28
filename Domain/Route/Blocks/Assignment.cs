using System;
using System.Collections.Generic;
using Shared.Entities.Performers;
using Shared.Route;
using Shared.Route.Blocks;

namespace Domain.Route.Blocks
{
  public class Assignment : BaseBlock
  {
    public override Guid TypeGuid => new Guid("416BA8E5-0358-4550-9E62-03BF9D06C717");

    public List<Performer> Performers = new List<Performer>(); 
    public string Subject { get; set; }
    public string Text { get; set; }
    public DateTime? DeadLine { get; set; }

    public Assignment()
    {
      BlockType = BlockType.Assignment;
    }

    public override void BeforeStart()
    {

    }

    public override void AfterEnd()
    {

    }
  }
}