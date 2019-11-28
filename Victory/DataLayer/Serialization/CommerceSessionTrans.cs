using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CommerceSessionTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CommerceSessionTrans
	{
		[DataMember]
		public Victory.DataLayer.Serialization.BasketTrans Basket {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.EntitlementTrans EntitlementsToSell {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.OwnedCarTrans UpdatedCar {get; set;}
	}
}
