namespace Victory.DataLayer.Serialization.Event
{
	public enum FinishReason
	{
		Unknown = 0, 
		Completed = 2, 
		Succeeded = 6, 
		DidNotFinish = 10, 
		CrossedFinish = 22, 
		KnockedOut = 42, 
		Totalled = 74, 
		EngineBlown = 138, 
		Busted = 266, 
		Evaded = 518, 
		ChallengeCompleted = 1030, 
		Disconnected = 2058, 
		FalseStart = 4106, 
		Aborted = 8202, 
		TimedOut = 16394, 
		TimeLimitExpired = 32774, 
		PauseDetected = 65546, 
		SpeedHacking = 131082, 
		CodePatchDetected = 262154, 
		BadVerifierResponse = 524298, 
	}
}
