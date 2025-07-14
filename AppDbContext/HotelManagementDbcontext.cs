using HRBS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HRBS.AppDbContext
{
    public class HotelManagementDbcontext : DbContext
    {
        public HotelManagementDbcontext(DbContextOptions<HotelManagementDbcontext> options) : base(options)
        {

        }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<Room> Room { get; set; }
    }
}
