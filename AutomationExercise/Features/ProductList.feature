Feature: ProductList

Product List Api Testleri

Scenario: Get All Products List
	* Request Method 'GET' olarak ayarlanır
	* ProductList api çağrılır
	* Response Status Code '200' olduğu görülür
	* Response Data dolu olduğu görülür

Scenario: Post To All Products List
	* Request Method 'POST' olarak ayarlanır
	* ProductList api çağrılır
	* Response Status Code '200' olduğu görülür
	* Response Content Response Code '405' olduğu görülür
	* Response Content Response Message 'This request method is not supported.' olduğu görülür
