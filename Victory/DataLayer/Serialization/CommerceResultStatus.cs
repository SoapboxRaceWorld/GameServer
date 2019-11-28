namespace Victory.DataLayer.Serialization
{
	public enum CommerceResultStatus
	{
		Success = 0, 
		Fail_InvalidBasket = 100, 
		Fail_InsufficientFunds = 101, 
		Fail_InsufficientCarSlots = 102, 
		Fail_MaxStackOrRentalLimit = 103, 
		Fail_InvalidPerformanceUpgrade = 104, 
		Fail_ItemNotAvailableStandalone = 105, 
		Fail_PersonaNotRightLevel = 106, 
		Fail_LockedProductNotAccessibleToThisUser = 107, 
		Fail_BoostTransactionsAreDisabled = 108, 
		Fail_InsufficientPerformancePartInventory = 109, 
		Fail_MaxAllowedPurchasesForThisProduct = 110, 
	}
}
