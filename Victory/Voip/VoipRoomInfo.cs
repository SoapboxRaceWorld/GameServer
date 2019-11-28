using System.Runtime.Serialization;
namespace Victory.Voip
{
	[DataContract(Name = "VoipRoomInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Voip")]
	public class VoipRoomInfo
	{
		[DataMember]
		public System.String Token {get; set;}
	}
}
