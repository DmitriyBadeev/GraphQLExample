using GraphQL.API.CQS;

namespace GraphQL.API.Features;

public static class CreateBook
{
    public record Command(Book Book) : IApiCommand<bool>;
    
    private class Handler : IApiCommandHandler<Command, bool>
    {
        private readonly BookRepository _bookRepository;

        public Handler(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        
        public async Task<bool> Handle(Command request, CancellationToken cancellationToken)
        {
            _bookRepository.CreateBook(request.Book);
            return true;
        }
    }
}