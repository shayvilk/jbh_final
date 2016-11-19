(function () {

    "use strict"

    var manufacturesModule = angular.module("manufacturesModule", []);

    manufacturesModule.controller("ManufacturesController", function ($scope, $http) {

        $scope.addManufacturer = function () {

            var data = JSON.stringify({
                "ManufacturerName": $scope.ManufacturerName,
                

            });

            var headers = {
                headers: {
                    "Content-Type": "application/json"
                }
            };
            $http.post("/api/ManufacturesApi", data, headers)

            .success(function(responce){
                alert("Manufacturer was added.");
            })

            .error(function(response){
                alert(
                "Error:\n" +
                "Message: " + response.Message + "\n" + 
                "Message Detailes: " + response.MessageDetails);
            });
        };
        $scope.getManufacturer = function () {
            var data = JSON.stringify({
                "ManufacturerID": $scope.ManufacturerID,


            });

            var headers = {
                headers: {
                    "Content-Type": "application/json"
                }
            };
            alert ("Start")
            $http.get("/api/ManufacturesApi").success(function (data,status,headers,config) {
                alert(data);
                alert(status);
                $scope.manufactures = data;
            }).error(function () { alert("Something")});
            
        };
    });
})();