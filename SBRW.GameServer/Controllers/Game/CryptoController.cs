using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Victory.DataLayer.Serialization;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/crypto")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class CryptoController : ControllerBase
    {
        [HttpGet("cryptoticket")]
        public async Task<ClientServerCryptoTicket> GetCryptoTicket()
        {
            return await Task.FromResult(new ClientServerCryptoTicket
            {
                CryptoTicket = "Sj7D5hYQYuu8MYf2Wy4rkk6ECGBetjWLSzi3eMpPL54=",
                SessionKey = "0XqU4fcj1Hi2rg95cEJiyA==",
                TicketIv = "yvdxrThODYsMNTfEO2iwyQ=="
            });
        }
    }
}