using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "FraudConfig", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class FraudConfig
	{
		[DataMember]
		public int enabledBitField {get; set;}
		[DataMember]
		public int gameFileFreq {get; set;}
		[DataMember]
		public int moduleFreq {get; set;}
		[DataMember]
		public int startUpFreq {get; set;}
		[DataMember]
		public long userID {get; set;}
	}
}
