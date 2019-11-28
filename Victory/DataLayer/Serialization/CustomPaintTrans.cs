using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CustomPaintTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CustomPaintTrans
	{
		[DataMember]
		public System.Int32 Group {get; set;}
		[DataMember]
		public System.Int32 Hue {get; set;}
		[DataMember]
		public System.Int32 Sat {get; set;}
		[DataMember]
		public System.Int32 Slot {get; set;}
		[DataMember]
		public System.Int32 Var {get; set;}
	}
}
