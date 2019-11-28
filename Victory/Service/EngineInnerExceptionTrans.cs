using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "EngineInnerExceptionTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class EngineInnerExceptionTrans
	{
		[DataMember]
		public System.String Description {get; set;}
		[DataMember]
		public System.Int32 ErrorCode {get; set;}
		[DataMember]
		public System.String Message {get; set;}
		[DataMember]
		public System.String StackTrace {get; set;}
	}
}
