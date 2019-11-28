using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "TermsOfService", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class TermsOfService
	{
		[DataMember]
		public System.String en {get; set;}
		[DataMember]
		public System.String de {get; set;}
		[DataMember]
		public System.String es {get; set;}
		[DataMember]
		public System.String fr {get; set;}
		[DataMember]
		public System.String pl {get; set;}
		[DataMember]
		public System.String pt {get; set;}
		[DataMember]
		public System.String ru {get; set;}
		[DataMember]
		public System.String th {get; set;}
		[DataMember]
		public System.String tr {get; set;}
		[DataMember]
		public System.String zh {get; set;}
		[DataMember]
		public System.String zh_chs {get; set;}
	}
}
