using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Reports.Entitiy
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
