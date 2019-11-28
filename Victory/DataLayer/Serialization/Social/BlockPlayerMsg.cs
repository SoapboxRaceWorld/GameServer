using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Social
{
	[DataContract(Name = "BlockPlayerMsg", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social")]
	public class BlockPlayerMsg
	{
		[DataMember]
		public long userId {get; set;}
	}
}
