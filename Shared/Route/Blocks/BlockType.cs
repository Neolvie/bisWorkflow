using System.ComponentModel;

namespace Shared.Route.Blocks
{
  public enum BlockType
  {
    [Description("Действие")]
    Action = 0,

    [Description("Задание")]
    Assignment = 1,

    [Description("Условие")]
    Condition = 2,

    [Description("И")]
    And = 3,

    [Description("ИЛИ")]
    Or = 4,

    [Description("Уведомление")]
    Notice = 5
  }
}