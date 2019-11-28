using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "VisualPartTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class VisualPartTrans
	{
		[DataMember]
		public int PartHash {get; set;}
		[DataMember]
		public int SlotHash {get; set;}
	}
}
