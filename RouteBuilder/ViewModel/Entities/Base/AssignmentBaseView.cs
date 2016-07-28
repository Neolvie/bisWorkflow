using System;
using Shared.Entities.Core;
using Shared.Entities.Performers;
using Shared.Entities.Workflow;

namespace RouteBuilder.ViewModel.Entities.Base
{
  public abstract class AssignmentBaseView<T> : EntityBaseView<T> where T : IAssignment
  {
    public IPerformer Performer
    {
      get { return Entity.Performer; }
      set
      {
        Entity.Performer = value;
        OnPropertyChanged();
      }
    }

    public string Subject
    {
      get { return Entity.Subject; }
      set
      {
        Entity.Subject = value;
        OnPropertyChanged();
      }
    }

    public string Text
    {
      get { return Entity.Text; }
      set
      {
        Entity.Text = value;
        OnPropertyChanged();
      }
    }

    public DateTime DeadLine
    {
      get { return Entity.DeadLine; }
      set
      {
        Entity.DeadLine = value;
        OnPropertyChanged();
      }
    }

    public AssignmentResult? Result
    {
      get { return Entity.Result; }
      set
      {
        Entity.Result = value;
        OnPropertyChanged();
      }
    }
  }
}