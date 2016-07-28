using RouteBuilder.ViewModel.Entities.Route;
using Shared.Entities.Core;
using Shared.Entities.Workflow;
using Shared.Route;

namespace RouteBuilder.ViewModel.Entities.Base
{
  public abstract class TaskBaseView : EntityBaseView<ITask>
  {
    public RouteView Route { get; set; }

    public TaskBaseView()
    {
      
    }

    public TaskBaseView(ITask entity)
    {
      if (entity == null)
        return;

      Entity = entity;

      Route = new RouteView() { Entity = Entity.Route };
    }
  }
}