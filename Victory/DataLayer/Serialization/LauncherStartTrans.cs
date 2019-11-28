using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "LauncherStartTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class LauncherStartTrans
	{
		[DataMember]
		public System.String autoLogin {get; set;}
		[DataMember]
		public System.String autoStart {get; set;}
		[DataMember]
		public System.String language {get; set;}
		[DataMember]
		public System.String languageCode {get; set;}
		[DataMember]
		public System.String region {get; set;}
		[DataMember]
		public System.String sku {get; set;}
		[DataMember]
		public System.Int64 userID {get; set;}
	}
}
