using System;
using Shared.Entities.Core;

namespace RouteBuilder.ViewModel.Entities.Base
{
  public abstract class EntityBaseView<T> : ViewModelBase<T> where T : IEntity
  {
    private T _entity;

    public T Entity
    {
      get { return _entity; }
      set
      {
        _entity = value;
        OnPropertyChanged();
      }
    }

    public int Id => Entity.Id;

    public int? ExternamId => Entity.ExternalId;

    public string Name
    {
      get { return Entity.Name; }
      set
      {
        Entity.Name = value;
        OnPropertyChanged();
      }
    }

    public Guid TypeGuid => Entity.TypeGuid;

    public DateTime Created
    {
      get { return Entity.Created; }
      set
      {
        Entity.Created = value;
        OnPropertyChanged();
      }
    }

    public DateTime Modified
    {
      get { return Entity.Modified; }
      set
      {
        Entity.Modified = value;
        OnPropertyChanged();
      }
    }
  }
}