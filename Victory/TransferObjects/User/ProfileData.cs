using System.Runtime.Serialization;
namespace Victory.TransferObjects.User
{
	[DataContract(Name = "ProfileData", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User")]
	public class ProfileData
	{
		[DataMember]
		public double Boost {get; set;}
		[DataMember]
		public double Cash {get; set;}
		[DataMember]
		public int IconIndex {get; set;}
		[DataMember]
		public int Level {get; set;}
		[DataMember]
		public string Motto {get; set;}
		[DataMember]
		public string Name {get; set;}
		[DataMember]
		public float PercentToLevel {get; set;}
		[DataMember]
		public long PersonaId {get; set;}
		[DataMember]
		public double Rating {get; set;}
		[DataMember]
		public double Rep {get; set;}
		[DataMember]
		public int RepAtCurrentLevel {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.TransferObjects.User.PersonaCCar> ccar {get; set;}
	}
}
