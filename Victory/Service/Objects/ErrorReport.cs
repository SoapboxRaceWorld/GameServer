using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "ErrorReport", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class ErrorReport
	{
		[DataMember]
		public System.Int32 errorCode {get; set;}
		[DataMember]
		public System.String errorDescription {get; set;}
	}
}
