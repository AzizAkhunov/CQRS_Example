using MediatR;

namespace YandexTaxi.Application.UseCases.Users.Commands
{
    public class DeleteUserCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
