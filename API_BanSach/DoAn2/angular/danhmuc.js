var _user = JSON.parse(localStorage.getItem("user"));
var app = angular.module('AppBanHang', []); //Các mô-đun AngularJS xác định các ứng dụng:
//'angularUtils.directives.dirPagination'
app.controller("DanhMucCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    $scope.ten
    $scope.id
    $scope.tenloai
    $scope.ma
    $scope.listDanhMuc
    $scope.save = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            tenDanhMuc: $scope.ten
        }
       $http({
           method: 'POST', 
           data: model, 
           headers: { "Authorization": 'Bearer ' + _user.token },
           url: current_url + '/api/DanhMuc/create-danhmuc'
       }).then(function (response) {	
          alert('Thêm danh mục thành công');
       });
   };

   //search
//    $scope.totalCount = 0;
//     $scope.tenDanhMucSearch = "";

//     $scope.pageSize = '5'

//     $scope.getPage = function (newPage) {
//         $scope.pageNumber = newPage
//         /** Lấy danh sách*/
//         $http.get("https://localhost:44395/api/DanhMuc/search-DauSach", {
//             params: { tenDanhMuc: $scope.tenDanhMucSearch, page: $scope.pageNumber, pageSize: $scope.pageSize }
//         }).then(function (res) {
//             console.log(res)
//             $scope.listDanhMuc = res.data.data
//             $scope.totalCount = res.data.totalItems
//         })
//     }

//     $scope.getPage(1)


   $scope.edit = function () {
    let model = {
        maDanhMuc: $scope.id,
        tenDanhMuc: $scope.ten
    }
   $http({
       method: 'POST', 
       headers: { "Authorization": 'Bearer ' + _user.token },
       data: model, 
       url: current_url + '/api/DanhMuc/update-danhmuc'
   }).then(function (response) {	
      alert('Sửa danh mục thành công');
   });
    };
    $scope.xoa = function (id) {
        	
       $http({
           method: 'DELETE', 
        //    data: model, 
            headers: { "Authorization": 'Bearer ' + _user.token },
           url: current_url + '/api/DanhMuc/delete-danhmuc/' + id
       }).then(function (response) {	
          alert('Xoá danh mục thành công');
       });
        };
        $scope.TimKiem = function (tenloai) {
        
            $http({
                method: 'GET',
                headers: { "Authorization": 'Bearer ' + _user.token },
                // data: model,
                url: current_url + '/api/DanhMuc/TimKiem/' + tenloai,
                
            }).then(function (response) {
                
                $scope.listDanhMuc = response.data;
                makeScript('js/main.js')
                alert('Thành công')
            });
            }
        $scope.LoadDanhMuc = function () {
            $http({
                method: 'GET',
                headers: { "Authorization": 'Bearer ' + _user.token },
                url: current_url + '/api/DanhMuc/get-all-data/20',
            }).then(function (response) {
                $scope.listDanhMuc = response.data;
                makeScript('js/main.js')
            });
            };
    $scope.LoadDanhMuc();
    // $scope.TimKiem(ma);


})
app.controller("user", function ($scope, $http){
    $scope.LogOut = function () {
        window.localStorage.removeItem('user');
        alert("Đăng xuất thành công");
   };
})
app.controller("LoaiSpCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    $scope.ten
    $scope.id
    $scope.tenloai
    $scope.ma
    $scope.danhmuc
    $scope.listLoaiSp
    $scope.save = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            loai_name: $scope.ten,
            danhmuc_id: $scope.danhmuc
        }
       $http({
           method: 'POST', 
           headers: { "Authorization": 'Bearer ' + _user.token },
           data: model, 
           url: current_url + '/api/Loaisp/create-loaisp'
       }).then(function (response) {	
          alert('Thêm loại sản phẩm thành công');
       });
   };
   $scope.edit = function () {
    let model = {
        loai_id: $scope.id,
        loai_name: $scope.ten,
        danhmuc_id: $scope.danhmuc
    }
   $http({
       method: 'POST', 
       data: model, 
       headers: { "Authorization": 'Bearer ' + _user.token },
       url: current_url + '/api/Loaisp/update-loaisp'
   }).then(function (response) {	
      alert('Sửa loại sản phẩm thành công');
   });
    };
    $scope.xoa = function (id) {
        	
       $http({
           method: 'DELETE', 
        //    data: model, 
        headers: { "Authorization": 'Bearer ' + _user.token },
           url: current_url + '/api/Loaisp/delete-loaisp/' + id
       }).then(function (response) {	
          alert('Xoá loại sản phẩm thành công');
       });
        };
    $scope.LoadDanhMuc = function () {
    $http({
        method: 'GET',
        headers: { "Authorization": 'Bearer ' + _user.token },
        url: current_url + '/api/Loaisp/get-loaisp/20',
    }).then(function (response) {
        $scope.listLoaiSp = response.data;
        makeScript('js/main.js')
    });
    };
    $scope.TimKiem = function (tenloai) {
        
        $http({
            method: 'GET',
            headers: { "Authorization": 'Bearer ' + _user.token },
            // data: model,
            url: current_url + '/api/Loaisp/TimKiem/' + tenloai,
            
        }).then(function (response) {
            
            $scope.listLoaiSp = response.data;
            makeScript('js/main.js')
            alert('Thành công')
        });
        }
   
    $scope.LoadDanhMuc();
   
   


})

app.controller("KhoCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    $scope.ten
    $scope.id
    $scope.diaChi
    $scope.sanp_id
    $scope.tenloai
    $scope.soLuong
    $scope.listKho
    $scope.save = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            tenKho: $scope.ten,
            diaChi: $scope.diaChi,
            sanp_id: $scope.sanp_id,
            soLuong: $scope.soLuong
        }
       $http({
           method: 'POST', 
           headers: { "Authorization": 'Bearer ' + _user.token },
           data: model, 
           url: current_url + '/api/Kho/create-Kho'
       }).then(function (response) {	
          alert('Thêm kho hàng thành công');
       });
   };
   $scope.edit = function () {
    let model = {
        maKho: $scope.id,
        tenKho: $scope.ten,
            diaChi: $scope.diaChi,
            sanp_id: $scope.sanp_id,
            soLuong: $scope.soLuong
    }
   $http({
       method: 'POST', 
       data: model, 
       headers: { "Authorization": 'Bearer ' + _user.token },
       url: current_url + '/api/Kho/update-Kho'
   }).then(function (response) {	
      alert('Sửa thông tin kho thành công');
   });
    };
    $scope.xoa = function (id) {
        	
       $http({
           method: 'DELETE', 
           headers: { "Authorization": 'Bearer ' + _user.token },
        //    data: model, 
           url: current_url + '/api/Loaisp/delete-loaisp/' + id
       }).then(function (response) {	
          alert('Xoá loại sản phẩm thành công');
       });
        };
   $scope.LoadKho = function () {
    $http({
        method: 'GET',
        headers: { "Authorization": 'Bearer ' + _user.token },
        url: current_url + '/api/Kho/get-all-data',
    }).then(function (response) {
        $scope.listKho = response.data;
        makeScript('js/main.js')
    });
    };
    $scope.TimKiem = function (tenloai) {
        
        $http({
            method: 'GET',
            headers: { "Authorization": 'Bearer ' + _user.token },
            // data: model,
            url: current_url + '/api/Kho/TimKiem/' + tenloai,
            
        }).then(function (response) {
            
            $scope.listKho = response.data;
            makeScript('js/main.js')
            alert('Thành công')
        });
        }
    $scope.LoadKho();


})

app.controller("NhaSanXuatCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    $scope.ten
    $scope.id
    $scope.sdt
    $scope.diachi
    $scope.tenloai
    $scope.listNhaSanXuat
    $scope.save = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            nsx_name: $scope.ten,
            sdt: $scope.sdt,
            diachi: $scope.diachi
        }
       $http({
           method: 'POST', 
           headers: { "Authorization": 'Bearer ' + _user.token },
           data: model, 
           url: current_url + '/api/NhaSanXuat/create-nhasanxuat'
       }).then(function (response) {	
          alert('Thêm nhà cung cấp thành công');
       });
   };
   $scope.edit = function () {
    let model = {
        nsx_id: $scope.id,
        nsx_name: $scope.ten,
        sdt: $scope.sdt,
        diachi: $scope.diachi
    }
   $http({
       method: 'POST', 
       headers: { "Authorization": 'Bearer ' + _user.token },
       data: model, 
       url: current_url + '/api/NhaSanXuat/update-nhasanxuat'
   }).then(function (response) {	
      alert('Sửa nhà cung cấp thành công');
   });
    };
    $scope.xoa = function (id) {
        	
       $http({
           method: 'DELETE', 
           headers: { "Authorization": 'Bearer ' + _user.token },
        //    data: model, 
           url: current_url + '/api/NhaSanXuat/delete-nhasanxuat/' + id
       }).then(function (response) {	
          alert('Xoá nhà cung cấp thành công');
       });
        };
   $scope.LoadNhaSanXuat = function () {
    $http({
        method: 'GET',
        headers: { "Authorization": 'Bearer ' + _user.token },
        url: current_url + '/api/NhaSanXuat/get-all-data/20',
    }).then(function (response) {
        $scope.listNhaSanXuat = response.data;
        makeScript('js/main.js')
    });
    };
    $scope.TimKiem = function (tenloai) {
        
        $http({
            method: 'GET',
            headers: { "Authorization": 'Bearer ' + _user.token },
            // data: model,
            url: current_url + '/api/NhaSanXuat/TimKiem/' + tenloai,
            
        }).then(function (response) {
            
            $scope.listNhaSanXuat = response.data;
            makeScript('js/main.js')
            alert('Thành công')
        });
        }
    $scope.LoadNhaSanXuat();


})

app.controller("TacGiaCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    $scope.ten
    $scope.id
    $scope.sdt
    $scope.diachi
    $scope.tenloai
    $scope.listTacGia
    $scope.save = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            tG_name: $scope.ten,
            sdt: $scope.sdt,
            tG_diachi: $scope.diachi
        }
       $http({
           method: 'POST', 
           headers: { "Authorization": 'Bearer ' + _user.token },
           data: model, 
           url: current_url + '/api/TacGia/create-tacgia'
       }).then(function (response) {	
          alert('Thêm tác giả thành công');
       });
   };
   $scope.edit = function () {
    let model = {
        tG_id: $scope.id,
        tG_name: $scope.ten,
        sdt: $scope.sdt,
        tG_diachi: $scope.diachi
    }
   $http({
       method: 'POST', 
       headers: { "Authorization": 'Bearer ' + _user.token },
       data: model, 
       url: current_url + '/api/TacGia/update-tacgia'
   }).then(function (response) {	
      alert('Sửa tác giả thành công');
   });
    };
    $scope.xoa = function (id) {
        	
       $http({
           method: 'DELETE', 
           headers: { "Authorization": 'Bearer ' + _user.token },
        //    data: model, 
           url: current_url + '/api/TacGia/delete-tacgia/' + id
       }).then(function (response) {	
          alert('Xoá tác giả thành công');
       });
        };
   $scope.LoadNhaSanXuat = function () {
    $http({
        method: 'GET',
        headers: { "Authorization": 'Bearer ' + _user.token },
        url: current_url + '/api/TacGia/get-all-data/20',
    }).then(function (response) {
        $scope.listTacGia = response.data;
        makeScript('js/main.js')
    });
    };
    $scope.TimKiem = function (tenloai) {
        
        $http({
            method: 'GET',
            headers: { "Authorization": 'Bearer ' + _user.token },
            // data: model,
            url: current_url + '/api/TacGia/TimKiem/' + tenloai,
            
        }).then(function (response) {
            
            $scope.listTacGia = response.data;
            makeScript('js/main.js')
            alert('Thành công')
        });
        }
    $scope.LoadNhaSanXuat();


})

app.controller("SanPhamCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    $scope.ten
    $scope.id
    $scope.ma
    $scope.size
    $scope.tacgia
    $scope.loaisp
    $scope.nhasanxuat
    $scope.sotrang
    $scope.tomtat
    $scope.tenloai
    $scope.namsx
    $scope.gia
    $scope.file
    $scope.listSanPham
    // $scope.UpLoad = function () {
    //     $http({
    //          method: 'POST',
    //          url: current_url + '/api/Users/upload',
    //      }).then(function (response) {
    //         $scope.file = response.data.filePath;
    //         makeScript('js/main.js')
    //     });
    // };
    // $scope.UpLoad();
    
    $scope.Saves = function () {

        let model = {
            // maLV: $scope.maDanhMuc,
            sanp_name: $scope.ten,
            size: $scope.size,
            tG_id: $scope.tacgia,
            loai_id: $scope.loaisp,
            nsx_id: $scope.nhasanxuat,
            sotrang: $scope.sotrang,
            tomtat: $scope.tomtat,
            namsx: $scope.namsx,
            gia: $scope.gia
            
        }
        var file = document.getElementById('file').files[0];
        const formData = new FormData();
        formData.append('file', file);
        $http({
             method: 'POST',
             headers: {
                
                'Content-Type': undefined
            },
             data: formData,
             url: current_url + '/api/Users/upload',
         }).then(function (res) {
             model.image = res.data.filePath;
             $http({
                 method: 'POST',
                 headers: { "Authorization": 'Bearer ' + _user.token },
                 data: model,
                 url: current_url + '/api/Sach/create-sach',
             }).then(function (response) {
                 $scope.LoadSanPham();
                 alert('Thêm sản phẩm thành công!');
             });
         });
    };


//     $scope.save = function () {
//         let model = {
//             // maLV: $scope.maDanhMuc,
//             sanp_name: $scope.ten,
//             size: $scope.size,
//             tG_id: $scope.tacgia,
//             loai_id: $scope.loaisp,
//             nsx_id: $scope.nhasanxuat,
//             sotrang: $scope.sotrang,
//             tomtat: $scope.tomtat,
//             namsx: $scope.namsx,
//             image: $scope.file
//         }
//        $http({
//            method: 'POST', 
//            data: model, 
//            url: current_url + '/api/Sach/create-sach'
//        }).then(function (response) {	
//           alert('Thêm sản phẩm thành công');
//        });
//    };
   $scope.edit = function () {
    let model = {
        // maLV: $scope.maDanhMuc,
        sanp_id: $scope.id,
        sanp_name: $scope.ten,
        size: $scope.size,
        tG_id: $scope.tacgia,
        loai_id: $scope.loaisp,
        nsx_id: $scope.nhasanxuat,
        sotrang: $scope.sotrang,
        tomtat: $scope.tomtat,
        namsx: $scope.namsx,
        gia: $scope.gia
        
    }
    var file = document.getElementById('file').files[0];
    const formData = new FormData();
    formData.append('file', file);
    $http({
         method: 'POST',
         headers: {
            
            'Content-Type': undefined
        },
         data: formData,
         url: current_url + '/api/Users/upload',
     }).then(function (res) {
         model.image = res.data.filePath;
         $http({
             method: 'POST',
             headers: { "Authorization": 'Bearer ' + _user.token },
             data: model,
             url: current_url + '/api/Sach/update-sach',
         }).then(function (response) {
             $scope.LoadSanPham();
             alert('Sửa sản phẩm thành công!');
         });
     });
    };
    $scope.xoa = function (id) {
        	
       $http({
           method: 'DELETE', 
           headers: { "Authorization": 'Bearer ' + _user.token },
        //    data: model, 
           url: current_url + '/api/Sach/delete-sach/' + id
       }).then(function (response) {	
          alert('Xoá thông tin thành công');
       });
        };
   $scope.LoadSanPham = function () {
    $http({
        method: 'GET',
        headers: { "Authorization": 'Bearer ' + _user.token },
        url: current_url + '/api/Sach/get-all-data',
    }).then(function (response) {
        $scope.listSanPham = response.data;
        makeScript('js/main.js')
    });
    };
    $scope.TimKiem = function (tenloai) {
        
        $http({
            method: 'GET',
            headers: { "Authorization": 'Bearer ' + _user.token },
            // data: model,
            url: current_url + '/api/Sach/TimKiem/' + tenloai,
            
        }).then(function (response) {
            
            $scope.listSanPham = response.data;
            makeScript('js/main.js')
            alert('Thành công')
        });
        }
    $scope.LoadSanPham();
    
})

app.controller("KhachHangCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    $scope.ten
    $scope.id
    $scope.ma
    $scope.tenloai
    $scope.listDanhMuc
    $scope.save = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            tenDanhMuc: $scope.ten
        }
       $http({
           method: 'POST', 
           data: model, 
           headers: { "Authorization": 'Bearer ' + _user.token },
           url: current_url + '/api/DanhMuc/create-danhmuc'
       }).then(function (response) {	
          alert('Thêm danh mục thành công');
       });
   };
   $scope.edit = function () {
    let model = {
        maDanhMuc: $scope.id,
        tenDanhMuc: $scope.ten
    }
   $http({
       method: 'POST', 
       data: model, 
       headers: { "Authorization": 'Bearer ' + _user.token },
       url: current_url + '/api/DanhMuc/update-danhmuc'
   }).then(function (response) {	
      alert('Sửa danh mục thành công');
   });
    };
    $scope.xoa = function (id) {
        	
       $http({
           method: 'DELETE', 
           headers: { "Authorization": 'Bearer ' + _user.token },
        //    data: model, 
           url: current_url + '/api/DanhMuc/delete-danhmuc/' + id
       }).then(function (response) {	
          alert('Xoá danh mục thành công');
       });
        };
   $scope.LoadDanhMuc = function () {
    $http({
        method: 'GET',
        headers: { "Authorization": 'Bearer ' + _user.token },
        url: current_url + '/api/DanhMuc/get-all-data/20',
    }).then(function (response) {
        $scope.listDanhMuc = response.data;
        makeScript('js/main.js')
    });
    };
    $scope.TimKiem = function (tenloai) {
        
        $http({
            method: 'GET',
            headers: { "Authorization": 'Bearer ' + _user.token },
            // data: model,
            url: current_url + '/api/KhachHang/TimKiem/' + tenloai,
            
        }).then(function (response) {
            
            $scope.listKho = response.data;
            makeScript('js/main.js')
            alert('Thành công')
        });
        }
    $scope.LoadDanhMuc();
    // $scope.TimKiem(ma);


})

app.controller("NhanVienCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    $scope.id
    $scope.ten
    $scope.ngaySinh
    $scope.gioiTinh
    $scope.diaChi
    $scope.tenloai
    $scope.email
    $scope.sdt
   
    $scope.taiKhoan
    $scope.matKhau
    $scope.trangThai
    $scope.loaiQuyen
    $scope.listNhanVien
    $scope.save = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            hoTen: $scope.ten,
            sdt: $scope.sdt,
            diaChi: $scope.diaChi,
            ngaySinh: $scope.ngaySinh,
            gioiTinh: $scope.gioiTinh,
            email: $scope.email,
            taiKhoan: $scope.taiKhoan,
            matKhau: $scope.matKhau,
            trangThai: $scope.trangThai,
            loaiQuyen: $scope.loaiQuyen
        }
       $http({
           method: 'POST', 
           data: model, 
           headers: { "Authorization": 'Bearer ' + _user.token },
           url: current_url + '/api/NguoiDung/create-NguoiDung'
       }).then(function (response) {	
          alert('Thêm thông tin người dùng thành công');
       });
   };
   $scope.edit = function () {
    let model = {
        maNguoiDung: $scope.id,
        hoTen: $scope.ten,
            sdt: $scope.sdt,
            diaChi: $scope.diaChi,
            ngaySinh: $scope.ngaySinh,
            gioiTinh: $scope.gioiTinh,
            email: $scope.email,
            taiKhoan: $scope.taiKhoan,
            matKhau: $scope.matKhau,
            trangThai: $scope.trangThai,
            loaiQuyen: $scope.loaiQuyen
    }
   $http({
       method: 'POST', 
       headers: { "Authorization": 'Bearer ' + _user.token },
       data: model, 
       url: current_url + '/api/NguoiDung/update-NguoiDung'
   }).then(function (response) {	
      alert('Sửa thông tin người dùng thành công');
   });
    };
    $scope.xoa = function (id) {
        	
       $http({
           method: 'DELETE', 
           headers: { "Authorization": 'Bearer ' + _user.token },
        //    data: model, 
           url: current_url + '/api/NguoiDung/delete-NguoiDung/' + id
       }).then(function (response) {	
          alert('Xoá thông tin người dùng thành công');
       });
        };
   $scope.LoadNhanVien = function () {
    $http({
        method: 'GET',
        headers: { "Authorization": 'Bearer ' + _user.token },
        url: current_url + '/api/NguoiDung/get-all-data/20',
    }).then(function (response) {
        $scope.listNhanVien = response.data;
        makeScript('js/main.js')
    });
    };
    $scope.TimKiem = function (tenloai) {
        
        $http({
            method: 'GET',
            headers: { "Authorization": 'Bearer ' + _user.token },
            // data: model,
            url: current_url + '/api/NguoiDung/TimKiem/' + tenloai,
            
        }).then(function (response) {
            
            $scope.listNhanVien = response.data;
            makeScript('js/main.js')
            alert('Thành công')
        });
        }
    $scope.LoadNhanVien();


})

app.controller("HoaDonNhapCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    $scope.id
    $scope.maNguoiDung
    $scope.nsx_id
    $scope.sanp_id
    $scope.soLuong
    $scope.tenloai
    $scope.donGia
    $scope.listHoaDonNhap
    $scope.save = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            maNguoiDung: $scope.maNguoiDung,
            nsx_id: $scope.nsx_id,
            sanp_id: $scope.sanp_id,
            soLuong: $scope.soLuong,
            donGia: $scope.donGia
        }
       $http({
           method: 'POST', 
           headers: { "Authorization": 'Bearer ' + _user.token },
           data: model, 
           url: current_url + '/api/HoaDonNhap/create-HoaDonNhap'
       }).then(function (response) {	
          alert('Thêm hoá đơn thành công');
       });
   };
   $scope.savechitiet = function () {
    let model = {
        // maLV: $scope.maDanhMuc,
        soHoaDon: $scope.id,
        sanp_id: $scope.sanp_id,
        soLuong: $scope.soLuong,
        donGia: $scope.donGia
    }
   $http({
       method: 'POST', 
       headers: { "Authorization": 'Bearer ' + _user.token },
       data: model, 
       url: current_url + '/api/HoaDonNhap/create-ChiTietHoaDonNhap'
   }).then(function (response) {	
      alert('Thêm hoá đơn thành công');
   });
};
   $scope.edit = function () {
    let model = {
        soHoaDon: $scope.id,
        maNguoiDung: $scope.maNguoiDung,
        nsx_id: $scope.nsx_id,
        sanp_id: $scope.sanp_id,
        soLuong: $scope.soLuong,
        donGia: $scope.donGia
    }
   $http({
       method: 'POST', 
       headers: { "Authorization": 'Bearer ' + _user.token },
       data: model, 
       url: current_url + '/api/HoaDonNhap/update-HoaDonNhap'
   }).then(function (response) {	
      alert('Sửa tác giả thành công');
   });
    };
    $scope.xoa = function (id) {
        	
       $http({
           method: 'DELETE', 
           headers: { "Authorization": 'Bearer ' + _user.token },
        //    data: model, 
           url: current_url + '/api/HoaDonNhap/delete-HoaDonNhap/' + id
       }).then(function (response) {	
          alert('Xoá tác giả thành công');
       });
        };
   $scope.LoadHoaDonNhap = function () {
    $http({
        method: 'GET',
        headers: { "Authorization": 'Bearer ' + _user.token },
        url: current_url + '/api/HoaDonNhap/get-all-data/20',
    }).then(function (response) {
        $scope.listHoaDonNhap = response.data;
        makeScript('js/main.js')
    });
    };
    $scope.TimKiem = function (tenloai) {
        
        $http({
            method: 'GET',
            headers: { "Authorization": 'Bearer ' + _user.token },
            // data: model,
            url: current_url + '/api/HoaDonNhap/TimKiem/' + tenloai,
            
        }).then(function (response) {
            
            $scope.listHoaDonNhap = response.data;
            makeScript('js/main.js')
            alert('Thành công')
        });
        }
    $scope.LoadHoaDonNhap();


})

//
app.controller("DonHangCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    $scope.savedonhang = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            maKhachHang: $scope.maKhachHang,
            ngayDat: $scope.ngayDat,
          
            trangThai: $scope.trangThai
        }
       $http({
           method: 'POST', 
           headers: { "Authorization": 'Bearer ' + _user.token },
           data: model, 
           url: current_url + '/api/DonHang/Create_DonHang'
       }).then(function (response) {	
        $scope.LoadDonHang();
          alert('Thêm đơn hàng thành công');
       });
    };
    $scope.savechitiet = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            maDonHang: $scope.maDonHang,
            sanp_id: $scope.sanp_id,
            soLuong: $scope.soLuong,
            gia: $scope.gia
        }
       $http({
           method: 'POST', 
           headers: { "Authorization": 'Bearer ' + _user.token },
           data: model, 
           url: current_url + '/api/DonHang/Create_ChiTiet'
       }).then(function (response) {	
        $scope.LoadDonHang();
          alert('Thêm chi tiết đơn hàng thành công');
       });
    };
    $scope.xoaDonHang = function (id) {
        	
        $http({
            method: 'DELETE', 
            headers: { "Authorization": 'Bearer ' + _user.token },
         //    data: model, 
            url: current_url + '/api/DonHang/delete-donhang/' + id
        }).then(function (response) {	
            $scope.LoadDonHang();
           alert('Xoá đơn hàng thành công');
        });
    };
    $scope.TimKiem = function (ten) {
        
        $http({
            method: 'GET',
            headers: { "Authorization": 'Bearer ' + _user.token },
            // data: model,
            url: current_url + '/api/DonHang/timkiem/' + ten,
            
        }).then(function (response) {
            
            $scope.listDonHang = response.data;
            makeScript('js/main.js')
            alert('Thành công')
        });
        }
    $scope.xoaChiTiet = function (id) {
        	
        $http({
            method: 'DELETE', 
            headers: { "Authorization": 'Bearer ' + _user.token },
         //    data: model, 
            url: current_url + '/api/DonHang/delete-chitiet/' + id
        }).then(function (response) {	
            $scope.LoadDonHang();
           alert('Xoá chi tiết đơn hàng thành công');
        });
    };
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
        headers: { "Authorization": 'Bearer ' + _user.token },
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
   $scope.loadList = function (item) {
        $scope.list = JSON.parse(localStorage.getItem('car'));
   };

   $scope.editDonHang = function () {
    let model = {
        maDonHang: $scope.maDonHang,
        maKhachHang: $scope.maKhachHang,
        ngayDat: $scope.ngayDat,
        trangThai: $scope.trangThai
    }
   $http({
       method: 'POST', 
       headers: { "Authorization": 'Bearer ' + _user.token },
       data: model, 
       url: current_url + '/api/DonHang/update-donhang'
   }).then(function (response) {	
      $scope.LoadDonHang();
      alert('Sửa đơn hàng thành công');
      
   });
    };

    $scope.editChiTiet = function () {
        let model = {
            maChiTietDonHang: $scope.maChiTietDonHang,
            maDonHang: $scope.maDonHang,
            sanp_id: $scope.sanp_id,
            soLuong: $scope.soLuong,
            gia: $scope.gia
        }
       $http({
           method: 'POST', 
           headers: { "Authorization": 'Bearer ' + _user.token },
           data: model, 
           url: current_url + '/api/DonHang/update-chitiet'
       }).then(function (response) {	
        $scope.LoadDonHang();
          alert('Sửa chi tiết đơn hàng thành công');
          
       });
        };
    $scope.listDonHang
    $scope.LoadDonHang = function () {
    $http({
        method: 'GET',
        headers: { "Authorization": 'Bearer ' + _user.token },
        url: current_url + '/api/DonHang/get-all-data/15',
    }).then(function (response) {
        $scope.listDonHang = response.data;
        makeScript('js/main.js')
    });
    };
    $scope.LoadDonHang();
   $scope.loadList();
    
});

app.controller("HoaDonBanCtrl", function ($scope, $http){ //Bộ điều khiển AngularJS điều khiển các ứng dụng:
    // $scope.maDanhMuc 
    $scope.savehoadon = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            
            ngayBan: $scope.ngayBan,
          
            maKhachHang: $scope.maKhachHang
        }
       $http({
           method: 'POST', 
           data: model, 
           headers: { "Authorization": 'Bearer ' + _user.token },
           url: current_url + '/api/HoaDonBan/Create_HoaDon'
       }).then(function (response) {	
        $scope.LoadHoaDon();
          alert('Thêm hoá đơn thành công');
       });
    };
    $scope.savechitiet = function () {
        let model = {
            // maLV: $scope.maDanhMuc,
            soHoaDon: $scope.soHoaDon,
            sanp_id: $scope.sanp_id,
            soLuong: $scope.soLuong,
            giaBan: $scope.giaBan
        }
       $http({
           method: 'POST', 
           data: model, 
           headers: { "Authorization": 'Bearer ' + _user.token },
           url: current_url + '/api/HoaDonBan/Create_ChiTiet'
       }).then(function (response) {	
        $scope.LoadHoaDon();
          alert('Thêm chi tiết hoá đơn thành công');
       });
    };
    $scope.xoaHoaDon = function (id) {
        	
        $http({
            method: 'DELETE', 
            headers: { "Authorization": 'Bearer ' + _user.token },
         //    data: model, 
            url: current_url + '/api/HoaDonBan/delete-hoadon/' + id
        }).then(function (response) {	
            $scope.LoadHoaDon();
           alert('Xoá hoá đơn thành công');
        });
    };
    $scope.TimKiem = function (ten) {
        
        $http({
            method: 'GET',
            headers: { "Authorization": 'Bearer ' + _user.token },
            // data: model,
            url: current_url + '/api/HoaDonBan/timkiem/' + ten,
            
        }).then(function (response) {
            
            $scope.listHoaDon = response.data;
            makeScript('js/main.js')
            alert('Thành công')
        });
        }
    $scope.xoaChiTiet = function (id) {
        	
        $http({
            method: 'DELETE', 
            headers: { "Authorization": 'Bearer ' + _user.token },
         //    data: model, 
            url: current_url + '/api/HoaDonBan-chitiet/' + id
        }).then(function (response) {	
            $scope.LoadHoaDon();
           alert('Xoá chi tiết hoá đơn thành công');
        });
    };
    
   $scope.loadList = function (item) {
        $scope.list = JSON.parse(localStorage.getItem('car'));
   };

   $scope.editHoaDon = function () {
    let model = {
        soHoaDon: $scope.soHoaDon,
        ngayBan: $scope.ngayBan,
          
        maKhachHang: $scope.maKhachHang
    }
   $http({
       method: 'POST', 
       headers: { "Authorization": 'Bearer ' + _user.token },
       data: model, 
       url: current_url + '/api/HoaDonBan/update-hoadon'
   }).then(function (response) {	
      $scope.LoadHoaDon();
      alert('Sửa hoá đơn thành công');
      
   });
    };

    $scope.editChiTiet = function () {
        let model = {
            maChiTietHoaDonBan:$scope.maChiTietHoaDonBan,
            soHoaDon: $scope.soHoaDon,
            sanp_id: $scope.sanp_id,
            soLuong: $scope.soLuong,
            giaBan: $scope.giaBan

        }
       $http({
           method: 'POST', 
           headers: { "Authorization": 'Bearer ' + _user.token },
           data: model, 
           url: current_url + '/api/HoaDonBan/update-chitiet'
       }).then(function (response) {	
        $scope.LoadHoaDon();
          alert('Sửa chi tiết hoá đơn thành công');
          
       });
        };
    $scope.listHoaDon
    $scope.LoadHoaDon = function () {
    $http({
        method: 'GET',
        headers: { "Authorization": 'Bearer ' + _user.token },
        url: current_url + '/api/HoaDonBan/get-all-data/15',
    }).then(function (response) {
        $scope.listHoaDon = response.data;
        makeScript('js/main.js')
    });
    };
    $scope.LoadHoaDon();
   $scope.loadList();
    
});