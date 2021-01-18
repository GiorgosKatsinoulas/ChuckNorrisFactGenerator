using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorrisApplication.Models
{
    public interface IChuckNorrisRepository
    {
        public ChuckNorris GetChuckNorris();

        public IEnumerable<ChuckNorris> GetAllChuckNorris();

        public ChuckNorris Add(ChuckNorris chuckNorris);

        public ChuckNorris DeleteChuckNorris(string id);

        public ChuckNorris DeleteAllData(ChuckNorris chuckNorris);

        public Boolean CheckIfExists(ChuckNorris chuckNorris);
    }
}
