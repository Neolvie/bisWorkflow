using System.ComponentModel;

namespace Shared.Entities.Workflow
{
  public enum AssignmentResult
  {
    [Description("Выполнено")]
    Done = 0,

    [Description("Не выполнено")]
    Rejected = 1,

    [Description("Отменено")]
    Aborted = 2
  }
}