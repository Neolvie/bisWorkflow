using Shared.Entities.Core;
using Shared.Route;

namespace Shared.Entities.Workflow
{
  public interface ITask : IEntity
  {
    IRoute Route { get; set; }
  }
}