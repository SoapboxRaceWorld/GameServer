using System.Runtime.Serialization;
namespace Victory.TransferObjects.User
{
	[DataContract(Name = "User", Namespace = "http://schemas.datacontract.org/2004/07/Victory.TransferObjects.User")]
	public class User
	{
		[DataMember]
		public System.String address1 {get; set;}
		[DataMember]
		public System.String address2 {get; set;}
		[DataMember]
		public System.String country {get; set;}
		[DataMember]
		public System.String dateCreated {get; set;}
		[DataMember]
		public System.String dob {get; set;}
		[DataMember]
		public System.String email {get; set;}
		[DataMember]
		public System.String emailStatus {get; set;}
		[DataMember]
		public System.String firstName {get; set;}
		[DataMember]
		public System.Boolean fullGameAccess {get; set;}
		[DataMember]
		public System.String gender {get; set;}
		[DataMember]
		public System.String idDigits {get; set;}
		[DataMember]
		public System.Boolean isComplete {get; set;}
		[DataMember]
		public System.String landlinePhone {get; set;}
		[DataMember]
		public System.String language {get; set;}
		[DataMember]
		public System.String lastAuthDate {get; set;}
		[DataMember]
		public System.String lastName {get; set;}
		[DataMember]
		public System.String mobile {get; set;}
		[DataMember]
		public System.String nickname {get; set;}
		[DataMember]
		public System.String postalCode {get; set;}
		[DataMember]
		public System.String realName {get; set;}
		[DataMember]
		public System.String reasonCode {get; set;}
		[DataMember]
		public System.Int64 remoteUserId {get; set;}
		[DataMember]
		public System.String securityToken {get; set;}
		[DataMember]
		public System.String starterPackEntitlementTag {get; set;}
		[DataMember]
		public System.String status {get; set;}
		[DataMember]
		public System.Boolean subscribeMsg {get; set;}
		[DataMember]
		public System.String tosVersion {get; set;}
		[DataMember]
		public System.Int64 userId {get; set;}
		[DataMember]
		public System.String username {get; set;}
	}
}
