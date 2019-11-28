using System.Runtime.Serialization;
namespace Victory.TransferObjects.DriverPersona
{
	[DataContract(Name = "FriendPersona", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.DriverPersona")]
	public class FriendPersona
	{
		[DataMember]
		public System.Int32 iconIndex {get; set;}
		[DataMember]
		public System.Int32 level {get; set;}
		[DataMember]
		public System.String name {get; set;}
		[DataMember]
		public System.String originalName {get; set;}
		[DataMember]
		public System.Int64 personaId {get; set;}
		[DataMember]
		public System.Int32 presence {get; set;}
		[DataMember]
		public System.Int32 socialNetwork {get; set;}
		[DataMember]
		public System.Int64 userId {get; set;}
	}
}
