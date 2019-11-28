using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "Cdn", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class Cdn
	{
		[DataMember]
		public System.String game {get; set;}
		[DataMember]
		public System.String launcher {get; set;}
	}
}
