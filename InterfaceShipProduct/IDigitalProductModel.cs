using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //It is better to inherit IProductModel to IDigitalProduct Interface rather than
    //to multiple inherit them both to DigitalProductModel, because whoever inherits IDigitalProductModel
    //will also get all the interface of ProductModel
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
