using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "ShardInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class ShardInfo
	{
		[DataMember]
		public int RegionId {get; set;}
		[DataMember]
		public string RegionName {get; set;}
		[DataMember]
		public string ShardName {get; set;}
		[DataMember]
		public string Url {get; set;}
	}
}
