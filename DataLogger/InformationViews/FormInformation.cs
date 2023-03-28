using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLogger.InformationViews
{
    public partial class FormInformation : Form
    {
        #region 
        public static FormInformation _Instance = null;
        public static FormInformation Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormInformation();
                }
                return _Instance;
            }
        }
        #endregion
        public FormInformation()
        {
            InitializeComponent();
        }
    }
}
