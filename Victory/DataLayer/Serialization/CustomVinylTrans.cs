using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CustomVinylTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CustomVinylTrans
	{
		[DataMember]
		public System.Int32 Hash {get; set;}
		[DataMember]
		public System.Int32 Hue1 {get; set;}
		[DataMember]
		public System.Int32 Hue2 {get; set;}
		[DataMember]
		public System.Int32 Hue3 {get; set;}
		[DataMember]
		public System.Int32 Hue4 {get; set;}
		[DataMember]
		public System.Int32 Layer {get; set;}
		[DataMember]
		public System.Boolean Mir {get; set;}
		[DataMember]
		public System.Int32 Rot {get; set;}
		[DataMember]
		public System.Int32 Sat1 {get; set;}
		[DataMember]
		public System.Int32 Sat2 {get; set;}
		[DataMember]
		public System.Int32 Sat3 {get; set;}
		[DataMember]
		public System.Int32 Sat4 {get; set;}
		[DataMember]
		public System.Int32 ScaleX {get; set;}
		[DataMember]
		public System.Int32 ScaleY {get; set;}
		[DataMember]
		public System.Int32 Shear {get; set;}
		[DataMember]
		public System.Int32 TranX {get; set;}
		[DataMember]
		public System.Int32 TranY {get; set;}
		[DataMember]
		public System.Int32 Var1 {get; set;}
		[DataMember]
		public System.Int32 Var2 {get; set;}
		[DataMember]
		public System.Int32 Var3 {get; set;}
		[DataMember]
		public System.Int32 Var4 {get; set;}
	}
}
