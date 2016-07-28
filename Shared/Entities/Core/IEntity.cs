using System;

namespace Shared.Entities.Core
{
  public interface IEntity
  {
    int Id { get; set; }
    int? ExternalId { get; set; }
    string Name { get; set; }
    Guid TypeGuid { get; }
    DateTime Created { get; set; }
    DateTime Modified { get; set; }
  }
}