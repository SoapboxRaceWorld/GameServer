using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "Cdn", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class Cdn
	{
		[DataMember]
		public string game {get; set;}
		[DataMember]
		public string launcher {get; set;}
	}
}
