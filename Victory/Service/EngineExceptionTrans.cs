using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "EngineExceptionTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class EngineExceptionTrans
	{
		[DataMember]
		public System.String Description {get; set;}
		[DataMember]
		public System.Int32 ErrorCode {get; set;}
		[DataMember]
		public Victory.Service.EngineInnerExceptionTrans InnerException {get; set;}
		[DataMember]
		public System.String Message {get; set;}
		[DataMember]
		public System.String StackTrace {get; set;}
	}
}
