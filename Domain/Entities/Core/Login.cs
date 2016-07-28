using System;
using Shared.Entities.Core;

namespace Domain.Entities.Core
{
  public class Login : LoginBase
  {
    public override Guid TypeGuid => new Guid("72D72998-A665-46CF-8DC0-199D8DD57481");
  }
}