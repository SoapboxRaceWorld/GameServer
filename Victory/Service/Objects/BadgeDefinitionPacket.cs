using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "BadgeDefinitionPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class BadgeDefinitionPacket
	{
		[DataMember]
		public System.String Background {get; set;}
		[DataMember]
		public System.Int32 BadgeDefinitionId {get; set;}
		[DataMember]
		public System.String Border {get; set;}
		[DataMember]
		public System.String Description {get; set;}
		[DataMember]
		public System.String Icon {get; set;}
		[DataMember]
		public System.String Name {get; set;}
	}
}
