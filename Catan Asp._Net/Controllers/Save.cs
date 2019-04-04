using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catan_Asp._Net.Controllers
{
    public class Save
    {
        var hashids = new Hashids("this is my salt");
        var id = hashids.Encode(1, 2, 3);
        var numbers = hashids.Decode(id);
    }
}