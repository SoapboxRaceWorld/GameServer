using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "StatNameList", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class StatNameList
	{
		[DataMember]
		public System.Collections.Generic.List<string> Stats {get; set;}
	}
}
