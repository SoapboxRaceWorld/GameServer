using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "HardwareInfo", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class HardwareInfo
	{
		[DataMember]
		public System.UInt32 availableMem {get; set;}
		[DataMember]
		public System.String cpuBrand {get; set;}
		[DataMember]
		public System.String cpuid0 {get; set;}
		[DataMember]
		public System.UInt32 cpuid1_0 {get; set;}
		[DataMember]
		public System.UInt32 cpuid1_1 {get; set;}
		[DataMember]
		public System.UInt32 cpuid1_2 {get; set;}
		[DataMember]
		public System.UInt32 cpuid1_3 {get; set;}
		[DataMember]
		public System.UInt32 deviceID {get; set;}
		[DataMember]
		public System.UInt32 excpuid1_0 {get; set;}
		[DataMember]
		public System.UInt32 excpuid1_1 {get; set;}
		[DataMember]
		public System.UInt32 excpuid1_2 {get; set;}
		[DataMember]
		public System.UInt32 excpuid1_3 {get; set;}
		[DataMember]
		public System.String gpuDescription {get; set;}
		[DataMember]
		public System.UInt32 gpuDriverBuild {get; set;}
		[DataMember]
		public System.UInt32 gpuDriverSubversion {get; set;}
		[DataMember]
		public System.UInt32 gpuDriverVersion {get; set;}
		[DataMember]
		public System.UInt32 gpuMemory {get; set;}
		[DataMember]
		public System.UInt32 gpuProduct {get; set;}
		[DataMember]
		public System.UInt32 osBuildNumber {get; set;}
		[DataMember]
		public System.UInt32 osMajorVersion {get; set;}
		[DataMember]
		public System.UInt32 osMinorVersion {get; set;}
		[DataMember]
		public System.UInt32 physicalCores {get; set;}
		[DataMember]
		public System.UInt32 platformID {get; set;}
		[DataMember]
		public System.UInt32 processAffinityMask {get; set;}
		[DataMember]
		public System.String servicePack {get; set;}
		[DataMember]
		public System.UInt32 systemAffinityMask {get; set;}
		[DataMember]
		public System.UInt32 totalMemory {get; set;}
		[DataMember]
		public System.Int64 userID {get; set;}
		[DataMember]
		public System.UInt32 vendorID {get; set;}
	}
}
