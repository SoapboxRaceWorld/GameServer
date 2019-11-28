using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "region", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class region
	{
		[DataMember]
		public string name {get; set;}
	}
}
