using HotelManager.DTO;
using System;
using System.Data;

namespace HotelManager.DAO
{
    public class ParameterDAO
    {
        #region Properties && constructor
        private ParameterDAO() { }

        private static ParameterDAO instance;
        internal static ParameterDAO Instance { get { if (instance == null) instance = new ParameterDAO(); return instance; } }
        #endregion

        #region Method
        internal DataTable LoadFullParameter()
        {
            return DataProvider.Instance.ExecuteQuery("USP_LoadFullParameter");
        }
        #endregion

    }
}
