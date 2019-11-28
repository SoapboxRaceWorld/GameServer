using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "BadgeInput", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class BadgeInput
	{
		[DataMember]
		public int BadgeDefinitionId {get; set;}
		[DataMember]
		public short SlotId {get; set;}
	}
}
