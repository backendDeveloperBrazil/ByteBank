using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class BusinessPartner : IAuthenticatable
    {
        public string Senha { get; set; }
        public bool Authenticate(string senha)
        {
            return Senha == senha;
        }
    }
}
