using HRBS.AppDbContext;
using HRBS.Dto;
using HRBS.Dto.RequestDto;
using HRBS.Model;

namespace HRBS.Service
{
    public class HotelService(HotelManagementDbcontext hoteldbContext)
    {
        public async Task<ResponseDto> Add(HotelDto hotelDto)
        {
            string ErrorMessage = string.Empty;
            try
            {
                var hotel = new Hotel
                {
                    HotelName = hotelDto.Name,
                    HotelLocation = hotelDto.Location
                };
                var data = await hoteldbContext.Hotel.AddAsync(hotel);
                return new ResponseDto(true, "");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return new ResponseDto(false, ErrorMessage);

        }
    }
}
