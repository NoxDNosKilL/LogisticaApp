using Dapper;
using Database.Configuracion;
using Entidad.ClienteEntidad.Request;
using Entidad.ClienteEntidad.Response;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Database
{
    public class ClienteDatabase
    {
        #region [Properties]
        private readonly Conexion connection = null;
        #endregion

        #region [Constructor]
        public ClienteDatabase()
        {
            connection = new Conexion();
        }
        #endregion

        #region [Methods]
        public ClienteResponse GetClienteById(int pIdCliente)
        {
            using (var cn = connection.GetConnectionLogisticaEnvios)
            {
                #region [Query]
                const string query = @"SELECT ClienteID, Nombre, Apellido, Email, Telefono, Direccion 
                               FROM Clientes 
                               WHERE ClienteID = @pIdCliente";
                #endregion

                #region [Parameters]
                var parameters = new DynamicParameters();
                parameters.Add("@pIdCliente", pIdCliente, DbType.Int32);
                #endregion

                #region [Execute]
                var response = cn.QueryFirstOrDefault<ClienteResponse>(query, parameters, commandType: CommandType.Text);
                return response;
                #endregion
            }
        }

        public List<ClienteResponse> GetClientes()
        {
            using (var cn = connection.GetConnectionLogisticaEnvios)
            {
                #region [Query]
                const string query = @"SELECT * FROM Clientes";
                #endregion

                #region [Execute]
                var response = cn.Query<ClienteResponse>(query, commandType: CommandType.Text);
                return response.ToList();
                #endregion
            }
        }

        public int AddCliente(AddClienteRequest request)
        {
            using (var cn = connection.GetConnectionLogisticaEnvios)
            {
                #region [Query]
                const string query = @"INSERT INTO Clientes (Nombre, Apellido, Email, Telefono, Direccion)
                                        VALUES (@Nombre, @Apellido, @Email, @Telefono, @Direccion)";
                #endregion

                #region [Parameters]
                var parameters = new DynamicParameters();
                parameters.Add("@Nombre", request.Nombre, DbType.String);
                parameters.Add("@Apellido", request.Apellido, DbType.String);
                parameters.Add("@Email", request.Email, DbType.String);
                parameters.Add("@Telefono", request.Telefono, DbType.String);
                parameters.Add("@Direccion", request.Direccion, DbType.String);
                #endregion

                #region [Execute]
                var response = cn.Execute(query, parameters, commandType: CommandType.Text);
                return response;
                #endregion 
            }
        }

        public int UpdateCliente(UpdateClienteRequest request)
        {
            using (var cn = connection.GetConnectionLogisticaEnvios)
            {
                #region [Query]
                const string query = @"UPDATE Clientes 
                                        SET Nombre = @Nombre,
                                            Apellido = @Apellido,
                                            Email = @Email,
                                            Telefono = @Telefono,
                                            Direccion = @Direccion
                                        WHERE ClienteID = @ClienteID";
                #endregion

                #region [Parameters]
                var parameters = new DynamicParameters();
                parameters.Add("@ClienteID", request.ClienteID, DbType.Int32);
                parameters.Add("@Nombre", request.Nombre, DbType.String);
                parameters.Add("@Apellido", request.Apellido, DbType.String);
                parameters.Add("@Email", request.Email, DbType.String);
                parameters.Add("@Telefono", request.Telefono, DbType.String);
                parameters.Add("@Direccion", request.Direccion, DbType.String);
                #endregion

                #region [Execute]
                var response = cn.Execute(query, parameters, commandType: CommandType.Text);
                return response;
                #endregion 
            }
        }

        public int DeleteCliente(int clienteID)
        {
            using (var cn = connection.GetConnectionLogisticaEnvios)
            {
                #region [Query]
                const string query = @"DELETE Clientes 
                                        WHERE ClienteID = @ClienteID";
                #endregion

                #region [Parameters]
                var parameters = new DynamicParameters();
                parameters.Add("@ClienteID", clienteID, DbType.Int32);
                #endregion

                #region [Execute]
                var response = cn.Execute(query, parameters, commandType: CommandType.Text);
                return response;
                #endregion 
            }
        }
        #endregion
    }
}