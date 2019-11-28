using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Social
{
	[DataContract(Name = "SocialNetworkInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social")]
	public class SocialNetworkInfo
	{
		[DataMember]
		public string facebookName {get; set;}
	}
}
