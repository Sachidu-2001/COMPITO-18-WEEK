using System.ComponentModel.DataAnnotations;

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

        public decimal Prezzo { get; set; }

        public ICollection<Prenotazione> Prenotazioni { get; set; } = new List<Prenotazione>();
    }
}
