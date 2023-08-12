 var app = angular.module('AppBanHang', []);
app.controller("ChitietCtrl", function ($scope, $http) {
    $scope.SachModel;  
    $scope.LoadSanPhambyID = function () { 
		var key = 'id';
		var value = window.location.search.substring(window.location.search.indexOf(key)+key.length+1);		 
        $http({
            method: 'GET', 
            url: current_url + '/api/Home/get-data-sach-by-id/'+value,
        }).then(function (response) { 
            $scope.SachModel = response.data;
			makeScript('js/main.js')
        });
    };  
    $scope.LoadSanPhambyID()
});

