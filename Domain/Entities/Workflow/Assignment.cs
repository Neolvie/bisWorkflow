using System;
using Shared.Entities.Workflow;

namespace Domain.Entities.Workflow
{
  public class Assignment : BaseAssignment
  {
    public override Guid TypeGuid => new Guid("0FF64FAF-BB2F-4F6B-8866-01A45C155254");
  }
}