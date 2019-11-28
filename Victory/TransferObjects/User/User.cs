using System.Runtime.Serialization;
namespace Victory.TransferObjects.User
{
	[DataContract(Name = "User", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User")]
	public class User
	{
		[DataMember]
		public string address1 {get; set;}
		[DataMember]
		public string address2 {get; set;}
		[DataMember]
		public string country {get; set;}
		[DataMember]
		public string dateCreated {get; set;}
		[DataMember]
		public string dob {get; set;}
		[DataMember]
		public string email {get; set;}
		[DataMember]
		public string emailStatus {get; set;}
		[DataMember]
		public string firstName {get; set;}
		[DataMember]
		public bool fullGameAccess {get; set;}
		[DataMember]
		public string gender {get; set;}
		[DataMember]
		public string idDigits {get; set;}
		[DataMember]
		public bool isComplete {get; set;}
		[DataMember]
		public string landlinePhone {get; set;}
		[DataMember]
		public string language {get; set;}
		[DataMember]
		public string lastAuthDate {get; set;}
		[DataMember]
		public string lastName {get; set;}
		[DataMember]
		public string mobile {get; set;}
		[DataMember]
		public string nickname {get; set;}
		[DataMember]
		public string postalCode {get; set;}
		[DataMember]
		public string realName {get; set;}
		[DataMember]
		public string reasonCode {get; set;}
		[DataMember]
		public long remoteUserId {get; set;}
		[DataMember]
		public string securityToken {get; set;}
		[DataMember]
		public string starterPackEntitlementTag {get; set;}
		[DataMember]
		public string status {get; set;}
		[DataMember]
		public bool subscribeMsg {get; set;}
		[DataMember]
		public string tosVersion {get; set;}
		[DataMember]
		public long userId {get; set;}
		[DataMember]
		public string username {get; set;}
	}
}
