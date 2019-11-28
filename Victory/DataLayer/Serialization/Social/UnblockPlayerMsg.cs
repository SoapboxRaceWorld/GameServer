using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Social
{
	[DataContract(Name = "UnblockPlayerMsg", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social")]
	public class UnblockPlayerMsg
	{
		[DataMember]
		public System.Int64 userId {get; set;}
	}
}
