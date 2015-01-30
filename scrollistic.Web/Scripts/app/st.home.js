var app = angular.module("app.controllers");
app.controller("HomeController", [
    "$scope", "$http", function ($scope, $http) {
        $scope.items = [];
        $scope.page = 0;
        $scope.skip = 128;
        $scope.take = 128;
        $scope.defaultSkip = 128;
        $scope.defaultTake = 128;

        $scope.search = function() {
            $http.get("/Home/Search?input=laj" +
                "&take=" + $scope.take +
                "&page=" + $scope.page +
                "&skip=" + $scope.skip).success(function (data) {
                for (var i = 0; i < data.Cars.length; i++) {
                    $scope.items.push(data.Cars[i]);
                }
            });
        };

        $scope.fetchMore = function () {
            $scope.skip = 0;
            $scope.take = $scope.defaultTake;
            $scope.page = parseInt($scope.page + 1);
            $scope.search();
        };

        $scope.initSearch = function (items) {
            angular.forEach(items, function (value, key) {
                $scope.items.push(value);
            });
        };
    }
]);