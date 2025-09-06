using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class ClientAccountController
    {
        private ClientAccountRepository clientAccountRepository;


        public ClientAccountController()
        {
            clientAccountRepository = new ClientAccountRepository();
        }

        public void Add(AccountModel model)
        {
            if (model == null) throw new Exception("missing parameter");

            try
            {

                clientAccountRepository.CreateClient(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(AccountModel model)
        {
            if (model == null) throw new Exception("missing parameter");

            try
            {

                clientAccountRepository.UpdateClient(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            if (id == 0) throw new Exception("missing parameter");

            try
            {

                clientAccountRepository.DeleteClient(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AccountModel> GetAll()
        {

            try
            {
                return clientAccountRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AccountModel GetById(int id)
        {
            if (id == 0) throw new Exception("missing parameter");
            try
            {

                return clientAccountRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
