using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "MachineIdentification", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class MachineIdentification
	{
		[DataMember]
		public uint cpuID {get; set;}
		[DataMember]
		public string diskSerialNumber {get; set;}
		[DataMember]
		public uint gpuID {get; set;}
		[DataMember]
		public long mac {get; set;}
		[DataMember]
		public string machineName {get; set;}
		[DataMember]
		public long userID {get; set;}
		[DataMember]
		public string volumeName {get; set;}
		[DataMember]
		public uint volumeSerialNumber {get; set;}
	}
}
