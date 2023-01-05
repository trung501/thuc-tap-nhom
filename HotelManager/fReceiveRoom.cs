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
    
    public partial class fReceiveRoom : Form
    {
        List<int> ListIDCustomer = new List<int>();
        int IDBookRoom = -1;
        DateTime dateCheckIn;
        public fReceiveRoom(int idBookRoom)
        {
            IDBookRoom = idBookRoom;
            InitializeComponent();
            LoadData();
            ShowBookRoomInfo(IDBookRoom);
        }
        public fReceiveRoom()
        {
            InitializeComponent();
            LoadData();

        }
        public void LoadData()
        {
            LoadListRoomType();
            LoadReceiveRoomInfo();
        }
        public void LoadListRoomType()
        {
            List<RoomType> rooms = RoomTypeDAO.Instance.LoadListRoomType();
            cbRoomType.DataSource = rooms;
            cbRoomType.DisplayMember = "Name";
        }
        public void LoadEmptyRoom(int idRoomType)
        {
            List<Room> rooms = RoomDAO.Instance.LoadEmptyRoom(idRoomType);
            cbRoom.DataSource = rooms;
            cbRoom.DisplayMember = "Name";
        }
        public bool IsIDBookRoomExists(int idBookRoom)
        {
            return BookRoomDAO.Instance.IsIDBookRoomExists(idBookRoom);
        }
        public void ShowBookRoomInfo(int idBookRoom)
        {
            DataRow dataRow = BookRoomDAO.Instance.ShowBookRoomInfo(idBookRoom);
            txbFullName.Text = dataRow["FullName"].ToString();
            txbIDCard.Text = dataRow["IDCard"].ToString();
            txbRoomTypeName.Text = dataRow["RoomTypeName"].ToString();
            cbRoomType.Text = dataRow["RoomTypeName"].ToString();//*
            txbDateCheckIn.Text = dataRow["DateCheckIn"].ToString().Split(' ')[0];
            dateCheckIn = (DateTime)dataRow["DateCheckIn"];
            txbDateCheckOut.Text = dataRow["DateCheckOut"].ToString().Split(' ')[0];
            txbAmountPeople.Text = dataRow["LimitPerson"].ToString();
            txbPrice.Text = dataRow["Price"].ToString();
        }
    }

}
