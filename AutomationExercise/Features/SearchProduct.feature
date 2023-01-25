Feature: SearchProduct

Search Product api testleri

Scenario: Post to search product
* Request Method 'POST' olarak ayarlanır
* Request parameter değerine 'jean' değeri eklenir
* Response Status Code '200' olduğu görülür


Scenario: Post To search products without search_product paramater
* Request Method 'POST' olarak ayarlanır
* ProductList api çağrılır
* Response Status Code '200' olduğu görülür
* Response Content Response Code '400' olduğu görülür
* Response Content Response Message 'Bad request, search_product parameter is missing in POST request.' olduğu görülür
