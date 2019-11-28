using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CommerceSessionResultTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CommerceSessionResultTrans
	{
		[DataMember]
		public Victory.DataLayer.Serialization.InvalidBasketTrans InvalidBasket {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.InventoryItemTrans> InventoryItems {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.CommerceResultStatus Status {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.OwnedCarTrans UpdatedCar {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.WalletTrans> Wallets {get; set;}
	}
}
