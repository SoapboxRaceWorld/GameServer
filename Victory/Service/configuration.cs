using System.Runtime.Serialization;
namespace Victory.Service
{
	[DataContract(Name = "configuration", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service")]
	public class configuration
	{
		[DataMember]
		public System.String gameserver {get; set;}
		[DataMember]
		public System.String webserver {get; set;}
		[DataMember]
		public System.Collections.Generic.List<Victory.Service.region> regions {get; set;}
		[DataMember]
		public Victory.Service.Cdn cdn {get; set;}
		[DataMember]
		public Victory.Service.TermsOfService termsofservice {get; set;}
	}
}
