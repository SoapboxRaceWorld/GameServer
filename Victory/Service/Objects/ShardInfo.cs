using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "ShardInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class ShardInfo
	{
		[DataMember]
		public System.Int32 RegionId {get; set;}
		[DataMember]
		public System.String RegionName {get; set;}
		[DataMember]
		public System.String ShardName {get; set;}
		[DataMember]
		public System.String Url {get; set;}
	}
}
