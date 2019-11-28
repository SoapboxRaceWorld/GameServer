using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CommerceItemTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CommerceItemTrans
	{
		[DataMember]
		public System.Int32 Hash {get; set;}
		[DataMember]
		public System.String Title {get; set;}
	}
}
