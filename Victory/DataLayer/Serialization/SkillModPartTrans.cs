using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "SkillModPartTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class SkillModPartTrans
	{
		[DataMember]
		public System.Boolean IsFixed {get; set;}
		[DataMember]
		public System.Int32 SkillModPartAttribHash {get; set;}
	}
}
