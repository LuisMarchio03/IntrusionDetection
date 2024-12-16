using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class TrafficPacket
    {
        [Key]
        public int Id { get; set; }
        public string SourceIP { get; set; }
        public string DestinationIP { get; set; }
        public string Protocol { get; set; }
        public int PacketSize { get; set; }
        public DateTime Timestamp { get; set; }
    }
}