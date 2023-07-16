using MediatR;

namespace GraphQL.API.CQS;

public interface IApiCommand<out T> : IRequest<T>
{
}