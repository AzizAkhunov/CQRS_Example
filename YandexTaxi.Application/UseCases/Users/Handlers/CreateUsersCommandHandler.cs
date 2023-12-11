using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexTaxi.Application.Absreactions;
using YandexTaxi.Application.UseCases.Users.Commands;
using YandexTaxi.Domain.Entities;

namespace YandexTaxi.Application.UseCases.Users.Handlers
{
    public class CreateUsersCommandHandler : IRequestHandler<CreateUsersCommand,bool>
    {
        private readonly IYandexTaxiDbContext _context;

        public CreateUsersCommandHandler(IYandexTaxiDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(CreateUsersCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var user = new User()
                {
                    Name = request.Name,
                    Number = request.Number,
                };
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
