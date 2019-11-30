using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Victory.DataLayer.Serialization;
using Victory.DataLayer.Serialization.LoginAnnouncement;
using Victory.Service;
using Victory.TransferObjects.News;

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

        [HttpGet("getrebroadcasters")]
        public async Task<List<UdpRelayInfo>> GetReBroadcasters()
        {
            return await Task.FromResult(new List<UdpRelayInfo>
            {
                new UdpRelayInfo {Host = "127.0.0.1", Port = 9999},
                new UdpRelayInfo {Host = "127.0.0.2", Port = 9899},
            });
        }

        [HttpGet("getregioninfo")]
        public async Task<RegionInfo> GetRegionInfo()
        {
            return await Task.FromResult(new RegionInfo
            {
                CountdownProposalInMilliseconds = 3000,
                DirectConnectTimeoutInMilliseconds = 1000,
                DropOutTimeInMilliseconds = 15000,
                EventLoadTimeoutInMilliseconds = 30000,
                HeartbeatIntervalInMilliseconds = 1000,
                UdpRelayBandwidthInBps = 9600,
                UdpRelayTimeoutInMilliseconds = 60000
            });
        }

        [HttpGet("LoginAnnouncements")]
        public async Task<LoginAnnouncementsDefinition> GetLoginAnnouncements([FromQuery] string language)
        {
            return await Task.FromResult(new LoginAnnouncementsDefinition
            {
                Announcements = new List<LoginAnnouncementDefinition>(),
                ImagesPath = "https://share.sbrw.io/img"
            });
        }

        [HttpGet("NewsArticles")]
        public async Task<List<NewsArticleTrans>> GetNewsArticles()
        {
            return await Task.FromResult(new List<NewsArticleTrans>
            {
                new NewsArticleTrans
                {
                    ExpiryTime = DateTime.Now.AddHours(1),
                    Filters = (int) NewsArticleFilters.NEWSFILTERMASK_All,
                    Type = (int) NewsArticleType.UnopenedGift,
                    PersonaId = 100L,
                    IconType = 4,
                    Parameters = "STORE_VANITY_NEON",
                    LongText_HALId = "TXT_NEWS_UNOPENEDGIFT_3",
                    ShortText_HALId = "TXT_NEWS_UNOPENEDGIFT_SHORT",
                    Sticky = 1,
                    Timestamp = DateTime.Now.Subtract(TimeSpan.FromMinutes(10)).Ticks,
                    NewsId = 14002
                }
            });
        }

        [HttpGet("heartbeat")]
        public async Task<HeartBeat> Heartbeat()
        {
            return await Task.FromResult(new HeartBeat
            {
                enabledBitField = 0, 
                MetagameFlags = 2
            });
        }
    }
}