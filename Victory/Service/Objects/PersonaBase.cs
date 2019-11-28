using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "PersonaBase", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class PersonaBase
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.BadgePacket> Badges {get; set;}
		[DataMember]
		public int IconIndex {get; set;}
		[DataMember]
		public int Level {get; set;}
		[DataMember]
		public string Motto {get; set;}
		[DataMember]
		public string Name {get; set;}
		[DataMember]
		public long PersonaId {get; set;}
		[DataMember]
		public int Presence {get; set;}
		[DataMember]
		public int Score {get; set;}
		[DataMember]
		public long UserId {get; set;}
	}
}
