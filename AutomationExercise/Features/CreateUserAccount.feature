Feature: CreateUserAccount

Kullanici hesap kaydi

Scenario: Create/Register User Account
	* Request Method 'POST' olarak ayarlanır
	* Request parameter değerine '<name>,<email>,<password>,<title>,<birth_date>,<birth_month>,<birth_year>,<firstname>,<lastname>,<company>,<address1>,<address2>,<country>,<zipcode>,<state>,<city>,<mobile_number>' değeri eklenir
	* Create user account api çağrılır
	* Response Status Code '200' olduğu görülür
	* Response Content Response Code '201' olduğu görülür
	* Response Content Response Message 'User created!' olduğu görülür

Examples:
	| name      | email       | password | title | birth_date | birth_month | birth_year | firstname | lastname    | company   | address1 | address2 | country | zipcode | state     | city    | mobile_number |
	| sefarslan | s@gmail.com | 1234     | Mr.   | 10/02/1996 | 2           | 1996       | Sefa      | Kucukarslan | Intertech | Seker    | Kurtulus | Türkiye | 54100   | Adapazari | Sakarya | 7778889911    |