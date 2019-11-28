using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "LauncherStartTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class LauncherStartTrans
	{
		[DataMember]
		public string autoLogin {get; set;}
		[DataMember]
		public string autoStart {get; set;}
		[DataMember]
		public string language {get; set;}
		[DataMember]
		public string languageCode {get; set;}
		[DataMember]
		public string region {get; set;}
		[DataMember]
		public string sku {get; set;}
		[DataMember]
		public long userID {get; set;}
	}
}
