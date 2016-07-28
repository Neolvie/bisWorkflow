using System.ComponentModel;

namespace Shared.Route.Blocks
{
  public enum BlockState
  {
    [Description("Не стартован")]
    NotStarted = 0,

    [Description("В работе")]
    InWork = 1,

    [Description("Завершен")]
    Done = 2
  }
}