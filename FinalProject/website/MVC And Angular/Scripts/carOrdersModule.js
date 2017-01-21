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

            $http.post("/api/CarOrdersApi/", data, headers)

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

        $scope.GetAllRentals = function () {
            alert("Start");
            // State that the data is in JSON format:
            var headers = {
                headers: {
                    "Content-Type": "application/json"
                }
            };
            alert("Start2");
            $http.get("/api/CarOrdersApi/GetCB_GetAllRentals",  headers)
                 //.success(function (response) { $scope.carOrders = response.data; })
            .success(function (response) {
                alert("Product has been successfully added.");
                $scope.carOrders = response;
            alert("Start3");
            })
            .error
                error(function (response) {
                alert("Error:\n" +
                    "Message: " + response.Message + "\n" +
                    "Message Detail: " + response.MessageDetail);
            });

        };
    });

})();

