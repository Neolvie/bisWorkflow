using System;
using Shared.Entities.Workflow;

namespace Domain.Entities.Workflow
{
  public class Task : BaseTask
  {
    public override Guid TypeGuid => new Guid("CB7D39E2-67EC-4C47-83F2-B181CE92FD1D");
  }
}