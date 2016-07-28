using System.ComponentModel;

namespace Shared.Route.Blocks
{
  public enum BlockResult
  {
    [Description("Выполнено")]
    Done = 0,

    [Description("Не выполнено")]
    Rejected = 1,

    [Description("Отменено")]
    Aborted = 2
  }
}