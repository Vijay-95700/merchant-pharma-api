using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmacyCollege.Infrastructure.IRepository;

namespace PharmacyCollege.Infrastructure.Repository
{
    public class PharmaRepository<T> : IPharmaRepository<T> where T : class
    {

    }
}
