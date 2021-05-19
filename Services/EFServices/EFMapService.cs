using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;

namespace ESport.Services.EFServices
{
    public class EFMapService : IMapService
    {
        ESportContext context;
        public EFMapService(ESportContext service)
        {
            context = service;
        }
        public IEnumerable<Map> GetMaps()
        {
            return context.Maps;
        }

        public void AddMaps(Map map)
        {
            context.Maps.Add(map);
            context.SaveChanges();
        }

        public void DeleteMap(Map map)
        {
            context.Maps.Remove(map);
            context.SaveChanges();
        }

        public Map GetMap(int id)
        {
            var map = context.Maps.FirstOrDefault(m => m.MapsId == id);
            return map;
        }

        public void EditMap(Map map)
        {
            context.Maps.Update(map);
            context.SaveChanges();
        }
    }
}
