using System;
using System.Collections.Generic;
using Shared.Entities.Performers;

namespace Domain.Entities.Performers
{
  public class Group : Performer
  {
    public override Guid TypeGuid => new Guid("6F52C378-7615-4E7E-AFC4-978F5E1D5517");

    public List<IPerformer> Performers = new List<IPerformer>(); 
  }
}