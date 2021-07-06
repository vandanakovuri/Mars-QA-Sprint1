Feature: Mars
	Add and view the profile details in the Mars application
	@Regression
Scenario: Test01 - Register to application
	Given Click on the Join button
	And Enter First name
	And Enter Last name
	And Enter Email Address
	And Enter Password
	And Enter Confirm Password
	And Tick the checkbox for I agree to the terms and conditions
    When Click on the Join button
	Then Registerded Successful

   @Regression
Scenario: Test02 - Sign In to application
	Given Launch Url
	And Click on the Sign In button
	And   valid Email Address and Password
    When  Click on the Login button
	Then  Login Successful  

   @Regression
Scenario: Test03 - Availability Option
	Given Click on the Availability Option
	When Select any suitable option from drop down
	Then Informative message displays as "Availability updated" on the screen

   @Regression
Scenario: Test04 - Hours Option
	Given Click on the Hours Option
	When Select any suitable option from drop down
	Then Informative message displays as "Availability updated" on the screen

	
	@Regression
Scenario: Test05 - Earn Target Option
	Given Click on the Earn Target Option
	When Select any suitable option from drop down
	Then Informative message displays as "Availability updated" on the screen

	@Regression
Scenario: Test06 - Add Description
	Given Click on Description edit icon
	When Enter the details and see the Characters remaining is updated
	And Click on the Save button
	Then Informative message displays as "Description has been saved successfully" on the screen

	@Regression
Scenario: Test09 - Add Education
	Given Click on Add New button under Education tab
	When Enter College/University Name in text box
	And Select Country of College/University from dropdown
	And Select Title from dropdown
	And Enter Degree 
	And Select Year of graduation
	And Click on Add button
	Then A newrecord displays with given values and Edit and Delete icons

	
	


	     

