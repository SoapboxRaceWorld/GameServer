using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "SkillModPartTrans", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class SkillModPartTrans
	{
		[DataMember]
		public bool IsFixed {get; set;}
		[DataMember]
		public int SkillModPartAttribHash {get; set;}
	}
}
