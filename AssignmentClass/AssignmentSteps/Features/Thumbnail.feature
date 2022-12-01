Feature: Thumbnail

@ThumbnailForParticularItemSearch
Scenario: Verify the thumbnail of image if that item is searched
		 verifying that if i search a particular item then i able to see that item

	Given navigated on amazon home page
	When i enter the product name
	And i click on the search icon
	Then along with item thumbnail other items thumbnail display

@ThumbnailForRelatedItemSearch
Scenario: Verify the thumbnail of image if related item is searched
		 verifying that if i search a related item then i able to see that item 

	Given navigated on amazon home page
	When i enter the related product name
	And i click on the search icon
	Then along with item thumbnail other items thumbnail display

