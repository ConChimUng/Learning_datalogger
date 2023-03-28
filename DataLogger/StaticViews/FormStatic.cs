using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLogger.StaticViews
{
    public partial class FormStatic : Form
    {
        #region
        public static FormStatic _Instance = null;
        public static FormStatic Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormStatic();
                }
                return _Instance;
            }
        }


        #endregion
        public FormStatic()
        {
            InitializeComponent();
        }
    }
}
