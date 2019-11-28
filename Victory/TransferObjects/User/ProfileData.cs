using System.Runtime.Serialization;
namespace Victory.TransferObjects.User
{
	[DataContract(Name = "ProfileData", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User")]
	public class ProfileData
	{
		[DataMember]
		public System.Double Boost {get; set;}
		[DataMember]
		public System.Double Cash {get; set;}
		[DataMember]
		public System.Int32 IconIndex {get; set;}
		[DataMember]
		public System.Int32 Level {get; set;}
		[DataMember]
		public System.String Motto {get; set;}
		[DataMember]
		public System.String Name {get; set;}
		[DataMember]
		public System.Single PercentToLevel {get; set;}
		[DataMember]
		public System.Int64 PersonaId {get; set;}
		[DataMember]
		public System.Double Rating {get; set;}
		[DataMember]
		public System.Double Rep {get; set;}
		[DataMember]
		public System.Int32 RepAtCurrentLevel {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.TransferObjects.User.PersonaCCar> ccar {get; set;}
	}
}
