using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLogger.AccountViews
{
    public partial class FormAccount : Form
    {
        #region 
        public static FormAccount _Instance = null;
        public static FormAccount Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormAccount ();
                }    
                return _Instance;
            }
        }

        #endregion
        public FormAccount()
        {
            InitializeComponent();
        }
    }
}
