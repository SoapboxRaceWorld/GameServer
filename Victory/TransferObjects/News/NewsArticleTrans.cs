using System.Runtime.Serialization;
namespace Victory.TransferObjects.News
{
	[DataContract(Name = "NewsArticleTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.News")]
	public class NewsArticleTrans
	{
		[DataMember]
		public System.DateTime ExpiryTime {get; set;}
		[DataMember]
		public System.Int32 Filters {get; set;}
		[DataMember]
		public System.Int32 IconType {get; set;}
		[DataMember]
		public System.String LongText_HALId {get; set;}
		[DataMember]
		public System.Int64 NewsId {get; set;}
		[DataMember]
		public System.String Parameters {get; set;}
		[DataMember]
		public System.Int64 PersonaId {get; set;}
		[DataMember]
		public System.String ShortText_HALId {get; set;}
		[DataMember]
		public System.Int32 Sticky {get; set;}
		[DataMember]
		public System.Int64 Timestamp {get; set;}
		[DataMember]
		public System.Int32 Type {get; set;}
	}
}
