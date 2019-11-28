using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "FraudConfig", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class FraudConfig
	{
		[DataMember]
		public System.Int32 enabledBitField {get; set;}
		[DataMember]
		public System.Int32 gameFileFreq {get; set;}
		[DataMember]
		public System.Int32 moduleFreq {get; set;}
		[DataMember]
		public System.Int32 startUpFreq {get; set;}
		[DataMember]
		public System.Int64 userID {get; set;}
	}
}
