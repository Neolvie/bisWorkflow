using System;
using Shared.Entities.Core;
using Shared.Entities.Performers;

namespace Shared.Entities.Workflow
{
  public interface IAssignment : IEntity
  {
    IPerformer Performer { get; set; }
    string Subject { get; set; }
    string Text { get; set; }
    DateTime DeadLine { get; set; }
    AssignmentResult? Result { get; set; }
  }
}