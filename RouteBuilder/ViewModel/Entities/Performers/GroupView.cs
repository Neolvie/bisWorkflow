using System.Collections.ObjectModel;
using Domain.Entities.Performers;
using RouteBuilder.ViewModel.Entities.Base;
using Shared.Entities.Performers;

namespace RouteBuilder.ViewModel.Entities.Performers
{
  public class GroupView : PerformerBaseView<Group>
  {
    public ObservableCollection<IPerformer> Performers { get; set; }

    public GroupView()
    {
      Performers = new ObservableCollection<IPerformer>(Entity.Performers);
    }
  }
}