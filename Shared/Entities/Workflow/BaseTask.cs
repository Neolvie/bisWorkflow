using Shared.Entities.Core;
using Shared.Route;

namespace Shared.Entities.Workflow
{
  public abstract class BaseTask : Entity, ITask
  {
    public IRoute Route { get; set; }
  }
}