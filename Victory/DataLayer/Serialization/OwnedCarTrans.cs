using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "OwnedCarTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class OwnedCarTrans
	{
		[DataMember]
		public Victory.DataLayer.Serialization.CustomCarTrans CustomCar {get; set;}
		[DataMember]
		public System.Int32 Durability {get; set;}
		[DataMember]
		public System.DateTime ExpirationDate {get; set;}
		[DataMember]
		public System.Single Heat {get; set;}
		[DataMember]
		public System.Int64 Id {get; set;}
		[DataMember]
		public System.String OwnershipType {get; set;}
	}
}
