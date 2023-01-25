Feature: UpdateUserAccount

Kullanici guncelleme 

Scenario: Update user account
	* Request Method 'PUT' olarak ayarlanır
	* Request parameter değerine '<name>,<email>,<password>,<title>,<birth_date>,<birth_month>,<birth_year>,<firstname>,<lastname>,<company>,<address1>,<address2>,<country>,<zipcode>,<state>,<city>,<mobile_number>' değeri eklenir
	* Update user account api çağrılır
	* Response Status Code '200' olduğu görülür
	* Response Content Response Code '200' olduğu görülür
	* Response Content Response Message 'User updated!' olduğu görülür

Examples:
	| name          | email       | password | title | birth_date | birth_month | birth_year | firstname | lastname | company   | address1 | address2 | country | zipcode | state     | city    | mobile_number |
	| cakirsuleyman | s@gmail.com | 1234     | Mr.   | 10/02/1996 | 2           | 1996       | Suleyman  | Cakir    | Intertech | Seker    | Kurtulus | Türkiye | 54100   | Adapazari | Sakarya | 7778889911    |

