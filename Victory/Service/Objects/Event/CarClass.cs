using System.Runtime.Serialization;
namespace Victory.Service.Objects.Event
{
	[DataContract(Name = "CarClass", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects.Event")]
	public class CarClass
	{
		[DataMember]
		public System.Int32 CarClassHash {get; set;}
		[DataMember]
		public System.Int16 MaxRating {get; set;}
		[DataMember]
		public System.Int16 MinRating {get; set;}
	}
}
