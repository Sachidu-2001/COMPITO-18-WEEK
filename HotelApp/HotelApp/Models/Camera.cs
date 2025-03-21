using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Models
{
    public class Camera
    {
        [Key]
        public int CameraId { get; set; }

        [Required]

        public int Numero {  get; set; }

        [Required]

        public string Tipo { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Prezzo { get; set; }

        public ICollection<Prenotazione> Prenotazioni { get; set; } = new List<Prenotazione>();
    }
}
