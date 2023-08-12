
            function  addToCart(item) {
                 item.quantity = 1;
                 console.log(item.quantity);
                 var list;
                 if (localStorage.getItem('car') == null) {
                     list = [item];
                 } 
                 else 
                 {
                     list = JSON.parse(localStorage.getItem('car')) || [];
                     let ok = true;
                     for (let x of list) 
                     {
                         if (x.id == item.id) 
                         {
                            x.quantity += 1;
                            ok = false;
                            break;
                         }
                    }
                    if(ok)
                    {
                     list.push(item); 
                    } 
                 }
                 localStorage.setItem('car', JSON.stringify(list));
                 
                 alert("Đã thêm giở hàng thành công");
             }
