using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

        private DateTime _creteDate = DateTime.Now;

        public DateTime CreateDate
        {
            get { return _creteDate; }
            set { _creteDate = value; }
        }
    }
}
