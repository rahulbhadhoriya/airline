(function (app) {

    var baseUrl = "/api/flights";

    var flightService = function ($http) {
        var flightFactory = {};
        flightFactory.getFlights = function () {
            return $http.get(baseUrl);
        };

        flightFactory.selectFlight = function(id) {
            //
            // $http.put("/flights/select/3", id)
            //
            return true;
        };
        return flightFactory;
    };

    app.factory("flightService", ["$http",flightService]);


}(angular.module("airlineApp")));