using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "CarSlotInfoTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class CarSlotInfoTrans
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.OwnedCarTrans> CarsOwnedByPersona {get; set;}
		[DataMember]
		public int DefaultOwnedCarIndex {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.DataLayer.Serialization.ProductTrans> ObtainableSlots {get; set;}
		[DataMember]
		public int OwnedCarSlotsCount {get; set;}
	}
}
