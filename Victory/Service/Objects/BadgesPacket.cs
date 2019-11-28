using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "BadgesPacket", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class BadgesPacket
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.BadgePacket> Badges {get; set;}
	}
}
