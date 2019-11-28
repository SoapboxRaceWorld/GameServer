using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "FraudDetection", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class FraudDetection
	{
		[DataMember]
		public System.Int32 Checksum {get; set;}
		[DataMember]
		public System.Int32 IntValue1 {get; set;}
		[DataMember]
		public System.Int32 IntValue2 {get; set;}
		[DataMember]
		public System.Int32 IntValue3 {get; set;}
		[DataMember]
		public System.Int32 IntValue4 {get; set;}
		[DataMember]
		public System.Boolean IsEncrypted {get; set;}
		[DataMember]
		public System.String ModuleName {get; set;}
		[DataMember]
		public System.String ModulePath {get; set;}
		[DataMember]
		public System.String ModuleValue {get; set;}
		[DataMember]
		public System.String StringValue1 {get; set;}
		[DataMember]
		public System.String StringValue2 {get; set;}
	}
}
