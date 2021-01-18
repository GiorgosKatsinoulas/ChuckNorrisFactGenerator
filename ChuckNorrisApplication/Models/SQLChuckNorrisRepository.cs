using ChuckNorrisApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorrisApplication.Models
{
    public class SQLChuckNorrisRepository : IChuckNorrisRepository
    {
        private readonly ChuckNorrisContext _db;
        private IChuckNorrisService _chuckNorrisService;

        public SQLChuckNorrisRepository(ChuckNorrisContext db, IChuckNorrisService chuckNorrisService)
        {
            _db = db;
            _chuckNorrisService = chuckNorrisService;
        }

        public ChuckNorris Add(ChuckNorris chuckNorris)
        {
            _db.ChuckNorris.Add(chuckNorris);
            _db.SaveChanges();
            return chuckNorris;
        }
      
        public Boolean CheckIfExists(ChuckNorris chuckNorris)
        {
            
            
                chuckNorris = _db.ChuckNorris.FirstOrDefault(x => x.Id == chuckNorris.Id);
            if (chuckNorris == null)
            {
                return true;
            }


            return false ;
        }

        public ChuckNorris DeleteAllData(ChuckNorris chuckNorris)
        {
            foreach (var item in _db.ChuckNorris)
            {
                _db.ChuckNorris.Remove(item);
               
            }

            _db.SaveChanges();

            return chuckNorris;
        }

        public ChuckNorris DeleteChuckNorris(string Id)
        {
            ChuckNorris chuckNorris = _db.ChuckNorris.FirstOrDefault(x => x.Id == Id);
            if (chuckNorris!=null)
            {
                _db.ChuckNorris.Remove(chuckNorris);
                _db.SaveChanges();
            }
            return chuckNorris;
        }


        public IEnumerable<ChuckNorris> GetAllChuckNorris()
        {

            return _db.ChuckNorris.ToList();
        }

        public  ChuckNorris GetChuckNorris()
        {
            ChuckNorris chuckNorris = _chuckNorrisService.GetNorris().GetAwaiter().GetResult();
            
            return chuckNorris;
        }
    }
}
