using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "UserSettings", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class UserSettings
	{
		[DataMember]
		public uint desktopResHeight {get; set;}
		[DataMember]
		public uint desktopResWidth {get; set;}
		[DataMember]
		public bool fullscreen {get; set;}
		[DataMember]
		public uint gameResHeight {get; set;}
		[DataMember]
		public uint gameResWidth {get; set;}
		[DataMember]
		public uint globalDetailLevel {get; set;}
		[DataMember]
		public long userID {get; set;}
	}
}
