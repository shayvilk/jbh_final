
// Self-Invoking Function: 
(function () {

    // Strict Mode: 
    "use strict"

    // Creating Home Module: 
    var testModule = angular.module("testModule", []);

    // Creating Home Controller: 
    testModule.controller("TestController", ["$scope", "$http", function ($scope, $http) {
        alert("first");
        $http.get("TestService.ashx").success(function (response) {
            alert("second");
            $scope.carList = response;

        });

    }]);

})();

