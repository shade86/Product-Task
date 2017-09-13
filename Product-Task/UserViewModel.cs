using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Task
{
    public class User : BaseModel
    {
   public string Password { get; set; }
        public string Username { get; set; }





        int _money;
        public int Money
        {
            get { return _money; }
            set
            {
                _money = value;
                OnPropertyChange();
            }
        }
    }
}
