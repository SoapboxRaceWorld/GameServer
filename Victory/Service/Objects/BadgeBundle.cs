using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "BadgeBundle", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class BadgeBundle
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.BadgeInput> Badges {get; set;}
	}
}
