namespace clean_hello_world.Application.Common.Interfaces;

public interface IUser
{
    string? Id { get; }
    IList<string>? Roles { get;}
}
