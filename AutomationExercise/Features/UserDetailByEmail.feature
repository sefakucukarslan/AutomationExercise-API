Feature: UserDetailByEmail

Kullanıcı bilgileri görüntüleme

Scenario: GET user account detail by email
* Request Method 'GET' olarak ayarlanır
* Request parameter 'email' değerine 'sefa@gmail.com' değeri eklenir
* Get user account detail by email api çağrılır
* Response Status Code '200' olduğu görülür
* Dönen verinin dolu olduğu görülür
* Dönen veride email değerinin 'sefa@gmail.com' olduğu görülür