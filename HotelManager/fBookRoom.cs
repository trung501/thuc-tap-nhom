using HotelManager.DAO;
using HotelManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class fBookRoom : Form
    {
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbIDCardSearch.Text != String.Empty)
            {
                if (IsIdCardExists(txbIDCardSearch.Text))
                    GetInfoByIdCard(txbIDCardSearch.Text);
                else
                    MessageBox.Show("Thẻ căn cước/ CMND không tồn tại.\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đặt phòng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txbIDCard.Text != String.Empty && txbFullName.Text != String.Empty && txbAddress.Text != String.Empty && txbPhoneNumber.Text != String.Empty && cbNationality.Text != String.Empty)
                {
                    if (!IsIdCardExists(txbIDCard.Text))
                    {
                        int idCustomerType = (cbCustomerType.SelectedItem as CustomerType).Id;
                        InsertCustomer(txbIDCard.Text, txbFullName.Text, idCustomerType, dpkDateOfBirth.Value, txbAddress.Text, int.Parse(txbPhoneNumber.Text), cbSex.Text, cbNationality.Text);
                    }
                    InsertBookRoom(CustomerDAO.Instance.GetInfoByIdCard(txbIDCard.Text).Id, (cbRoomType.SelectedItem as RoomType).Id, dpkDateCheckIn.Value, dpkDateCheckOut.Value, DateTime.Now);
                    MessageBox.Show("Đặt phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    LoadListBookRoom();
                    if (bunifuCheckbox1.Checked)
                    {
                        this.Hide();
                        fReceiveRoom fReceiveRoom = new fReceiveRoom(GetCurrentIDBookRoom(DateTime.Now.Date));
                        fReceiveRoom.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnClose__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            int idBookRoom = (int)dataGridViewBookRoom.SelectedRows[0].Cells[0].Value;
            string idCard = dataGridViewBookRoom.SelectedRows[0].Cells[2].Value.ToString();
            fBookRoomDetails f = new fBookRoomDetails(idBookRoom, idCard);
            f.ShowDialog();
            Show();
            LoadListBookRoom();
        }
    }
}
