using Data.SmartAppt.SQL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Data.SmartAppt.SQL.Services.Implementation
{
    public class BusinessRepository : IBusinessRepository
    {

        public int count {  get; set; } 
        public static string ConnectionString =
           "Server=localhost;Database=SmartAppt;Trusted_Connection=True;TrustServerCertificate=True;";

        private static object DbNullIfNull(object? value) => value ?? DBNull.Value;

        // core.Business_Create
        public async virtual Task<int?> CreateAsync(BusinessEntity data)
        {
            count++;

            int? identity = null;
            try
            {
                using var cn = new SqlConnection(ConnectionString);
                await cn.OpenAsync();
                using var cmd = new SqlCommand("core.Business_Create", cn)
                { CommandType = CommandType.StoredProcedure };

                // Prefer explicit types/sizes over AddWithValue for best perf
                cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 200) { Value = data.Name });
                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 320) { Value = DbNullIfNull(data.Email) });
                cmd.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 50) { Value = DbNullIfNull(data.Phone) });
                cmd.Parameters.Add(new SqlParameter("@TimeZoneIana", SqlDbType.NVarChar, 100) { Value = DbNullIfNull(data.TimeZoneIana) });
                cmd.Parameters.Add(new SqlParameter("@SettingsJson", SqlDbType.NVarChar, -1) { Value = DbNullIfNull(data.SettingsJson) });

                SqlParameter res = new SqlParameter("@BusinessId", SqlDbType.Int) { Direction = ParameterDirection.Output };                              
                cmd.Parameters.Add(res);

                await cmd.ExecuteNonQueryAsync();

                identity = Convert.ToInt32(res.Value);

            }
            catch (Exception ex)
            {
                // write log
            }
            return identity;
        }



    }
}
