using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Social
{
	[DataContract(Name = "BlockPlayerMsg", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social")]
	public class BlockPlayerMsg
	{
		[DataMember]
		public System.Int64 userId {get; set;}
	}
}
