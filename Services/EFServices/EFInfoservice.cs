using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;
using ESport.Services.Interface;

namespace ESport.Services.EFServices
{
    public class EFInfoservice : IInfoService
    {
        ESportContext context;
        public EFInfoservice(ESportContext service)
        {
            context = service;
        }
        public IEnumerable<Info> GetInfos()
        {
            return context.Infos;
        }

        public void AddInfo(Info info)
        {
            context.Infos.Add(info);
            context.SaveChanges();
        }

        public void DeleteInfo(Info info)
        {
            context.Infos.Remove(info);
            context.SaveChanges();
        }

        public Info GetInfo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
