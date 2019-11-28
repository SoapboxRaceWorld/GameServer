using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "BasketItemTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class BasketItemTrans
	{
		[DataMember]
		public string ProductId {get; set;}
		[DataMember]
		public int Quantity {get; set;}
	}
}
