using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    enum RentStatus
    {       
        
            Success,                //Kiralama Başarılı
            Failed,                 //Kiralama Başarısız
            RoomNotFound,            //Oda Bulunamadı
            CustomerNotFound,       //Müşteri Bulunamadı
            UserNotFound,           //Kullanıcı Bulunamadı
            RoomBeenRented,          //Oda Kiralamada
            InsufficientBalance,    //Yetersiz Bakiye
            AgeLimit,                //Yaş Sınırı
        
    }
}
