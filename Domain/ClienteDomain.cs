using Database;
using Entidad.ClienteEntidad.Request;
using Entidad.ClienteEntidad.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ClienteDomain
    {
        #region [Properties]
        private readonly ClienteDatabase oClienteDatabase = null;
        #endregion

        #region [Constructor]
        /// <summary>
        /// Constructor
        /// </summary>
        public ClienteDomain()
        {
            oClienteDatabase = new ClienteDatabase();
        }
        #endregion

        #region [Methods]

        public int AddCliente(AddClienteRequest entidad)
        {
            int response = 0;

            try
            {
                var dataResponse = oClienteDatabase.AddCliente(entidad);
                response = dataResponse;
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            return response;
        }

        public int UpdateCliente(UpdateClienteRequest entidad)
        {
            int response = 0;

            try
            {
                var dataResponse = oClienteDatabase.UpdateCliente(entidad);
                response = dataResponse;
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            return response;
        }

        public int DeleteCliente(int pIdCliente)
        {
            int response = 0;

            try
            {
                var dataResponse = oClienteDatabase.DeleteCliente(pIdCliente);
                response = dataResponse;
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            return response;
        }

        public List<ClienteResponse> GetClientes()
        {
            List<ClienteResponse> listResponse = null;

            try
            {
                var response = oClienteDatabase.GetClientes();
                listResponse = response;
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            return listResponse;
        }

        public ClienteResponse GetClienteById(int pIdCliente)
        {
            ClienteResponse response = null;

            try
            {
                response = oClienteDatabase.GetClienteById(pIdCliente);
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }

            return response;
        }

        #endregion
    }
}
