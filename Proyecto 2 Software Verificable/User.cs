using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_Software_Verificable
{
    [Serializable]
    public class User
    {
        #region Fields
        private string name;
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        #endregion

        #region Constructors
        public User()
        {
        }
        public User(string name)
        {
            this.name = name;
        }
        #endregion
    }
}
