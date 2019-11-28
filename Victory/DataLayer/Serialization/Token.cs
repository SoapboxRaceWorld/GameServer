using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "Token", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class Token
	{
		[DataMember]
		public bool EualaAccepted {get; set;}
		[DataMember]
		public string Region {get; set;}
		[DataMember]
		public string Value {get; set;}
	}
}
