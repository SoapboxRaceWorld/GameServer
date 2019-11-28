using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "LauncherEndTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class LauncherEndTrans
	{
		[DataMember]
		public string leaveReasonID {get; set;}
		[DataMember]
		public string patchTime {get; set;}
		[DataMember]
		public long userID {get; set;}
	}
}
