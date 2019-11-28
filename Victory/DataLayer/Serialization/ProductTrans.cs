using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "ProductTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class ProductTrans
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.ProductTrans> BundleItems {get; set;}
		[DataMember]
		public System.String CategoryId {get; set;}
		[DataMember]
		public System.String Currency {get; set;}
		[DataMember]
		public System.String Description {get; set;}
		[DataMember]
		public System.Int32 DurationMinute {get; set;}
		[DataMember]
		public System.Int32 Hash {get; set;}
		[DataMember]
		public System.String Icon {get; set;}
		[DataMember]
		public System.Int32 Level {get; set;}
		[DataMember]
		public System.String LongDescription {get; set;}
		[DataMember]
		public System.Double Price {get; set;}
		[DataMember]
		public System.Int32 Priority {get; set;}
		[DataMember]
		public System.String ProductId {get; set;}
		[DataMember]
		public System.String ProductTitle {get; set;}
		[DataMember]
		public System.String ProductType {get; set;}
		[DataMember]
		public System.String SecondaryIcon {get; set;}
		[DataMember]
		public System.Int32 UseCount {get; set;}
		[DataMember]
		public System.String VisualStyle {get; set;}
		[DataMember]
		public System.String WebIcon {get; set;}
		[DataMember]
		public System.String WebLocation {get; set;}
	}
}
