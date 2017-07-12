(function(app) {

    var flightsController = function($scope, flightService, $timeout) {


        var onError = function() {
            alert("error!!");
        };

        var onFlights = function(response) {
            $scope.flights = response.data; 
        };


        var init = function() {
            $scope.flights = flightService.getFlights().then(onFlights, onError);
        };


        $scope.selectFlight = function(flight) {
            for (var i=0; i < $scope.flights.length; i++) {
                $scope.flights[i].approved = false;
            }            
            flight.approved = !flight.approved;

            if (flightService.selectFlight(flight.id)) {
                $scope.status = "You have made a great decision!";
                $timeout(function() {
                    $scope.status = null;
                }, 3000);
            }            
        };

        init();
    };
    
    app.controller("flightsController", ["$scope", "flightService", "$timeout", flightsController]);

}(angular.module("airlineApp")));
