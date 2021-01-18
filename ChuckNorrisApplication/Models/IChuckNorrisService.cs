using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorrisApplication.Models
{
    public interface IChuckNorrisService
    {
        Task<ChuckNorris> GetNorris();
    }
}
