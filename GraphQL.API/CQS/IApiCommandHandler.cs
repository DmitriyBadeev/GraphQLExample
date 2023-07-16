using MediatR;

namespace GraphQL.API.CQS;

public interface IApiCommandHandler<in TCommand, TResult> : IRequestHandler<TCommand, TResult>
    where TCommand : IApiCommand<TResult>
{
}