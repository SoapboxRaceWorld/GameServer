using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "HeartBeat", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class HeartBeat
	{
		[DataMember]
		public int MetagameFlags {get; set;}
		[DataMember]
		public int enabledBitField {get; set;}
	}
}
