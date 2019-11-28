using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "BadgeInput", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class BadgeInput
	{
		[DataMember]
		public System.Int32 BadgeDefinitionId {get; set;}
		[DataMember]
		public System.Int16 SlotId {get; set;}
	}
}
