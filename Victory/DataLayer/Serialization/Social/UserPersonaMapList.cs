using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Social
{
	[DataContract(Name = "UserPersonaMapList", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social")]
	public class UserPersonaMapList
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.Social.UserPersonaMap> map {get; set;}
	}
}
