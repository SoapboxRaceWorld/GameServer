using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "EngineInnerExceptionTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class EngineInnerExceptionTrans
	{
		[DataMember]
		public string Description {get; set;}
		[DataMember]
		public int ErrorCode {get; set;}
		[DataMember]
		public string Message {get; set;}
		[DataMember]
		public string StackTrace {get; set;}
	}
}
