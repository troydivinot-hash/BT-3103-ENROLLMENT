namespace EventDriven.Project.Model
{
    public class AccountModel
    {
       public int Id { get; set; }
        public decimal Balance { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ClientModel ClientModel { get; set; }
    }
}
