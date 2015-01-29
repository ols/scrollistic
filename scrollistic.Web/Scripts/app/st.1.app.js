angular.module("app.services", []);
angular.module("app.directives", ["app.services"]);
angular.module("app.controllers", ["app.services"]);

var app = angular.module('app', ["afkl.lazyImage", "ui.unique", "pasvaz.bindonce", "infinite-scroll", "app.services", "app.directives", "app.controllers"]);
app.run(["$rootScope", function ($rootScope) {
}]);
