var app = angular.module('AppBanHang', []);
app.controller("HomeCtrl", function ($scope, $http) {
    $scope.listSanPham;
    $scope.listLoaiSp;
    $scope.listDanhMuc;
    $scope.listSanPhamMoi;
    $scope.listSanPhamBanChay;
    $scope.listVanhocvietnam;
    $scope.listVanhocnuocngoai;
    $scope.listSanPhamByTacGia;
    $scope.listSanPhamByNhasx;
    $scope.listSanPhamTimKiem;
    $scope.listCungTacGia;
    $scope.tenKhachHang;
    $scope.diaChi;
    $scope.email;
    $scope.sdt;
    $scope.sanp_id;
    $scope.soLuong;
    $scope.giaMua;

    $scope.LoadSanPham = function () {
        $http({
            method: 'GET',
            url: current_url + '/api/Home/get-all-data-sach',
        }).then(function (response) {
            $scope.listSanPham = response.data;
            makeScript('js/main.js')
        });
    };
    $scope.LoadSanPhamMoi = function () {
        $http({
            method: 'GET',
            url: current_url + '/api/Home/get-all-sanphammoi/10',
        }).then(function (response) {
            $scope.listSanPhamMoi = response.data;
            makeScript('js/main.js')
        });
    };
    $scope.LoadSanPhamBanChay = function () {
        $http({
            method: 'GET',
            url: current_url + '/api/Home/get-all-banchay/10',
        }).then(function (response) {
            $scope.listSanPhamBanChay = response.data;
            makeScript('js/main.js')
        });
    };
    $scope.datHang = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            tenKhachHang: $scope.tenKhachHang,
            diaChi: $scope.diaChi,
            email: $scope.email,
            sdt: $scope.sdt,
            sanp_id: $scope.sanp_id,
            soLuong: $scope.soLuong,
            giaMua: $scope.giaMua

        }
       $http({
           method: 'POST', 
           data: model, 
           url: current_url + '/api/DonHang/create-DonHang'
       }).then(function (response) {	
          alert('Thêm đơn hàng thành công');
       });
   };
    $scope.LoadLoaisp = function () {
        $http({
            method: 'GET',
            url: current_url + '/api/Home/get-all-data-loaisp/10',
        }).then(function (response) {
            $scope.listLoaiSp = response.data;
            makeScript('js/main.js')
        });
    };
    // $scope.LoadLoaiSpByDanhMuc = function (id) { 
				 
    //     $http({
    //         method: 'GET', 
    //         url: current_url + '/api/Home/get-loaisp-by-danhmuc/'+id,
    //     }).then(function (response) { 
    //         $scope.listLoaiSp = response.data;
	// 		makeScript('js/main.js')
    //     });
    // };  
    $scope.LoadVanhocvietnam = function () {
        $http({
            method: 'GET',
            url: current_url + '/api/Home/get-sanpham-by-loai/4/10',
        }).then(function (response) {
            $scope.listVanhocvietnam = response.data;
            makeScript('js/main.js')
        });
    };
    $scope.LoadVanhocnuocngoai = function () {
        $http({
            method: 'GET',
            url: current_url + '/api/Home/get-sanpham-by-loai/5/10',
        }).then(function (response) {
            $scope.listVanhocnuocngoai = response.data;
            makeScript('js/main.js')
        });
    };
    $scope.addToCart = function (item) {
        var list = null;
        item.soLuong = 1;       
        var list;
        if (localStorage.getItem('car') == null) {
            list = [item];
        } else {
            list = JSON.parse(localStorage.getItem('car')) || [];
            let ok = true;
            for (let x of list) {
                if (x.sanp_id == item.sanp_id) {
                    x.soLuong += 1;
                    ok = false;
                    break;
                }
            }
            if (ok) {
                list.push(item);
            }
        }
        localStorage.setItem('car', JSON.stringify(list));
        alert("Đã thêm giỏ hàng thành công!");
    };
    $scope.listSanPhamByLoai;  
    $scope.LoadSanPhambyLoai = function () { 
		var key = 'ten';
		var value = window.location.search.substring(window.location.search.indexOf(key)+key.length+1);		 
        $http({
            method: 'GET', 
            url: current_url + '/api/Home/get-sanpham-by-loai/'+value+'/10',
        }).then(function (response) { 
            $scope.listSanPhamByLoai = response.data;
			makeScript('js/main.js')
        });
    };  
    $scope.LoadSanPhamCungTacGia = function () { 
		var key = 'id';
		var value = window.location.search.substring(window.location.search.indexOf(key)+key.length+1);		 
        $http({
            method: 'GET', 
            url: current_url + '/api/Home/sach-cung-tacgia/'+value+'/5',
        }).then(function (response) { 
            $scope.listCungTacGia = response.data;
			makeScript('js/main.js')
        });
    };  
    $scope.LoadSanPhambyLoai()
    $scope.LoadSanPhamCungTacGia()
    $scope.LoadSanPhambyTacGia = function () { 
		var key = 'id';
		var value = window.location.search.substring(window.location.search.indexOf(key)+key.length+1);		 
        $http({
            method: 'GET', 
            url: current_url + '/api/Home/get-data-sach-by-tacgia/'+value
        }).then(function (response) { 
            $scope.listSanPhamByTacGia = response.data;
			makeScript('js/main.js')
        });
    };  
    $scope.LoadSanPhambyNhasx = function () { 
		var key = 'id';
		var value = window.location.search.substring(window.location.search.indexOf(key)+key.length+1);		 
        $http({
            method: 'GET', 
            url: current_url + '/api/Home/get-data-sach-by-nhasx/'+value
        }).then(function (response) { 
            $scope.listSanPhamByNhasx = response.data;
			makeScript('js/main.js')
        });
    };  
    $scope.ten;
    $scope.TimKiemSanPham = function () { 
        var key = 'ten';
		var value = window.location.search.substring(window.location.search.indexOf(key)+key.length+1);		 
        $http({
            method: 'GET', 
           
            url: current_url + '/api/Home/timkiem-sanpham-theo-ten/'+value,
        }).then(function (response) { 
            $scope.listSanPhamTimKiem = response.data;
			makeScript('js/main.js')
        });
    };  
    $scope.TimKiemDonHang = function (ten) {
        
        $http({
            method: 'GET',
            // data: model,
            url: current_url + '/api/DonHang/timkiem/' + ten,
            
        }).then(function (response) {
            
            $scope.listDonHang = response.data;
            makeScript('js/main.js')
            alert('Thành công')
        });
        }
    $scope.TimKiemSanPham();
    $scope.LoadSanPhambyTacGia()
    $scope.LoadSanPhambyNhasx()

    $scope.LoadLoaisp();
    $scope.LoadSanPham();
 
    $scope.LoadSanPhamMoi();
    $scope.LoadSanPhamBanChay();
    $scope.LoadVanhocvietnam();
    $scope.LoadVanhocnuocngoai();
    $scope.loadCart = function () {
        $scope.listCart = JSON.parse(localStorage.getItem('car'));
   };
   $scope.loadCart();
});
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

app.controller("DonHangCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    
    $scope.dat = function () {
    
    var khachHang = {
        maKhachHang:0, 
        tenKhachHang: $scope.tenKhachHang,
        diaChi: $scope.diaChi,
        email: $scope.email,
        sdt: $scope.sdt,
        
    };
    var orderDetails = JSON.parse(localStorage.getItem('car'));
    var requestBody = {
        khachHang: khachHang,
        listchitiet: orderDetails,
      };
      console.log(requestBody);
      $http({
        method: 'POST', 
        data: requestBody, 
        url: current_url + '/api/DonHang/create-DonHang'
    }).then(function (response) {	
     if (response.status === 200) {
         console.log("Order created successfully");
         // Clear the local storage
         localStorage.removeItem('car');
         alert("Thêm thành công");
       } else {
         console.error("Failed to create order");
         alert("Lỗi đơn hàng");
       }
     })
     .catch(function (error) {
       console.error("Failed to create order", error);
       alert("Lỗi đơn hàng");
     });
   
    
       
   };
   $scope.loadCart = function () {
        $scope.list = JSON.parse(localStorage.getItem('car'));
   };
   $scope.loadCart();
    
});