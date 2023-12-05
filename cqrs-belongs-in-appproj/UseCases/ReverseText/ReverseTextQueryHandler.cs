using MediatR;

public class ReverseTextQueryHandler : IRequestHandler<ReverseTextQuery, string>
{
    public Task<string> Handle(ReverseTextQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new string(request.Text.Reverse().ToArray()));
    }
}