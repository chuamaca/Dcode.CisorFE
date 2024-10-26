using AutoMapper;
using Dcode.Pos.Application.DataBase.Bookings.Commands.CreateBooking;
using Dcode.Pos.Application.DataBase.Customer.Commands.CreateCustomer;
using Dcode.Pos.Application.DataBase.Customer.Commands.UpdateCustomer;
using Dcode.Pos.Application.DataBase.Customer.Queries.GetAllCustomers;
using Dcode.Pos.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;
using Dcode.Pos.Application.DataBase.Customer.Queries.GetCustomerById;
using Dcode.Pos.Application.DataBase.User.Commands.CreateUser;
using Dcode.Pos.Application.DataBase.User.Commands.UpdateUser;
using Dcode.Pos.Application.DataBase.User.Queries.GetAllUser;
using Dcode.Pos.Application.DataBase.User.Queries.GetUserById;
using Dcode.Pos.Application.DataBase.User.Queries.GetUserByUserNameAndPassword;
using Dcode.Pos.Domain.Entities.Booking;
using Dcode.Pos.Domain.Entities.Customer;
using Dcode.Pos.Domain.Entities.User;

namespace Dcode.Pos.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region User
            CreateMap<UserEntity, CreateUserModel>().ReverseMap();
            CreateMap<UserEntity, UpdateUserModel>().ReverseMap();
            CreateMap<UserEntity, GetAllUserModel>().ReverseMap();
            CreateMap<UserEntity, GetUserByIdModel>().ReverseMap();
            CreateMap<UserEntity, GetUserByUserNameAndPasswordModel>().ReverseMap();
            #endregion

            #region Customer
            CreateMap<CustomerEntity, CreateCustomerModel>().ReverseMap();
            CreateMap<CustomerEntity, UpdateCustomerModel>().ReverseMap();
            CreateMap<CustomerEntity, GetAllCustomerModel>().ReverseMap();
            CreateMap<CustomerEntity, GetCustomerByIdModel>().ReverseMap();
            CreateMap<CustomerEntity, GetCustomerByDocumentNumberModel>().ReverseMap();

            #endregion

            #region Booking
            CreateMap<BookingEntity, CreateBookingModel>().ReverseMap();


            #endregion
        }
    }
}
