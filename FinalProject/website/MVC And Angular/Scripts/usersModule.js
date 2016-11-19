(function () {

    "use strict"
    var usersModule = angular.module("usersModule", []);

    usersModule.controller("UsersController", function ($scope, $http) {

        $scope.addUser = function () {

            var data = JSON.stringify({
                "UserName": $scope.UserName,
                "Password" : $scope.Password,
                "FirstName": $scope.FirstName,
                "LastName" : $scope.LastName,
                "ID" :$scope.ID,
                "EMail" : $scope.EMail,
                "DateOfBirth": $scope.DateOfBirth,
                "Phone" : $scope.Phone, 
                "Mobile" : $scope.Mobile
            });

            var headers = {
                headers: {
                    "Content-Type": "application/json"
                }
            };
            $http.post("/api/UsersApi", data, headers)

            .success(function (responce) {
                alert("User was added.");
            })

            .error(function (response) {
                alert(
                "Error:\n" +
                "Message: " + response.Message + "\n" +
                "Message Detailes: " + response.MessageDetails);
            });
        };
        //$scope.getManufacturer = function () {
        //    var data = JSON.stringify({
        //        "ManufacturerID": $scope.ManufacturerID,


        //    });

        //    var headers = {
        //        headers: {
        //            "Content-Type": "application/json"
        //        }
        //    };
        //    alert("Start")
        //    $http.get("/api/ManufacturesApi").success(function (data, status, headers, config) {
        //        alert(data);
        //        alert(status);
        //        $scope.manufactures = data;
        //    }).error(function () { alert("Something") });

        //};
    });
})();