using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "EntitlementItemTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class EntitlementItemTrans
	{
		[DataMember]
		public System.String EntitlementId {get; set;}
		[DataMember]
		public System.Int32 Quantity {get; set;}
	}
}
