using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "HardwareInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class HardwareInfo
	{
		[DataMember]
		public uint availableMem {get; set;}
		[DataMember]
		public string cpuBrand {get; set;}
		[DataMember]
		public string cpuid0 {get; set;}
		[DataMember]
		public uint cpuid1_0 {get; set;}
		[DataMember]
		public uint cpuid1_1 {get; set;}
		[DataMember]
		public uint cpuid1_2 {get; set;}
		[DataMember]
		public uint cpuid1_3 {get; set;}
		[DataMember]
		public uint deviceID {get; set;}
		[DataMember]
		public uint excpuid1_0 {get; set;}
		[DataMember]
		public uint excpuid1_1 {get; set;}
		[DataMember]
		public uint excpuid1_2 {get; set;}
		[DataMember]
		public uint excpuid1_3 {get; set;}
		[DataMember]
		public string gpuDescription {get; set;}
		[DataMember]
		public uint gpuDriverBuild {get; set;}
		[DataMember]
		public uint gpuDriverSubversion {get; set;}
		[DataMember]
		public uint gpuDriverVersion {get; set;}
		[DataMember]
		public uint gpuMemory {get; set;}
		[DataMember]
		public uint gpuProduct {get; set;}
		[DataMember]
		public uint osBuildNumber {get; set;}
		[DataMember]
		public uint osMajorVersion {get; set;}
		[DataMember]
		public uint osMinorVersion {get; set;}
		[DataMember]
		public uint physicalCores {get; set;}
		[DataMember]
		public uint platformID {get; set;}
		[DataMember]
		public uint processAffinityMask {get; set;}
		[DataMember]
		public string servicePack {get; set;}
		[DataMember]
		public uint systemAffinityMask {get; set;}
		[DataMember]
		public uint totalMemory {get; set;}
		[DataMember]
		public long userID {get; set;}
		[DataMember]
		public uint vendorID {get; set;}
	}
}
