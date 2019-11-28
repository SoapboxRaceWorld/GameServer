using System.Runtime.Serialization;
namespace Victory.TransferObjects.User
{
	[DataContract(Name = "UserInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User")]
	public class UserInfo
	{
		[DataMember]
		public int defaultPersonaIdx {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.TransferObjects.User.ProfileData> personas {get; set;}
		[DataMember]
		public Victory.TransferObjects.User.User user {get; set;}
	}
}
