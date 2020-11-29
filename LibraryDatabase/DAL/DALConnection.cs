﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALConnection
    {
        private String _stringConnection;
        private SqlConnection _connection;
        private SqlTransaction _transaction;

        public DALConnection (String dataConnection)
        {
            this._connection = new SqlConnection();
            this.StringConexao = dataConnection;
            this._connection.ConnectionString = dataConnection;
        }

        public SqlTransaction TransactionObject
        {
            get { return this._transaction; }
            set { this._transaction = value; }
        }

        public void StartTransaction()
        {
            this._transaction = _connection.BeginTransaction();
        }

        public void EndTransaction()
        {
            this._transaction.Commit();
        }

        public void CancelTransaction()
        {
            this._transaction.Rollback();
        }

        public String StringConnection
        {
            get { return this._stringConnection; }
            set { this._stringConnection = value; }
        }

        public SqlConnection ConnectionObject
        {
            get { return this._connection; }
            set { this._connection = value; }
        }

        public void Connect()
        {
            this._connection.Open();
        }

        public void Disconnect()
        {
            this._connection.Close();
        }
    }
}