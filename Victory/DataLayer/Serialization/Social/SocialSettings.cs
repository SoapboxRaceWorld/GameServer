using System.Runtime.Serialization;
namespace Victory.DataLayer.Serialization.Social
{
	[DataContract(Name = "SocialSettings", Namespace = "http://schemas.datacontract.org/2004/07/Victory.DataLayer.Serialization.Social")]
	public class SocialSettings
	{
		[DataMember]
		public System.Boolean AppearOffline {get; set;}
		[DataMember]
		public System.Int32 DeclineGroupInvite {get; set;}
		[DataMember]
		public System.Boolean DeclineIncommingFriendRequests {get; set;}
		[DataMember]
		public System.Int32 DeclinePrivateInvite {get; set;}
		[DataMember]
		public System.Boolean HideOfflineFriends {get; set;}
		[DataMember]
		public System.Boolean ShowNewsOnSignIn {get; set;}
		[DataMember]
		public System.Boolean ShowOnlyPlayersInSameChatChannel {get; set;}
	}
}
