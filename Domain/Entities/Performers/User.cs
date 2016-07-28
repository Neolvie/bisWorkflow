using System;
using Domain.Entities.Core;
using Shared.Entities.Core;
using Shared.Entities.Performers;

namespace Domain.Entities.Performers
{
  public class User : Performer
  {
    public override Guid TypeGuid => new Guid("FE44C5A3-41F3-4D7B-81C2-2BCF9E98B76E");

    public string LastName { get; set; }

    public ILogin Login { get; set; }
  }
}