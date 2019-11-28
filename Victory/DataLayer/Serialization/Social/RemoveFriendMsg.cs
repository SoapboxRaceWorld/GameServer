using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Social
{
	[DataContract(Name = "RemoveFriendMsg", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social")]
	public class RemoveFriendMsg
	{
		[DataMember]
		public System.Int64 personaId {get; set;}
	}
}
