Feature: BrandList

Brand List Api Testleri

Scenario: Get All Brands List
* Request Method 'GET' olarak ayarlanır
* BrandList api çağrılır
* Response Status Code '200' olduğu görülür
* Response Data dolu olduğu görülür


Scenario: Put To All Brands List
* Request Method 'PUT' olarak ayarlanır
* BrandList api çağrılır
* Response Status Code '200' olduğu görülür
* Response Content Response Code '405' olduğu görülür
* Response Content Response Message 'This request method is not supported.' olduğu görülür