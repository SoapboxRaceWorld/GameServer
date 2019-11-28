using System.Runtime.Serialization;
namespace Victory.Service.Objects
{
	[DataContract(Name = "ShortcutUsage", Namespace = "http://schemas.datacontract.org/2004/07/Victory.Service.Objects")]
	public class ShortcutUsage
	{
		[DataMember]
		public string shortCut {get; set;}
		[DataMember]
		public int timesUsed {get; set;}
	}
}
