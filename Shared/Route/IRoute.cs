using System.Collections.Generic;
using Shared.Entities.Core;
using Shared.Route.Blocks;

namespace Shared.Route
{
  public interface IRoute : IEntity
  {
    bool IsValid { get; set; }

    List<IBlock> Blocks { get; set; }
  }
}