using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "BasketItemTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class BasketItemTrans
	{
		[DataMember]
		public System.String ProductId {get; set;}
		[DataMember]
		public System.Int32 Quantity {get; set;}
	}
}
