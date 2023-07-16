using GraphQL.API.CQS;

namespace GraphQL.API.Features;

public static class GetBookById
{
    public record Query(long Id) : IApiQuery<Book?>;
    
    private class Handler : IApiQueryHandler<Query, Book?>
    {
        private readonly BookRepository _bookRepository;

        public Handler(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        
        public async Task<Book?> Handle(Query request, CancellationToken cancellationToken)
        {
            return _bookRepository.GetById(request.Id);
        }
    }
}