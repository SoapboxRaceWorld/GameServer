using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CategoryTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CategoryTrans
	{
		[DataMember]
		public int CatalogVersion {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.CategoryTrans> Categories {get; set;}
		[DataMember]
		public string DisplayName {get; set;}
		[DataMember]
		public int FilterType {get; set;}
		[DataMember]
		public string Icon {get; set;}
		[DataMember]
		public string Id {get; set;}
		[DataMember]
		public string LongDescription {get; set;}
		[DataMember]
		public string Name {get; set;}
		[DataMember]
		public int Priority {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.ProductTrans> Products {get; set;}
		[DataMember]
		public string ShortDescription {get; set;}
		[DataMember]
		public bool ShowInNavigationPane {get; set;}
		[DataMember]
		public bool ShowPromoPage {get; set;}
		[DataMember]
		public string WebIcon {get; set;}
	}
}
