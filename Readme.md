# PHẦN MỀM QUẢN LÝ KHÁCH SẠN

🏨🚪🛌🛎️ Ứng dụng quản lý khách sạn sử dụng C#, SQL SERVER

![Hình ảnh demo sản phẩm](/images/mainscreen.png)

## Nội dung

* [Giới thiệu](#Thao-tác)
* [Tính năng](#Tính-năng)
* [Môi trường](#Môi-trường)
* [Cài đặt](#Cài-đặt)
* [Thao tác](#Thao-tác)
* [Tài liệu tham khảo](#Tài-liệu-tham-khảo)
* [Bugs và các vấn đề](#Bugs-và-các-vấn-đề)
* [Ảnh chụp màn hình](#Ảnh-chụp-màn-hình)
* [Tác giả](#Tác-giả)
* [Giấy phép](#Giấy-phép)

## Giới thiệu

* Phần mềm quản lý khách sạn được thiết kế nhằm phục vụ các khachs sạn vừa và nhỏ trong quản lý trong quá trình hoạt động. Đối với các khách sạn có quy mô lớn cần sửa đổi bổ sung một số thông tin khác và cập nhật dữ liệu
* Phần mềm hỗ trợ: quản lý thông tin nhân viên, quản lý thông tin phòng, thông tin khách hàng, quản lí hóa đơn, sử dụng dịch vụ và thanh toán, quản lí các quy định, kiểm tra danh sách các phòng trống và cho phép thực hiện đặt phòng, nhận phòng, trả phòng và thanh toán.
* Ngôn ngữ: C#

## Tính năng

* Đặt phòng
* Nhận phòng
* Đặt dịch vụ
* Thanh toán và in hóa đơn
* Quản lý phòng và loại phòng
* Quản lý dịch vụ và loại dịch vụ
* Quản lý tài khoản
* Báo cáo 

## Cài đặt

**1. Tải các thành phần liên quan**

* Git clone [trung501/thuc-tap-nhom: Quản lý khách sạn (github.com)](https://github.com/trung501/thuc-tap-nhom)
* Khôi phục file backup database /Database/HotelManagement.bak

**2. Chỉnh sửa connection string**

* Mở file DAO/DataProvider.cs 
* Sửa đổi  private string connectionStr = @"Data Source=TRUNG\TRUNG;Initial Catalog=HotelManagement;Integrated Security=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
với tên server tương ứng

**3. Tài khoản đăng nhập hệ thống**

* Quản trị

  username: admin
  password: admin

* Nhân viên

  username: nhanvien
  password: nhanvien

* Lễ tân

  username: nhanviendatphong
  password: 123456\

## Môi trường

* [Visual Studio 2019](https://visualstudio.microsoft.com/fr/downloads/?rr=https%3A%2F%2Fwww.google.com.vn%2F)
* [SQL Server 2019](https://www.microsoft.com/en-us/sql-server/sql-server-2019)

## Tài liệu tham khảo

Tai liệu hỗ trợ việc sử dụng C# [documentation](https://docs.microsoft.com/en-us/dotnet/csharp/).

## Bugs và các vấn đề

Bạn có câu hỏi hoặc vấn đề với dự án? [Đặt câu hỏi](https://github.com/trung501/thuc-tap-nhom/issues) tại đây trên Github.

## Ảnh chụp màn hình

* `Đăng nhập`

![Đăng nhập](/images/login.png)

* `Đặt phòng`

![Đặt phòng](/images/datphong.png)

* `Nhận phòng`

![Nhận phòng](/images/nhanphong.png)

* `Đặt dịch vụ và thanh toán`

![Đặt dịch vụ và thanh toán](/images/dichvu-thanhtoan.png)

* `Quản lý nhân viên`

![Quản lý nhân viên](/images/nhanvien.png)

## Tính năng đang phát triển
*Thống kê doanh thu*


## Tác giả

* **Trần Bảo Trung** - [trung501 (Trung Trần) (github.com)](https://github.com/trung501)
* **Đinh Thị Thu Uyên** - [DinhUyen (github.com)](https://github.com/DinhUyen)
* **Phạm Đình Khương Duy** - [[khuongduyktqs (Khương Duy ) (github.com)](https://github.com/khuongduyktqs)](https://github.com/NguyenPhuLap3112)
* **Hồ Nguyễn Nguyên** - [HNN510 (github.com)](https://github.com/HNN510)
* **An Thanh Tú** - [ATT21072001 (github.com)](https://github.com/ATT21072001)

## Giấy phép

[MIT](https://opensource.org/licenses/MIT)
