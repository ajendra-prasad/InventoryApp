using InventoryApp.Models;
using InventoryApp.Repository;

namespace InventoryApp.Services
{
    public class AuthenticationService
    {
        private readonly AuthenticationRepository _repository;

        public AuthenticationService()
        {
            _repository = new AuthenticationRepository();
        }

        public bool AuthorizeUser(User user)
        {
            return _repository.AuthorizeUser(user);
        }
    }
}
