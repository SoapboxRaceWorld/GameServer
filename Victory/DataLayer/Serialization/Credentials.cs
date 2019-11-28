using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "Credentials", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class Credentials
	{
		[DataMember]
		public System.String Email {get; set;}
		[DataMember]
		public System.String Password {get; set;}
		[DataMember]
		public System.String Region {get; set;}
	}
}
