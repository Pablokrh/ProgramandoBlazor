using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiNcapas.Entities
{
    public interface IUserRepository
    {
        User CreateUser(User user);
    }
}
