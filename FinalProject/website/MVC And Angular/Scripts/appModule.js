(function () {

    "use strict"
    var appModule = angular.module("appModule", ["ngRoute", "homeModule", "manufacturesModule", "usersModule", "carOrdersModule", "carFleetModule"]);
    appModule.config(["$routeProvider", function ($routeProvider) {

            // Adding Routes ("/" is the default home route): 
            $routeProvider.when("/homePage", {
                templateUrl: "/HTML/homePage.html",
                controller: "HomeController"
            })
            $routeProvider.when("/manufacturerPage", {
            templateUrl: "/HTML/manufacturerPage.html",
            controller: "ManufacturesController"
        })
        $routeProvider.when("/newUserPage", {
            templateUrl: "/HTML/newUserPage.html",
            controller: "UsersController"
        })
        $routeProvider.when("/carOrdersPage", {
            templateUrl: "/HTML/carOrdersPage.html",
            controller: "CarOrdersController"
        })
        $routeProvider.when("/carOrdersStatusPage", {
            templateUrl: "/HTML/carOrdersStatusPage.html",
            controller: "CarOrdersController"
        })
        $routeProvider.when("/carFleetManagmentPage", {
            templateUrl: "/HTML/carFleetManagment.html",
            controller: "CarFleetController"
        })
            .otherwise({
                redirectTo: "/"
            });

        }]);

    })();






    //// Creating the app module: 
    //var appModule = angular.module("appModule", ["ngRoute", "homeModule", "carOrdersModule", "testModule", "suppliersModule"]);

    //// Creating the different routes: 
    //appModule.config(function ($routeProvider) {

    //    $routeProvider.when("/home", {
    //        templateUrl: "/HTML/homePage.html",
    //        controller: "HomeController"
    //    })


    //    .when("/orderPage", {
    //        templateUrl: "/HTML/carOrderPage.html",
    //        controller: "CarOrderController"
    //    })

    //    .when("/suppliers", {
    //        templateUrl: "/HTML/suppliersPage.html",
    //        controller: "SuppliersController"
    //    })

    //    .when("/test", {
    //        templateUrl: "/HTML/test.html",
    //        controller: "TestController"
    //    })

    //    .otherwise({
    //        redirectTo: "/test"
    //    });

 //   });

//})();