using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "TermsOfService", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class TermsOfService
	{
		[DataMember]
		public string en {get; set;}
		[DataMember]
		public string de {get; set;}
		[DataMember]
		public string es {get; set;}
		[DataMember]
		public string fr {get; set;}
		[DataMember]
		public string pl {get; set;}
		[DataMember]
		public string pt {get; set;}
		[DataMember]
		public string ru {get; set;}
		[DataMember]
		public string th {get; set;}
		[DataMember]
		public string tr {get; set;}
		[DataMember]
		public string zh {get; set;}
		[DataMember]
		public string zh_chs {get; set;}
	}
}
