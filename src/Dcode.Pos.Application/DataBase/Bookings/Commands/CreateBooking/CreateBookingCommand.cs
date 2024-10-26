
using AutoMapper;
using Dcode.Pos.Application.DataBase;
using Dcode.Pos.Domain.Entities.Booking;

namespace Dcode.Pos.Application.DataBase.Bookings.Commands.CreateBooking
{
    public class CreateBookingCommand : ICreateBookingCommand
    {
        private readonly IDataBaseService _databaseService;
        private readonly IMapper _mapper;
        public CreateBookingCommand(IDataBaseService databaseService,
            IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<CreateBookingModel> Execute(CreateBookingModel model)
        {
            var entity = _mapper.Map<BookingEntity>(model);
            entity.RegisterDate = DateTime.Now;
            await _databaseService.Booking.AddAsync(entity);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}
