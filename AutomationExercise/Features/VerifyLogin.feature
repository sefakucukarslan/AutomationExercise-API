Feature: VerifyLogin

Verify Login api testleri

Scenario: Verify Login with valid details
	* Request Method 'POST' olarak ayarlanır
	* Request parameter değerine 'email' ve 'password' değeri eklenir
	* Verify login api çağrılır
	* Response Status Code '200' olduğu görülür
	* Response Content Response Code '200' olduğu görülür
	* Response Content Response Message 'User exists!' olduğu görülür
