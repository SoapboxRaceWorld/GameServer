using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "Vector3", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class Vector3
	{
		[DataMember]
		public float X {get; set;}
		[DataMember]
		public float Y {get; set;}
		[DataMember]
		public float Z {get; set;}
	}
}
