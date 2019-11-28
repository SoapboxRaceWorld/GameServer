using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "EntitlementItemTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class EntitlementItemTrans
	{
		[DataMember]
		public string EntitlementId {get; set;}
		[DataMember]
		public int Quantity {get; set;}
	}
}
