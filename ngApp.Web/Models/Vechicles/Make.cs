
using ngApp.Web.Interfaces.Base;
using ngApp.Web.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ngApp.Web.Models.Vechicles
{
    [Table("makes")]
    public class Make : EntityWithName
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public string HeadQuatersLocation { get; set; }
        public IList<Model> Models { get; set; }
    }
}
