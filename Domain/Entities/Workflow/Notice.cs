using System;
using Shared.Entities.Workflow;

namespace Domain.Entities.Workflow
{
  public class Notice : BaseNotice
  {
    public override Guid TypeGuid => new Guid("68749234-20F8-4615-9010-49E290276CA5");
  }
}