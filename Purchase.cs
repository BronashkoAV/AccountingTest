using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AccountingTest
{
    public class Purchase
    {
        public Purchase(DateTime dateBuy, string category, decimal cost, string comment = "")
        {
            _category = category;
            _cost = cost;
            _dateBuy = dateBuy;
            _comment = comment;
        }
        #region "Id"
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = Id;
            }
        }
        #endregion

        #region "DateBuy"
        private DateTime _dateBuy;
        public DateTime DateBuy
        {
            get
            {
                return _dateBuy;
            }
            set
            {
                _dateBuy = DateBuy;
            }
        }
        #endregion

        #region "Category"
        private string _category;
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = Category;
            }
        }
        #endregion

        #region "Cost"
        private decimal _cost;
        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = Cost;
            }
        }
        #endregion

        #region "Comment"
        private string _comment;
        public string Comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = Comment;
            }
        }
        #endregion
    }
}
