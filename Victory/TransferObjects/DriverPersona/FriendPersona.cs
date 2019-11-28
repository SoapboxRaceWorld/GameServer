using System.Runtime.Serialization;
namespace Victory.TransferObjects.DriverPersona
{
	[DataContract(Name = "FriendPersona", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona")]
	public class FriendPersona
	{
		[DataMember]
		public int iconIndex {get; set;}
		[DataMember]
		public int level {get; set;}
		[DataMember]
		public string name {get; set;}
		[DataMember]
		public string originalName {get; set;}
		[DataMember]
		public long personaId {get; set;}
		[DataMember]
		public int presence {get; set;}
		[DataMember]
		public int socialNetwork {get; set;}
		[DataMember]
		public long userId {get; set;}
	}
}
