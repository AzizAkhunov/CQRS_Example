using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexTaxi.Application.Absreactions;
using YandexTaxi.Application.UseCases.Users.Quarries;
using YandexTaxi.Domain.Entities;

namespace YandexTaxi.Application.UseCases.Users.Handlers
{
    public class GetAllUsersCommandHandler : IRequestHandler<GetAllUsersCommand,List<User>>
    {
        private readonly IYandexTaxiDbContext _context;

        public GetAllUsersCommandHandler(IYandexTaxiDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> Handle(GetAllUsersCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _context.Users.ToListAsync();
                return res;
            }
            catch (Exception ex) { return null; }
        }
    }
}
