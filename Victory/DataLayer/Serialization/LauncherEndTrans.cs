using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "LauncherEndTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class LauncherEndTrans
	{
		[DataMember]
		public System.String leaveReasonID {get; set;}
		[DataMember]
		public System.String patchTime {get; set;}
		[DataMember]
		public System.Int64 userID {get; set;}
	}
}
