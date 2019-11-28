using System.Runtime.Serialization;
namespace Victory.TransferObjects.Session
{
	[DataContract(Name = "chatRoom", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.Session")]
	public class chatRoom
	{
		[DataMember]
		public System.Int32 channelCount {get; set;}
		[DataMember]
		public System.String longName {get; set;}
		[DataMember]
		public System.String shortName {get; set;}
	}
}
