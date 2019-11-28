using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "EntitlementTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class EntitlementTrans
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.EntitlementItemTrans> Items {get; set;}
	}
}
