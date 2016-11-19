(function () {

    "use strict"
    var suppliersModule = angular.module("suppliersModule", []);

    suppliersModule.controller("SuppliersController", function($scope, $http){

        $scope.addsupplier = function(){

            var data = JSON.stringify({
                "CompanyName":$scope.CompanyName,
                "ContactName": $scope.ContactName,
                "Phone": $scope.Phone,
                "Fax": $scope.Fax

            });

            var headers = {
                headers: {
                    "Content-Type": "application/json"
                }
            };
            $http.post("/api/SuppliersApi", data, headers)

            .success(function(responce){
                alert("supplier was added.");
            })

            .error(function(response){
                alert(
                "Error:\n" +
                "Message: " + response.Message + "\n" + 
                "Message Detailes: " + response.MessageDetails);
            });
        };
    });
})();