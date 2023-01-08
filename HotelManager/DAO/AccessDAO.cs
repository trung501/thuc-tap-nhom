using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAO
{
    class AccessDAO
    {
        #region Properties
        private static AccessDAO instance = new AccessDAO();
        internal static AccessDAO Instance { get => instance; }
        private AccessDAO() { }
        #endregion

        public DataTable GetFullAccessNow(int idStaffType)
        {
            string query = "USP_LoadFullAccessNow @idStaffType";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idStaffType });
        }
        public DataTable GetFullAccessRest(int idStaffType)
        {
            string query = "USP_LoadFullAccessRest @idStaffType";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idStaffType });
        }

    }
}
