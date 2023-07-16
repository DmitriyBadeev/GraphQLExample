using GraphQL.API.Features;
using MediatR;

namespace GraphQL.API.GraphQL;

public class Query
{
    public async Task<IEnumerable<Book>> GetBooks([Service] IMediator mediator, CancellationToken ct) => 
        await mediator.Send(new GetBooks.Query(), ct);
    
    public async Task<Book?> GetBook([Service] IMediator mediator, GetBookById.Query query, CancellationToken ct) => 
        await mediator.Send(query, ct);
}