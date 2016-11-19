(function () {

    "use strict"

    var carOrdersModule = angular.module("carOrdersModule", []);

    carOrdersModule.controller("CarOrdersController", function ($scope, $http) {

        $scope.addCarOrder = function () {

            var data = JSON.stringify({
                "carID": $scope.CarID,
                "userID": 1,
                "rentalStartDate": $scope.StartDate,
                "rentalFinishDate": $scope.FinishDate,
                "rentalActualDate": $scope.ActualDate
            });

            // State that the data is in JSON format:
            var headers = {
                headers: {
                    "Content-Type": "application/json"
                }
            };

            $http.post("/api/CarOrdersApi", data, headers)

            .success(function (response) {
                alert("Product has been successfully added.");
            })

            .error(function (response) {
                alert(
                    "Error:\n" +
                    "Message: " + response.Message + "\n" +
                    "Message Detail: " + response.MessageDetail);
            });

        };

        $scope.GetCarOrders = function () {
               
            // State that the data is in JSON format:
            var headers = {
                headers: {
                    "Content-Type": "application/json"
                }
            };

            $http.get("/api/CarOrderApi", headers)

            .success(function (response) {
                alert("Product has been successfully added.");
                $scope.carOrders = response;
            })

            .error(function (response) {
                alert("Error:\n" +
                    "Message: " + response.Message + "\n" +
                    "Message Detail: " + response.MessageDetail);
            });

        };
    });

})();

