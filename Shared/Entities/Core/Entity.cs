using System;

namespace Shared.Entities.Core
{
  public abstract class Entity : IEntity
  {
    public int Id { get; set; }
    public int? ExternalId { get; set; }
    public virtual string Name { get; set; }
    public abstract Guid TypeGuid { get; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
  }
}