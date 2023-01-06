using HotelManager.DAO;
using HotelManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fBookRoomDetails : Form
    {
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            BookRoomDAO.Instance.UpdateBookRoom(idBookRoom, (cbRoomType.SelectedItem as RoomType).Id, dpkDateCheckIn.Value, dpkDateCheckOut.Value);
            MessageBox.Show("Cập nhật thông tin đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txbFullName.Text != string.Empty && txbIDCard.Text != string.Empty && txbAddress.Text != string.Empty && cbNationality.Text != string.Empty && txbPhoneNumber.Text != string.Empty)
            {
                //Kiểm tra IDCard có trùng không
                if (!IsIdCardExists(txbIDCard.Text) || txbIDCard.Text == idCard)
                {
                    UpdateCustomer();

                }
                else
                    MessageBox.Show("Thẻ căn cước/ CMND không hợp lệ.\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa khách hàng dẫn đến phiếu đặt phòng cũng bị xóa!\nBạn có muốn tiếp tục?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (BookRoomDAO.Instance.IsIDBookRoomExists(idBookRoom))
                {
                    BookRoomDAO.Instance.DeleteBookRoom(idBookRoom);
                    MessageBox.Show("Xóa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Xóa thông tin khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose__Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
