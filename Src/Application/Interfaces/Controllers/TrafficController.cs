using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Src.Application.Services;

namespace Src.Application.Interfaces.Controllers;

[ApiController]
[Route("api/traffic")]
public class TrafficController : ControllerBase
{
    private readonly PacketProcessingService _packetProcessingService;

    public TrafficController(PacketProcessingService packetProcessingService)
    {
        _packetProcessingService = packetProcessingService;
    }

    [HttpPost("process")]
    public IActionResult ProcessTrafic(
        [FromBody] IEnumerable<TrafficPacket> packets)
    {
        _packetProcessingService.ProcessPackets(packets);
        return Ok(new { Message = "Pacotes processados com sucesso!" });
    }
}