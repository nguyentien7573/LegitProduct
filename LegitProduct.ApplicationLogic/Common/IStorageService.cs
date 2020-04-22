using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LegitProduct.ApplicationLogic.Common
{
    public interface IStorageService
    {
        string GetFileUrl(string fileName);

        Task SaveFile(Stream mediaBinaryStream, string fileName);

        Task DeleteFile(string fileName);
    }
}
