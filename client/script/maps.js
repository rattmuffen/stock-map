
var app = angular.module('stock-map', []);

app.controller('StockCtrl', function ($scope, $http) {
	$scope.name = 'stock-maps!';
	$scope.serverURL = 'http://jsonplaceholder.typicode.com/users?callback=JSON_CALLBACK';

	$scope.types = {
		'SATTELITE' : {name: 'Satellite', id: google.maps.MapTypeId.SATELLITE},
		'TERRAIN' : {name: 'Terrain', id: google.maps.MapTypeId.TERRAIN},
		'ROADMAP' : {name: 'Roadmap', id: google.maps.MapTypeId.ROADMAP},
		'HYBRID' : {name: 'Hybrid', id: google.maps.MapTypeId.HYBRID}
	};

	$scope.map;
	$scope.initLocation = new google.maps.LatLng(58.3995457, 15.6016341); // Lägerhyddan rulez!
	$scope.mapOptions = {
		zoom: 5,
		center: $scope.initLocation,
		mapTypeControl: false
	};

	$scope.init = function () {
		// Init map object.
		$scope.map = new google.maps.Map($('#map-canvas')[0], $scope.mapOptions);

		// Geolocation?
		if (navigator.geolocation) {
			navigator.geolocation.getCurrentPosition(function (position) {
				$scope.initLocation = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);

				// Add marker with special icon.
				var m = $scope.addMarker(position.coords.latitude, position.coords.longitude, 'Här är jag!', 'Din dator bor här... typ.');
				m.setIcon('http://maps.google.com/mapfiles/ms/icons/blue-dot.png');
			});
		}
	};

	// Get data from server.
	$scope.getData = function () {
		$http.get($scope.serverURL)
			.success(function (data) {
				console.log('Got data!');
				console.log(data);

				$.each(data, function(index, company) {

					// Add marker.
					$scope.addMarker(company.Location.Latitude, company.Location.Longitude, company.CompanyName, company.CompanyName + ' har sin stämma här');
				});
			}).error(function (err) {
				console.log('Error: ' + err);
			});
	};

	// Set map type.
	$scope.setType = function (type) {
		$scope.map.setMapTypeId(type.id);
	};

	// Add a maker and infoWindow to the map.
	$scope.addMarker = function (lat, lng, title, info) {
		var pos = new google.maps.LatLng(lat, lng);

		// Construct marker
		var marker = new google.maps.Marker({
			position: pos,
			map: $scope.map,
			title: info
		});

		// Construct infoWindow.
		var infoWindow = new google.maps.InfoWindow({
			content: '<h1>' + title + '</h1><br><p>' + info + '</p>'
		});

		// Open infowindow on marker click.
		google.maps.event.addListener(marker, 'click', function () {
			infoWindow.open($scope.map,marker);
		});

		return marker;
	};

	// Center map on initialLocation.
	$scope.center = function () {
		$scope.map.setCenter($scope.initLocation);
	};
});
