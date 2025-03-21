using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Models
{
    public class Prenotazione
    {
        [Key]
        public Guid PrenotazioneId { get; set; }

        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }


        [Required]
        public int CameraId { get; set; }
        public Camera Camera { get; set; }

        [Required]
        public DateTime DataInizio { get; set; }

        [Required]
        public DateTime DataFine { get; set; }

        [Required]
        public string Stato { get; set; }
    }
}
