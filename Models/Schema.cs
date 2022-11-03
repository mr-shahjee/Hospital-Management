using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCrud.Models
{
    public class Schema
    {
        public int schemaId {get; set;}
        public string schemaName {get; set;}
        public string jsonSchema {get; set;}
    }
}