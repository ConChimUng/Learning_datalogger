using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataLogger.Form1;

namespace DataLogger
{
    public partial class Form1 : Form
    {
        public Form CurrentForm;
        public enum AppModulSupport
        {
            Datalogger_Dashboard,
            Datalogger_Historical,
            Datalogger_Statics,
            Datalogger_Setting,
            Datalogger_Account,
            Datalogger_Information,
        }
        public Form1()
        {
            InitializeComponent();
        }

        public void OpenChildForm(AppModulSupport modulSupport, Form ChildForm)
        {
            bool Is_same_form = false;
            if (this.panelDesktopMain.Tag != null)
            {
                if (this.panelDesktopMain.Tag is Tuple<AppModulSupport, Form>)
                {
                    Tuple<AppModulSupport, Form> TagAsForm = (Tuple<AppModulSupport, Form>)(this.panelDesktopMain.Tag);
                    if (TagAsForm.Item1 == modulSupport)
                    {
                        Is_same_form = true;
                    }

                }
            }
            if (Is_same_form == false) 
            {
                if(CurrentForm != null)
                {
                    CurrentForm.Visible = false;
                     
                }
                this.panelDesktopMain.Tag = Tuple.Create(modulSupport, ChildForm);
                CurrentForm = ChildForm;
                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                ChildForm.BringToFront();
                this.panelDesktopMain.Controls.Add(ChildForm);
                ChildForm.Show();
            }
            else
            {
                //do not 
            }
        }

        private void btDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(AppModulSupport.Datalogger_Dashboard, DataLogger.DashboardViews.FormDashboard.Instance);

        }

        private void btHistorical_Click(object sender, EventArgs e)
        {
            OpenChildForm(AppModulSupport.Datalogger_Historical, DataLogger.HistoricalViews.FormHistical.Instance);
        }

        private void btStatics_Click(object sender, EventArgs e)
        {
            OpenChildForm(AppModulSupport.Datalogger_Statics, DataLogger.StaticViews.FormStatic.Instance);
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(AppModulSupport.Datalogger_Setting, DataLogger.SettingViews.FormSetting.Instance);
        }

        private void btInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(AppModulSupport.Datalogger_Information,DataLogger.InformationViews.FormInformation.Instance);
        }
    }
}
