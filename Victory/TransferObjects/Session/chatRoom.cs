using System.Runtime.Serialization;
namespace Victory.TransferObjects.Session
{
	[DataContract(Name = "chatRoom", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.Session")]
	public class chatRoom
	{
		[DataMember]
		public int channelCount {get; set;}
		[DataMember]
		public string longName {get; set;}
		[DataMember]
		public string shortName {get; set;}
	}
}
