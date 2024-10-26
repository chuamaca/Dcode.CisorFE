using AutoMapper;
using Dcode.Pos.Application.Configuration;
using Dcode.Pos.Application.DataBase.Bookings.Commands.CreateBooking;
using Dcode.Pos.Application.DataBase.Bookings.Queries.GetAllBookings;
using Dcode.Pos.Application.DataBase.Bookings.Queries.GetBookingsByDocumentNumber;
using Dcode.Pos.Application.DataBase.Bookings.Queries.GetBookingsByType;
using Dcode.Pos.Application.DataBase.Customer.Commands.CreateCustomer;
using Dcode.Pos.Application.DataBase.Customer.Commands.DeleteCustomer;
using Dcode.Pos.Application.DataBase.Customer.Commands.UpdateCustomer;
using Dcode.Pos.Application.DataBase.Customer.Queries.GetAllCustomers;
using Dcode.Pos.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;
using Dcode.Pos.Application.DataBase.Customer.Queries.GetCustomerById;
using Dcode.Pos.Application.DataBase.User.Commands.CreateUser;
using Dcode.Pos.Application.DataBase.User.Commands.DeleteUser;
using Dcode.Pos.Application.DataBase.User.Commands.UpdateUser;
using Dcode.Pos.Application.DataBase.User.Commands.UpdateUserPassword;
using Dcode.Pos.Application.DataBase.User.Queries.GetAllUser;
using Dcode.Pos.Application.DataBase.User.Queries.GetUserById;
using Dcode.Pos.Application.DataBase.User.Queries.GetUserByUserNameAndPassword;
using Dcode.Pos.Application.Validators.Booking;
using Dcode.Pos.Application.Validators.Customer;
using Dcode.Pos.Application.Validators.User;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Dcode.Pos.Application
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());
            });

            services.AddSingleton(mapper.CreateMapper());

            #region User
            services.AddTransient<ICreateUserCommand, CreateUserCommand>();
            services.AddTransient<IUpdateUserCommand, UpdateUserCommand>();
            services.AddTransient<IDeleteUserCommand, DeleteUserCommand>();
            services.AddTransient<IUpdateUserPasswordCommand, UpdateUserPasswordCommand>();
            services.AddTransient<IGetAllUserQuery, GetAllUserQuery>();
            services.AddTransient<IGetUserByIdQuery, GetUserByIdQuery>();
            services.AddTransient<IGetUserByUserNameAndPasswordQuery, GetUserByUserNameAndPasswordQuery>();
            #endregion

            #region Customer
            services.AddTransient<ICreateCustomerCommand, CreateCustomerCommand>();
            services.AddTransient<IUpdateCustomerCommand, UpdateCustomerCommand>();
            services.AddTransient<IDeleteCustomerCommand, DeleteCustomerCommand>();
            services.AddTransient<IGetAllCustomerQuery, GetAllCustomerQuery>();
            services.AddTransient<IGetCustomerByIdQuery, GetCustomerByIdQuery>();
            services.AddTransient<IGetCustomerByDocumentNumberQuery, GetCustomerByDocumentNumberQuery>();

            #endregion

            #region Booking

            services.AddTransient<ICreateBookingCommand, CreateBookingCommand>();
            services.AddTransient<IGetAllBookingsQuery, GetAllBookingsQuery>();
            services.AddTransient<IGetBookingsByDocumentNumberQuery, GetBookingsByDocumentNumberQuery>();
            services.AddTransient<IGetBookingsByTypeQuery, GetBookingsByTypeQuery>();
            #endregion

            #region Validator
            services.AddScoped<IValidator<CreateUserModel>, CreateUserValidator>();
            services.AddScoped<IValidator<UpdateUserModel>, UpdateUserValidator>();
            services.AddScoped<IValidator<UpdateUserPasswordModel>, UpdateUserPasswordValidator>();
            services.AddScoped<IValidator<(string, string)>, GetUserByUserNameAndPasswordValidator>();

            services.AddScoped<IValidator<CreateCustomerModel>, CreateCustomerValidator>();
            services.AddScoped<IValidator<UpdateCustomerModel>, UpdateCustomerValidator>();


            services.AddScoped<IValidator<CreateBookingModel>, CreateBookingValidator>();


            #endregion


            return services;
        }
    }
}
