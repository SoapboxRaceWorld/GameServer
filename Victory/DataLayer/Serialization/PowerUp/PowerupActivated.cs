using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.PowerUp
{
	[DataContract(Name = "PowerupActivated", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.PowerUp")]
	public class PowerupActivated
	{
		[DataMember]
		public int Count {get; set;}
		[DataMember]
		public int Id {get; set;}
		[DataMember]
		public long PersonaId {get; set;}
		[DataMember]
		public long TargetPersonaId {get; set;}
	}
}
