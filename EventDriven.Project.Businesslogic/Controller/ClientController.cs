using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class ClientController
    {
        private ClientRepository clientRepo;


        public ClientController()
        {
            clientRepo = new ClientRepository();
        }

        public int Add(ClientModel model)
        {
            if (model == null) throw new Exception("missing parameter");

            try
            {

                return clientRepo.Insert(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClientModel> GetAll()
        {

            try
            {
                return clientRepo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClientModel GetById(int id)
        {
            if (id == 0) throw new Exception("missing parameter");
            try
            {

                return clientRepo.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    
}
