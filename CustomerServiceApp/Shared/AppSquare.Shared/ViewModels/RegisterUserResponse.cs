namespace AppSquare.Shared.ViewModels;

public class RegisterUserResponse
{
    public bool IsSucceeded { get; set; }
    public IEnumerable<string> Errors { get; set; }
}
