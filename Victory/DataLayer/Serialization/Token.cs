using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "Token", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class Token
	{
		[DataMember]
		public System.Boolean EualaAccepted {get; set;}
		[DataMember]
		public System.String Region {get; set;}
		[DataMember]
		public System.String Value {get; set;}
	}
}
