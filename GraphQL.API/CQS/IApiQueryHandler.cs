using MediatR;

namespace GraphQL.API.CQS;

public interface IApiQueryHandler<in TQuery, TResult> : IRequestHandler<TQuery, TResult>
    where TQuery : IApiQuery<TResult>
{
}