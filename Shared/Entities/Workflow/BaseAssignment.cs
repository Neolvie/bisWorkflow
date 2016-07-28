using System;
using Shared.Entities.Core;
using Shared.Entities.Performers;

namespace Shared.Entities.Workflow
{
  public abstract class BaseAssignment : Entity, IAssignment
  {
    public IPerformer Performer { get; set; }
    public string Subject { get; set; }
    public string Text { get; set; }
    public DateTime DeadLine { get; set; }
    public AssignmentResult? Result { get; set; }
  }
}