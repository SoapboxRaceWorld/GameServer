using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "Report", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class Report
	{
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.ChatTranscript> chatTranscripts {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.ErrorReport> errorReport {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.FraudDetection> fraudDetectionReport {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.Objects.ShortcutUsage> shortcutUsage {get; set;}
	}
}
