using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "VisualPartTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class VisualPartTrans
	{
		[DataMember]
		public System.Int32 PartHash {get; set;}
		[DataMember]
		public System.Int32 SlotHash {get; set;}
	}
}
