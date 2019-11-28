using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Social
{
	[DataContract(Name = "UserPersonaMap", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social")]
	public class UserPersonaMap
	{
		[DataMember]
		public long personaId {get; set;}
		[DataMember]
		public long userId {get; set;}
	}
}
