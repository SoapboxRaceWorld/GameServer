using System.Runtime.Serialization;
namespace Victory.Service.Objects.Event
{
	[DataContract(Name = "CarClass", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects.Event")]
	public class CarClass
	{
		[DataMember]
		public int CarClassHash {get; set;}
		[DataMember]
		public short MaxRating {get; set;}
		[DataMember]
		public short MinRating {get; set;}
	}
}
