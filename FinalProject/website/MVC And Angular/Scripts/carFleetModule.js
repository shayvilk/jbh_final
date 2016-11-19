(function () {

    "use strict"

    var carFleetModule = angular.module("carFleetModule", []);

    carFleetModule.controller("CarFleetController", function ($scope, $http) {

        $scope.addCarToFleet = function () {

            var data = JSON.stringify({
                "carID": $scope.CarID,
                "CarModuleID": $scope.CarModuleID,
                "Mileage": $scope.Mileage,
                "Photo": $scope.Photo,
                "ReadyForRental": $scope.ReadyForRental
                
                
            });

            // State that the data is in JSON format:
            var headers = {
                headers: {
                    "Content-Type": "application/json"
                }
            };

            $http.post("/api/CarFleetApi", data, headers)

            .success(function (response) {
                alert("Car has been successfully added.");
            })

            .error(function (response) {
                alert(
                    "Error:\n" +
                    "Message: " + response.Message + "\n" +
                    "Message Detail: " + response.MessageDetail);
            });

        };
        $scope.removeCarFromFleet = function () {

            var data = JSON.stringify({
                //להוסיף משתנים
            });

            // State that the data is in JSON format:
            var headers = {
                headers: {
                    "Content-Type": "application/json"
                }
            };

            $http.post("/api/CarFleetApi", data, headers)

            .success(function (response) {
                alert("Car has been successfully remove.");
            })

            .error(function (response) {
                alert(
                    "Error:\n" +
                    "Message: " + response.Message + "\n" +
                    "Message Detail: " + response.MessageDetail);
            });

        };

        $scope.getCarFromFleet = function () {

            // State that the data is in JSON format:
            var headers = {
                headers: {
                    "Content-Type": "application/json"
                }
            };

            $http.get("/api/CarFleetApi", headers)

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

