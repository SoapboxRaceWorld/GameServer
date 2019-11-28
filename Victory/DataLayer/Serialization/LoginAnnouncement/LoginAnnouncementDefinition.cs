using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.LoginAnnouncement
{
	[DataContract(Name = "LoginAnnouncementDefinition", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.LoginAnnouncement")]
	public class LoginAnnouncementDefinition
	{
		[DataMember]
		public Victory.DataObjects.Objects.LoginAnnouncement.LoginAnnouncementContext Context {get; set;}
		[DataMember]
		public System.Int32 Id {get; set;}
		[DataMember]
		public System.Int32 ImageChecksum {get; set;}
		[DataMember]
		public System.String ImageUrl {get; set;}
		[DataMember]
		public System.String Target {get; set;}
		[DataMember]
		public Victory.DataObjects.Objects.LoginAnnouncement.LoginAnnouncementType Type {get; set;}
	}
}
