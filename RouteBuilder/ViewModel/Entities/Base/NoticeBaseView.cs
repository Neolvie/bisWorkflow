using Shared.Entities.Performers;
using Shared.Entities.Workflow;

namespace RouteBuilder.ViewModel.Entities.Base
{
  public abstract class NoticeBaseView : EntityBaseView<INotice>
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
  }
}