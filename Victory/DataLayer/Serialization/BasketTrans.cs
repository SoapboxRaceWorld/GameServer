using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "BasketTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class BasketTrans
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.BasketItemTrans> Items {get; set;}
	}
}
