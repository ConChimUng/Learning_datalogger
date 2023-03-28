using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLogger.SettingViews
{
    public partial class MachineDisplaySetting : UserControl
    {
        public string MachineName;

        public MachineDisplaySetting()
        {
            InitializeComponent();
        }
        public void SetNameSetting(string nameMachine)
        {
            this.MachineName= nameMachine;
            this.lblMachineNameSetting.Text = nameMachine;
        }
    }
}
