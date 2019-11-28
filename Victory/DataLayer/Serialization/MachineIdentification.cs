using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "MachineIdentification", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class MachineIdentification
	{
		[DataMember]
		public System.UInt32 cpuID {get; set;}
		[DataMember]
		public System.String diskSerialNumber {get; set;}
		[DataMember]
		public System.UInt32 gpuID {get; set;}
		[DataMember]
		public System.Int64 mac {get; set;}
		[DataMember]
		public System.String machineName {get; set;}
		[DataMember]
		public System.Int64 userID {get; set;}
		[DataMember]
		public System.String volumeName {get; set;}
		[DataMember]
		public System.UInt32 volumeSerialNumber {get; set;}
	}
}
