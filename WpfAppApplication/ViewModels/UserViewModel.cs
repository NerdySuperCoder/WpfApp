using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppApplication.ViewModels
{
    class UserViewModel
    {
        public IEnumerable<Models.UserEntity> Users { get {
                return new List<Models.UserEntity>() {
                    new Models.UserEntity(){ FirstName="Ela",LastName="Venugopal", Age=33, Location="Melbourne"},
                    new Models.UserEntity(){ FirstName="Raji",LastName="Ramkumar", Age=32, Location="Melbourne"},
                    new Models.UserEntity(){ FirstName="Arjun",LastName="Elamathi", Age=1, Location="Melbourne"}
                };
            } }

    }
}
