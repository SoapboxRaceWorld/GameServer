using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "SystemInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class SystemInfo
	{
		[DataMember]
		public string Branch {get; set;}
		[DataMember]
		public string ChangeList {get; set;}
		[DataMember]
		public string ClientVersion {get; set;}
		[DataMember]
		public bool ClientVersionCheck {get; set;}
		[DataMember]
		public string Deployed {get; set;}
		[DataMember]
		public bool EntitlementsToDownload {get; set;}
		[DataMember]
		public bool ForcePermanentSession {get; set;}
		[DataMember]
		public string JidPrepender {get; set;}
		[DataMember]
		public string LauncherServiceUrl {get; set;}
		[DataMember]
		public string NucleusNamespace {get; set;}
		[DataMember]
		public string NucleusNamespaceWeb {get; set;}
		[DataMember]
		public int PersonaCacheTimeout {get; set;}
		[DataMember]
		public string PortalDomain {get; set;}
		[DataMember]
		public string PortalSecureDomain {get; set;}
		[DataMember]
		public string PortalStoreFailurePage {get; set;}
		[DataMember]
		public string PortalTimeOut {get; set;}
		[DataMember]
		public string ShardName {get; set;}
		[DataMember]
		public System.DateTime Time {get; set;}
		[DataMember]
		public string Version {get; set;}
	}
}
