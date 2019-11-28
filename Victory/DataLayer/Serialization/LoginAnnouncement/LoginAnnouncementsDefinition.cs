using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.LoginAnnouncement
{
	[DataContract(Name = "LoginAnnouncementsDefinition", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.LoginAnnouncement")]
	public class LoginAnnouncementsDefinition
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.LoginAnnouncement.LoginAnnouncementDefinition> Announcements {get; set;}
		[DataMember]
		public string ImagesPath {get; set;}
	}
}
