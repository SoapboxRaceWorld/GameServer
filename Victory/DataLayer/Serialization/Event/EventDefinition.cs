using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Event
{
	[DataContract(Name = "EventDefinition", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Event")]
	public class EventDefinition
	{
		[DataMember]
		public System.Int32 CarClassHash {get; set;}
		[DataMember]
		public System.Int32 Coins {get; set;}
		[DataMember]
		public Victory.DataLayer.Serialization.Vector3 EngagePoint {get; set;}
		[DataMember]
		public System.Int32 EventId {get; set;}
		[DataMember]
		public System.Int32 EventLocalization {get; set;}
		[DataMember]
		public System.Int32 EventModeDescriptionLocalization {get; set;}
		[DataMember]
		public System.String EventModeIcon {get; set;}
		[DataMember]
		public System.Int32 EventModeId {get; set;}
		[DataMember]
		public System.Int32 EventModeLocalization {get; set;}
		[DataMember]
		public System.Boolean IsEnabled {get; set;}
		[DataMember]
		public System.Boolean IsLocked {get; set;}
		[DataMember]
		public System.Int32 Laps {get; set;}
		[DataMember]
		public System.Single Length {get; set;}
		[DataMember]
		public System.Int32 MaxClassRating {get; set;}
		[DataMember]
		public System.Int32 MaxEntrants {get; set;}
		[DataMember]
		public System.Int32 MaxLevel {get; set;}
		[DataMember]
		public System.Int32 MinClassRating {get; set;}
		[DataMember]
		public System.Int32 MinEntrants {get; set;}
		[DataMember]
		public System.Int32 MinLevel {get; set;}
		[DataMember]
		public System.Int32 RegionLocalization {get; set;}
		[DataMember]
		public System.Collections.Generic.List<System.Int32> RewardModes {get; set;}
		[DataMember]
		public System.Single TimeLimit {get; set;}
		[DataMember]
		public System.String TrackLayoutMap {get; set;}
		[DataMember]
		public System.Int32 TrackLocalization {get; set;}
	}
}
