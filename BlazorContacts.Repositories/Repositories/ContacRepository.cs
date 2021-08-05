using BlazorContacts.Web.Shared.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BlazorContacts.Repositories.Repositories
{
    public class ContacRepository : IContacRepository
    {
        private readonly IDbConnection _dbConnection;

        public ContacRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task DeleteContact(int id)
        {
            var sql = @"DELETE FROM TblContacts 
                        WHERE Id = @Id";

            var result = await _dbConnection.ExecuteAsync(sql, new { Id = id });
        }

        public async Task<IEnumerable<Contacts>> GetAll()
        {
            var sql = @" SELECT Id
                                ,FirstName
                                ,LastName
                                ,Phone
                                ,Address
                        FROM TblContacts ";

            return await _dbConnection.QueryAsync<Contacts>(sql, new { });
        }

        public async Task<Contacts> GetDetails(int id)
        {
            var sql = @" SELECT Id
                                ,FirstName
                                ,LastName
                                ,Phone
                                ,Address
                        FROM TblContacts
                        WHERE Id = @Id ";

            return await _dbConnection.QueryFirstOrDefaultAsync<Contacts>(
                sql, new { Id = id });
        }

        public async Task<bool> InsertContact(Contacts contact)
        {
            try
            {
                var sql = @" INSERT INTO TblContacts (FirstName, LastName, Phone, Address)
                             VALUES(@FirstName, @LastName, @Phone, @Address)";

                var result = await _dbConnection.ExecuteAsync(
                    sql, new
                    {
                        contact.FirstName,
                        contact.LastName,
                        contact.Phone,
                        contact.Address
                    });

                return result > 0;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<bool> UpdateContact(Contacts contact)
        {
            try
            {
                var sql = @" UPDATE TblContacts
                                SET FirstName = @FirstName,
                                    LastName = @LastName, 
                                    Phone = @Phone, 
                                    Address = @Address
                              WHERE Id = @Id ";

                var result = await _dbConnection.ExecuteAsync(
                    sql, new
                    {
                        contact.FirstName,
                        contact.LastName,
                        contact.Phone,
                        contact.Address,
                        contact.Id
                    });

                return result > 0;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
