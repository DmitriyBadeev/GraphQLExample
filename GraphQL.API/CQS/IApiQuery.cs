using MediatR;

namespace GraphQL.API.CQS;

public interface IApiQuery<out T> : IRequest<T>
{
}