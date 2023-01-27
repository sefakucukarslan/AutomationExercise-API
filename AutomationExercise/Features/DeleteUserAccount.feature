Feature: DeleteUserAccount

Kullanıcı hesap silme


Scenario: DELETE METHOD To Delete User Account
	* Request Method 'DELETE' olarak ayarlanır
	* Request parameter değerine 'sefa@gmail.com' ve '1234' değeri eklenir
	* Delete user account api çağrılır
	* Response Status Code '200' olduğu görülür
	* Response Content Response Code '200' olduğu görülür
	* Response Content Response Message 'Account deleted!' olduğu görülür