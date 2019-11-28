using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CategoryTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CategoryTrans
	{
		[DataMember]
		public System.Int32 CatalogVersion {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.CategoryTrans> Categories {get; set;}
		[DataMember]
		public System.String DisplayName {get; set;}
		[DataMember]
		public System.Int32 FilterType {get; set;}
		[DataMember]
		public System.String Icon {get; set;}
		[DataMember]
		public System.String Id {get; set;}
		[DataMember]
		public System.String LongDescription {get; set;}
		[DataMember]
		public System.String Name {get; set;}
		[DataMember]
		public System.Int32 Priority {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.ProductTrans> Products {get; set;}
		[DataMember]
		public System.String ShortDescription {get; set;}
		[DataMember]
		public System.Boolean ShowInNavigationPane {get; set;}
		[DataMember]
		public System.Boolean ShowPromoPage {get; set;}
		[DataMember]
		public System.String WebIcon {get; set;}
	}
}
