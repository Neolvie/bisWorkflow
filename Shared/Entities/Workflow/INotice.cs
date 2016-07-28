using Shared.Entities.Core;
using Shared.Entities.Performers;

namespace Shared.Entities.Workflow
{
  public interface INotice : IEntity
  {
    IPerformer Performer { get; set; }
    string Subject { get; set; }
    string Text { get; set; }
  }
}