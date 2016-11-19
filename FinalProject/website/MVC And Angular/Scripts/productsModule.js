(function () {

    "use strict"

    // Creating the products module: 
    var productsModule = angular.module("productsModule", []);

    // Creating the products controller: 
    productsModule.controller("ProductsController", function ($scope, $http) {

        $scope.addProduct = function () {

            // The data we are going to send:
            var data = JSON.stringify({
                "ProductName": $scope.ProductName,
                "UnitPrice": $scope.UnitPrice
            });

            // State that the data is in JSON format:
            var headers = {
                headers: {
                    "Content-Type": "application/json"
                }
            };

            $http.post("/api/ProductsApi", data, headers)

            .success(function (response) {
                alert("Product has been successfully added.");
            })

            .error(function (response) {
                alert("Error:\n" +
                    "Message: " + response.Message + "\n" +
                    "Message Detail: " + response.MessageDetail);
            });

        };

    });

})();

