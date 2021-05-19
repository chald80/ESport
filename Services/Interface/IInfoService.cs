using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESport.Model;

namespace ESport.Services.Interface
{
    public interface IInfoService
    {
        IEnumerable<Info> GetInfos();
        void AddInfo(Info info);
        void DeleteInfo(Info info);
        Info GetInfo(int id);
        public void EditInfo(Info info);

    }
}
