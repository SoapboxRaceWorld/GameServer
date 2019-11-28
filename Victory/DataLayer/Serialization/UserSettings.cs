using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "UserSettings", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class UserSettings
	{
		[DataMember]
		public System.UInt32 desktopResHeight {get; set;}
		[DataMember]
		public System.UInt32 desktopResWidth {get; set;}
		[DataMember]
		public System.Boolean fullscreen {get; set;}
		[DataMember]
		public System.UInt32 gameResHeight {get; set;}
		[DataMember]
		public System.UInt32 gameResWidth {get; set;}
		[DataMember]
		public System.UInt32 globalDetailLevel {get; set;}
		[DataMember]
		public System.Int64 userID {get; set;}
	}
}
