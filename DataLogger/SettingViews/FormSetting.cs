using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLogger.SettingViews
{
    public partial class FormSetting : Form
    {
        public static FormSetting _Instance = null;
        public static FormSetting Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FormSetting();
                }
                return _Instance;
            }
        }
        public FormSetting()
        {
            InitializeComponent();
            this.Load += FormSetting_Load;
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            CreateUserControls(5);
        }

        public string[] NameMachine = { "Nhiet do", "Do rung", "Toc do", "Tu truong", "Do am" };
        public void CreateUserControls(int NumberMachine)
        {
            
            flpSetting.Controls.Clear();
            for (int i = 0; i < NumberMachine; i++)
            {
                MachineDisplaySetting machineDisplaySetting1 = new DataLogger.SettingViews.MachineDisplaySetting();
                machineDisplaySetting1.BackColor = System.Drawing.Color.Navy;
                machineDisplaySetting1.Location = new System.Drawing.Point(3, 3);
                machineDisplaySetting1.Name = $"machineDisplaySetting{i+1}";
                machineDisplaySetting1.Size = new System.Drawing.Size(571, 159);
                machineDisplaySetting1.TabIndex = 0;
                machineDisplaySetting1.SetNameSetting(NameMachine[i]);
                this.flpSetting.Controls.Add(machineDisplaySetting1);
            }


        }
    }
}
