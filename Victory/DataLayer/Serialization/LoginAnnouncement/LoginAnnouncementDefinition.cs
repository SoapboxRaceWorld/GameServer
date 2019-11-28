using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.LoginAnnouncement
{
	[DataContract(Name = "LoginAnnouncementDefinition", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.LoginAnnouncement")]
	public class LoginAnnouncementDefinition
	{
		[DataMember]
		public Victory.DataObjects.Objects.LoginAnnouncement.LoginAnnouncementContext Context {get; set;}
		[DataMember]
		public int Id {get; set;}
		[DataMember]
		public int ImageChecksum {get; set;}
		[DataMember]
		public string ImageUrl {get; set;}
		[DataMember]
		public string Target {get; set;}
		[DataMember]
		public Victory.DataObjects.Objects.LoginAnnouncement.LoginAnnouncementType Type {get; set;}
	}
}
