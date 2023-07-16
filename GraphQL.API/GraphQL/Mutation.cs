using GraphQL.API.Features;
using MediatR;

namespace GraphQL.API.GraphQL;

public class Mutation
{
    public async Task<bool> CreateBook([Service] IMediator mediator, CreateBook.Command command, CancellationToken ct) => 
        await mediator.Send(command, ct);
}