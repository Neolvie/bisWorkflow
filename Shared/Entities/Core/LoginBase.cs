namespace Shared.Entities.Core
{
  public abstract class LoginBase : Entity, ILogin
  {
    public string Username { get; set; }
    public string Password { get; set; }
  }
}