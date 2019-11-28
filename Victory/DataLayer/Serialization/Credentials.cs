using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "Credentials", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class Credentials
	{
		[DataMember]
		public string Email {get; set;}
		[DataMember]
		public string Password {get; set;}
		[DataMember]
		public string Region {get; set;}
	}
}
