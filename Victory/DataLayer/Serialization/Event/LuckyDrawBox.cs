using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "LuckyDrawBox", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class LuckyDrawBox
	{
		[DataMember]
		public bool IsValid {get; set;}
		[DataMember]
		public string LocalizationString {get; set;}
		[DataMember]
		public int LuckyDrawSetCategoryId {get; set;}
	}
}
