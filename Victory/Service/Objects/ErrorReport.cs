using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "ErrorReport", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class ErrorReport
	{
		[DataMember]
		public int errorCode {get; set;}
		[DataMember]
		public string errorDescription {get; set;}
	}
}
