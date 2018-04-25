var authenticationApp = angular.module('authenticationApp', ['ui.bootstrap', 'ngRoute']);

authenticationApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.when('/register', {
        templateUrl:'Templates/register.html',
        controller: 'RegisterCtrl'
    }).when('/login', {
        templateUrl: 'Templates/login.html',
        controller: 'LoginCtrl'
    })
}]);

authenticationApp.controller('HeaderCtrl', ['$scope', function ($scope) {
}]);