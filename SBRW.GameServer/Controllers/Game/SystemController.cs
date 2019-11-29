using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Victory.Service;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class SystemController : ControllerBase
    {
        [HttpGet("systeminfo")]
        public async Task<SystemInfo> GetSystemInfo()
        {
            return await Task.FromResult(new SystemInfo
            {
                Branch = "dev",
                ChangeList = "1234",
                ClientVersion = "1614b",
                ClientVersionCheck = true,
                Deployed = DateTimeOffset.Now.ToString("G"),
                EntitlementsToDownload = true,
                ForcePermanentSession = true,
                JidPrepender = "nfsw",
                LauncherServiceUrl = "http://127.0.0.1:7575",
                NucleusNamespace = "nfsw",
                NucleusNamespaceWeb = "nfsw_web",
                PersonaCacheTimeout = 900,
                PortalDomain = "portal.sbrw.io",
                PortalSecureDomain = "portal.sbrw.io",
                PortalStoreFailurePage = "portal.sbrw.io/fail",
                PortalTimeOut = "900",
                ShardName = "SBRW",
                Time = DateTime.Now,
                Version = "4201"
            });
        }
    }
}