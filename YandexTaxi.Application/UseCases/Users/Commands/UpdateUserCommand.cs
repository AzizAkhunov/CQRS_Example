using MediatR;

namespace YandexTaxi.Application.UseCases.Users.Commands
{
    public class UpdateUserCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
