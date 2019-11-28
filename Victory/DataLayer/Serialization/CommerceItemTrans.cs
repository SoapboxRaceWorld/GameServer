using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CommerceItemTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CommerceItemTrans
	{
		[DataMember]
		public int Hash {get; set;}
		[DataMember]
		public string Title {get; set;}
	}
}
