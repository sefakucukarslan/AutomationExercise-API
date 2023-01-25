Feature: VerifyLogin

Verify Login api testleri

Scenario: Verify Login with valid details
	* Request Method 'POST' olarak ayarlanır
	* Request parameter değerine 'sefa@gmail.com' ve '1234' değeri eklenir
	* Verify login api çağrılır
	* Response Status Code '200' olduğu görülür
	* Response Content Response Code '200' olduğu görülür
	* Response Content Response Message 'User exists!' olduğu görülür

Scenario: Verify Login without email parameter
	* Request Method 'POST' olarak ayarlanır
	* Request parameter değerine '' ve '1234' değeri eklenir
	* Verify login api çağrılır
	* Response Status Code '200' olduğu görülür
	* Response Content Response Code '400' olduğu görülür
	* Response Content Response Message 'Bad request, email or password parameter is missing in POST request.' olduğu görülür

Scenario: Delete to verify login
	* Request Method 'DELETE' olarak ayarlanır
	* Verify login api çağrılır
	* Response Status Code '200' olduğu görülür
	* Response Content Response Code '405' olduğu görülür
	* Response Content Response Message 'This request method is not supported.' olduğu görülür

Scenario: Verify Login with invalid details
	* Request Method 'POST' olarak ayarlanır
	* Request parameter değerine 'a@gmail.com' ve '1' değeri eklenir
	* Verify login api çağrılır
	* Response Status Code '200' olduğu görülür
	* Response Content Response Code '404' olduğu görülür
	* Response Content Response Message 'User not found!' olduğu görülür
