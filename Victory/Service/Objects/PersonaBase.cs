using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "PersonaBase", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class PersonaBase
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.BadgePacket> Badges {get; set;}
		[DataMember]
		public System.Int32 IconIndex {get; set;}
		[DataMember]
		public System.Int32 Level {get; set;}
		[DataMember]
		public System.String Motto {get; set;}
		[DataMember]
		public System.String Name {get; set;}
		[DataMember]
		public System.Int64 PersonaId {get; set;}
		[DataMember]
		public System.Int32 Presence {get; set;}
		[DataMember]
		public System.Int32 Score {get; set;}
		[DataMember]
		public System.Int64 UserId {get; set;}
	}
}
