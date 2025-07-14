using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRBS.Model
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }

        [Column(TypeName ="varchar(100)"),Required]
        public string HotelName { get; set; }

        [Column(TypeName ="varchar(200)"),Required]
        public string HotelLocation { get; set; }

        //Navigation property
        public ICollection<Branch> Branches { get; set; }
    }

}
    