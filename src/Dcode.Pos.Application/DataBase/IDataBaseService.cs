using Dcode.Pos.Domain.Entities.Booking;
using Dcode.Pos.Domain.Entities.Customer;
using Dcode.Pos.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Dcode.Pos.Application.DataBase
{
    public interface IDataBaseService
    {
        DbSet<UserEntity> User { get; set; }
        DbSet<CustomerEntity> Customer { get; set; }
        DbSet<BookingEntity> Booking { get; set; }
        Task<bool> SaveAsync();
    }
}
