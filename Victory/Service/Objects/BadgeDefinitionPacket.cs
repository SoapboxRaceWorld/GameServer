using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "BadgeDefinitionPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class BadgeDefinitionPacket
	{
		[DataMember]
		public string Background {get; set;}
		[DataMember]
		public int BadgeDefinitionId {get; set;}
		[DataMember]
		public string Border {get; set;}
		[DataMember]
		public string Description {get; set;}
		[DataMember]
		public string Icon {get; set;}
		[DataMember]
		public string Name {get; set;}
	}
}
