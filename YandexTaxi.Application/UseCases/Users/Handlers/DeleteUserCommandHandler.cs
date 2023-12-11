using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Absreactions;
using YandexTaxi.Application.UseCases.Users.Commands;

namespace YandexTaxi.Application.UseCases.Users.Handlers
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IYandexTaxiDbContext _context;

        public DeleteUserCommandHandler(IYandexTaxiDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
            try
            {
                if (user is null)
                {
                    return false;
                }
                else
                {
                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync(cancellationToken);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
