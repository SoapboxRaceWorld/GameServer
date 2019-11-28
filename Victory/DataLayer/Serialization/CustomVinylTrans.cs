using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CustomVinylTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CustomVinylTrans
	{
		[DataMember]
		public int Hash {get; set;}
		[DataMember]
		public int Hue1 {get; set;}
		[DataMember]
		public int Hue2 {get; set;}
		[DataMember]
		public int Hue3 {get; set;}
		[DataMember]
		public int Hue4 {get; set;}
		[DataMember]
		public int Layer {get; set;}
		[DataMember]
		public bool Mir {get; set;}
		[DataMember]
		public int Rot {get; set;}
		[DataMember]
		public int Sat1 {get; set;}
		[DataMember]
		public int Sat2 {get; set;}
		[DataMember]
		public int Sat3 {get; set;}
		[DataMember]
		public int Sat4 {get; set;}
		[DataMember]
		public int ScaleX {get; set;}
		[DataMember]
		public int ScaleY {get; set;}
		[DataMember]
		public int Shear {get; set;}
		[DataMember]
		public int TranX {get; set;}
		[DataMember]
		public int TranY {get; set;}
		[DataMember]
		public int Var1 {get; set;}
		[DataMember]
		public int Var2 {get; set;}
		[DataMember]
		public int Var3 {get; set;}
		[DataMember]
		public int Var4 {get; set;}
	}
}
