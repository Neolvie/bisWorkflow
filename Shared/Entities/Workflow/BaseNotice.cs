using Shared.Entities.Core;
using Shared.Entities.Performers;

namespace Shared.Entities.Workflow
{
  public abstract class BaseNotice : Entity, INotice
  {
    public IPerformer Performer { get; set; }
    public string Subject { get; set; }
    public string Text { get; set; }
  }
}