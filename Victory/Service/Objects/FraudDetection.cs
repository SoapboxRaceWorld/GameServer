using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "FraudDetection", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class FraudDetection
	{
		[DataMember]
		public int Checksum {get; set;}
		[DataMember]
		public int IntValue1 {get; set;}
		[DataMember]
		public int IntValue2 {get; set;}
		[DataMember]
		public int IntValue3 {get; set;}
		[DataMember]
		public int IntValue4 {get; set;}
		[DataMember]
		public bool IsEncrypted {get; set;}
		[DataMember]
		public string ModuleName {get; set;}
		[DataMember]
		public string ModulePath {get; set;}
		[DataMember]
		public string ModuleValue {get; set;}
		[DataMember]
		public string StringValue1 {get; set;}
		[DataMember]
		public string StringValue2 {get; set;}
	}
}
