<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LienHe.ascx.cs" Inherits="DeTaiQuanLyBanHang.cms.TrangBanHang.LienHe.LienHe" %>
<div class="about-page" style="background:#ffffff;">
<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3835.5683112708093!2d108.21305711485745!3d15.983904588933743!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31421a6794f3ac77%3A0xdc3bcde0edf4ddc3!2zNDIgQ-G7lSBNw6JuIExhbiAyLCBIw7JhIFh1w6JuLCBD4bqpbSBM4buHLCDEkMOgIE7hurVuZw!5e0!3m2!1svi!2s!4v1520160145670" width="100%" height="350" frameborder="0" style="border:0" allowfullscreen></iframe> <div class="ct-left">
    	<div style="float:left; margin:10px;">
            <h2 style="color:#5aba31">Thông tin phản hồi</h2>
        <div class="success" style="border:1px solid #ff0000; text-align:center">Xin vui lòng điền các yêu cầu vào mẫu dưới đây.<p> Chúng tôi sẽ trả lời bạn ngay sau khi nhận được.</p>
Xin chân thành cảm ơn!</div>

		<form action="#" method="post">
        	<table>
            	<tr>
                	<td class="left">Họ tên</td>
                    <td><input type="text" name="hoten" placeholder="Họ tên" value=""style="width:300px; border-radius:4px; padding:4px;"/></td>
                </tr>
                <tr>
                	<td class="left">SĐT</td>
                    <td><input type="text" name="sdt" placeholder="Số điện thoại" value=""style="width:300px; border-radius:4px; padding:4px;"/></td>
                </tr>
                <tr>
                	<td class="left">Email</td>
                    <td><input type="text" name="email" placeholder="Thư điện tử" value=""style="width:300px; border-radius:4px; padding:4px;"/></td>
                </tr>
                <tr>
                	<td class="left">Chủ đề</td>
                    <td><input type="text" name="chude" placeholder="Chủ đề" value=""style="width:300px; border-radius:4px; padding:4px;"/></td>
                </tr>
                <Tr>
                	<td class="left">Nội dung</td>
                    <td><textarea name="noidung" rows="10" style="width:300px; border-radius:4px; padding:4px;"></textarea></td>
                </Tr>
                <tr>
                    <td><img src="captcha.php"></td>
                    <td><input type="text" name="captcha" id="captcha" maxlength="6" required placeholder="Nhập mã kiểm tra"style="width:300px; border-radius:4px; padding:4px;"></td>
                </tr>
                <tr>
                	<td></td>
                	<td><input type="submit" class="btn-contact" name="ok" value="Gửi" style="padding:5px; background:#808080; width:100px"/></td>
                </tr>
            </table>
        </form>
    	</div>
<div class="thongbao"></div>
    </div>
    <div class="ct-right" style="margin:10px;">
    	<h2 style="color:#5aba31">Liên hệ</h2>
        <p class="bold-uppercase">Công ty TNHH MTV VLXD Kiên Cường</p>
        <p><i class="fa fa-street-view"></i>
            <img src="../../../pic/address.png" style="width:20px; height:auto"/> Địa chỉ Kho: Ngã ba Trần Nam Trung - Phan Thao, Q. Cẩm Lệ, TP. Đà Nẵng.</p>
		<p><i class="fa fa-street-view"></i><img src="../../../pic/room.png" style="width:20px; height:auto"/> Văn Phòng: 42 Cổ Mân Lan 2, Phường Hòa Xuân, Q. Cẩm Lệ, TP. Đà Nẵng</p>
        <p><i class="fa fa-phone"></i> 0236.6505.999</p>
        <p><i class="fa fa-mobile"></i><img src="../../../pic/callphone.jpg" style="width:20px; height:auto"/>0935.91.1979 - 0986.91.1979</p>
        <p><i class="fa fa-envelope"></i> Kiencuong@vatlieuxaydungdanang.com.vn</p>
    </div>
    <div class="clear"></div>
</div>
