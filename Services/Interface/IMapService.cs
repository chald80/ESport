using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;

namespace ESport.Services.Interface
{
    public interface IMapService
    {
        IEnumerable<Map> GetMaps();
        void AddMaps(Map map);
        void DeleteGame(Map map);
        Map GetMap(int id);
        public void EditMap(Map map);

    }
}
