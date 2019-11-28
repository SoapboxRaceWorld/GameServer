namespace Victory.TransferObjects.News
{
	public enum NewsArticleFilters
	{
		NEWSFILTERMASK_None = 0, 
		NEWSFILTERMASK_Me = 1, 
		NEWSFILTERMASK_Friends = 2, 
		NEWSFILTERMASK_System = 4, 
		NEWSFILTERMASK_Crew = 8, 
		NEWSFILTERMASK_All = 2147483647, 
		NEWSFILTERMASK_ITEM_COUNT = 6, 
	}
}
