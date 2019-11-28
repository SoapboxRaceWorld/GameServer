using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "PerformancePartTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class PerformancePartTrans
	{
		[DataMember]
		public System.Int32 PerformancePartAttribHash {get; set;}
	}
}
