using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "InvalidBasketItemTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class InvalidBasketItemTrans
	{
		[DataMember]
		public int Index {get; set;}
		[DataMember]
		public int Reason {get; set;}
	}
}
