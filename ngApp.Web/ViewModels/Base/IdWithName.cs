using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngApp.Web.ViewModels.Base
{
    public class IdWithName
    {
        public IdWithName() { }
        public IdWithName(long id, string name) {
            Id = id;
            Name = name;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long CountNr { get; set; }
    }

    public class IdWithNameAndCode : IdWithName
    {
        public IdWithNameAndCode() { }
        public IdWithNameAndCode(long id, string name, string code) : base(id, name)
        {
            Code = code;
        }
        
        public string Code { get; set; }
    }

}
