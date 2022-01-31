using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Models
{
    public class Test
    {
        public static void Init(HotelsContext context)
        {
            if (!context.Hotels.Any())
            {
                context.Hotels.AddRange(
                    new Hotel
                    {
                        Title = "Premier Palace Hotel",
                        Img = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/307568869.jpg?k=3f69354fa988f08f5bf1bc675b5cb78a8209f4f9991c39cc66573f17a8e73f2e&o=&hp=1",
                        Contry = "Ukraine",
                        Stars = 5,
                        Price = 2000
                    },
                    new Hotel
                    {
                        Title = "Opera Hotel",
                        Img = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/13590117.jpg?k=e4abe16cc9f769b1283742396fbf31b15c39fce14866088e31e09a84c41bd56f&o=&hp=1",
                        Contry = "Ukraine",
                        Stars = 5,
                        Price = 1800
                    },
                    new Hotel
                    {
                        Title = "Rehana Royal Beach",
                        Img = "https://img.poehalisnami.ua/static/hotels/egipet/sharm-el-shejjkh/h7187/orig/o3477017187_637723119321962319.jpg",
                        Contry = "Egypt",
                        Stars = 5,
                        Price = 1000
                    },
                    new Hotel
                    {
                        Title = "Concorde El Salam Front Area",
                        Img = "https://img.poehalisnami.ua/static/hotels/egipet/sharm-el-shejjkh/h87/orig/booking87_187_637729299887861459.jpg",
                        Contry = "Egypt",
                        Stars = 5,
                        Price = 1100
                    },
                    new Hotel
                    {
                        Title = "Loews Santa Monica Beach Hotel",
                        Img = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/310869476.jpg?k=ef7aa3a94bdf1fb02c12bea689573025f26b745df4b1f3ae5a05ee798694ba7c&o=&hp=1",
                        Contry = "USA",
                        Stars = 5,
                        Price = 5000
                    }
                    );
            }
        }
    }
}
