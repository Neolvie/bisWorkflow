namespace Shared.Entities.Core
{
  public interface ILogin : IEntity
  {
    string Username { get; set; }
    string Password { get; set; }
  }
}