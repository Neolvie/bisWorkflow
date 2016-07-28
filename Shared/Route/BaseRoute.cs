using System.Collections.Generic;
using System.Data;
using Shared.Entities.Core;
using Shared.Route.Blocks;

namespace Shared.Route
{
  public abstract class BaseRoute : Entity, IRoute
  {
    public bool IsValid { get; set; }

    public List<IBlock> Blocks { get; set; } = new List<IBlock>();
  }
}