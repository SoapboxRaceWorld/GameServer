using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "SystemInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class SystemInfo
	{
		[DataMember]
		public System.String Branch {get; set;}
		[DataMember]
		public System.String ChangeList {get; set;}
		[DataMember]
		public System.String ClientVersion {get; set;}
		[DataMember]
		public System.Boolean ClientVersionCheck {get; set;}
		[DataMember]
		public System.String Deployed {get; set;}
		[DataMember]
		public System.Boolean EntitlementsToDownload {get; set;}
		[DataMember]
		public System.Boolean ForcePermanentSession {get; set;}
		[DataMember]
		public System.String JidPrepender {get; set;}
		[DataMember]
		public System.String LauncherServiceUrl {get; set;}
		[DataMember]
		public System.String NucleusNamespace {get; set;}
		[DataMember]
		public System.String NucleusNamespaceWeb {get; set;}
		[DataMember]
		public System.Int32 PersonaCacheTimeout {get; set;}
		[DataMember]
		public System.String PortalDomain {get; set;}
		[DataMember]
		public System.String PortalSecureDomain {get; set;}
		[DataMember]
		public System.String PortalStoreFailurePage {get; set;}
		[DataMember]
		public System.String PortalTimeOut {get; set;}
		[DataMember]
		public System.String ShardName {get; set;}
		[DataMember]
		public System.DateTime Time {get; set;}
		[DataMember]
		public System.String Version {get; set;}
	}
}
