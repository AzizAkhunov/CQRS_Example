using MediatR;
using YandexTaxi.Domain.Entities;

namespace YandexTaxi.Application.UseCases.Users.Quarries
{
    public class GetAllUsersCommand : IRequest<List<User>>
    {
    }
}
