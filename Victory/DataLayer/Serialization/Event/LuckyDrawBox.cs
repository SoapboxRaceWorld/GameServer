using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "LuckyDrawBox", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class LuckyDrawBox
	{
		[DataMember]
		public System.Boolean IsValid {get; set;}
		[DataMember]
		public System.String LocalizationString {get; set;}
		[DataMember]
		public System.Int32 LuckyDrawSetCategoryId {get; set;}
	}
}
