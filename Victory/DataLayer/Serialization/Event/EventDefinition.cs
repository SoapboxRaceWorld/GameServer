using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "EventDefinition", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class EventDefinition
	{
		[DataMember]
		public int CarClassHash {get; set;}
		[DataMember]
		public int Coins {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.Vector3 EngagePoint {get; set;}
		[DataMember]
		public int EventId {get; set;}
		[DataMember]
		public int EventLocalization {get; set;}
		[DataMember]
		public int EventModeDescriptionLocalization {get; set;}
		[DataMember]
		public string EventModeIcon {get; set;}
		[DataMember]
		public int EventModeId {get; set;}
		[DataMember]
		public int EventModeLocalization {get; set;}
		[DataMember]
		public bool IsEnabled {get; set;}
		[DataMember]
		public bool IsLocked {get; set;}
		[DataMember]
		public int Laps {get; set;}
		[DataMember]
		public float Length {get; set;}
		[DataMember]
		public int MaxClassRating {get; set;}
		[DataMember]
		public int MaxEntrants {get; set;}
		[DataMember]
		public int MaxLevel {get; set;}
		[DataMember]
		public int MinClassRating {get; set;}
		[DataMember]
		public int MinEntrants {get; set;}
		[DataMember]
		public int MinLevel {get; set;}
		[DataMember]
		public int RegionLocalization {get; set;}
		[DataMember]
		public System.Collections.Generic.List<int> RewardModes {get; set;}
		[DataMember]
		public float TimeLimit {get; set;}
		[DataMember]
		public string TrackLayoutMap {get; set;}
		[DataMember]
		public int TrackLocalization {get; set;}
	}
}
