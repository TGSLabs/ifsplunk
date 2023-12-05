using MediatR;

public class ReverseTextQuery : IRequest<string>
{
    public string Text { get; set; } = string.Empty;
}
