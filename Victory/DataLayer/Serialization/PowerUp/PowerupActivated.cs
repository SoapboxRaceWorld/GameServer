using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.PowerUp
{
	[DataContract(Name = "PowerupActivated", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.PowerUp")]
	public class PowerupActivated
	{
		[DataMember]
		public System.Int32 Count {get; set;}
		[DataMember]
		public System.Int32 Id {get; set;}
		[DataMember]
		public System.Int64 PersonaId {get; set;}
		[DataMember]
		public System.Int64 TargetPersonaId {get; set;}
	}
}
