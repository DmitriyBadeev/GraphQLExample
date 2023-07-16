using GraphQL.API.CQS;

namespace GraphQL.API.Features;

public static class GetBooks
{
    public record Query() : IApiQuery<IEnumerable<Book>>;
    
    private class Handler : IApiQueryHandler<Query, IEnumerable<Book>>
    {
        private readonly BookRepository _bookRepository;

        public Handler(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> Handle(Query request, CancellationToken cancellationToken)
        {
            return _bookRepository.GetAll();
        }
    }
}