using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization
{
	[DataContract(Name = "User_Settings", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization")]
	public class User_Settings
	{
		[DataMember]
		public System.Int32 CarCacheAgeLimit {get; set;}
		[DataMember]
		public System.Boolean IsRaceNowEnabled {get; set;}
		[DataMember]
		public System.Int32 MaxCarCacheSize {get; set;}
		[DataMember]
		public System.Int32 MinRaceNowLevel {get; set;}
		[DataMember]
		public System.Boolean VoipAvailable {get; set;}
		[DataMember]
		public System.Collections.Generic.List<System.String> activatedHolidaySceneryGroups {get; set;}
		[DataMember]
		public System.Collections.Generic.List<System.Int64> activeHolidayIds {get; set;}
		[DataMember]
		public System.Collections.Generic.List<System.String> disactivatedHolidaySceneryGroups {get; set;}
		[DataMember]
		public System.Boolean firstTimeLogin {get; set;}
		[DataMember]
		public System.Int32 maxLevel {get; set;}
		[DataMember]
		public System.Boolean starterPackApplied {get; set;}
		[DataMember]
		public System.Int64 userId {get; set;}
	}
}
