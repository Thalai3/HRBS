using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRBS.Model
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        [Column(TypeName ="varchar(200)")]
        public string Address { get; set; }

        [Column(TypeName ="varchar(100)")]
        public string Contact { get; set; }

        // Navigation property 
        public ICollection<Room> Rooms { get; set; }
    }
}
