using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class CourseGroupClient
    {
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }

        public int CourseGroupId { get; set; }

        public virtual CourseGroup CourseGroup { get; set; }
    }
}
