using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexTaxi.Application.UseCases.Users.Commands
{
    public class CreateUsersCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
