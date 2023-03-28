using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLogger.eNum;


namespace DataLogger.DashboardViews
{
  public partial class UserControlProgessBar : UserControl
  {
    /// <summary>
    /// type: phân loại usercontrol
    /// </summary>
    private eProgessBarType _eProgessBarType = eProgessBarType.Speed;
    /// <summary>
    /// Name: để hiển thị giao diện
    /// </summary>
    private string _name = string.Empty;


    // <summary>
    /// id: mã số duy nhất của usercontrol
    /// </summary>
    private int _id = 0;

    /// <summary>
    /// option: user control này thuộc nhóm nào?
    /// giống như lineId của alc 
    /// </summary>
    private int _groupId = 0;


     
    //public void SetGroupId(int groupId)
    //{
    //  //lưu lại
    //  this._groupId = groupId;
    //}
    //public void SetProgessBarType(eProgessBarType eProgessBarType)
    //{
    //  //lưu lại
    //  this._eProgessBarType = eProgessBarType;
    //}
    //public void SetName(string name)
    //{
    //  //lưu lại
    //  this._name = name;
    //  lblNameMachine.Text = name;


    //  //hiển thị ui

    //}

    //public void SetId(int id)
    //{
    //  this._id = id;
    //}


    public void SetData(int id, string name, eProgessBarType _eProgessBarType)
    {
      this._id = id;
      this._name = name;
      this._eProgessBarType = _eProgessBarType;
    }
    //---------------------------------
    public void DisplayToUi()
    {
      //this.lblNameMachine.Text = this._name;
      //this.lblNameMachine.ForeColor = Color.White;


      // vi dụ 2: hiển thị groupId + Id
      if (this._groupId == 0)
      {
        this.lblNameMachine.Text = $"{this._name}";       
      }
      else if(this._groupId == 1)
      {
        this.lblNameMachine.Text = $"{this._name}";
      }
       
      this.lblNameMachine.ForeColor = Color.White;

      //hiển thị lên ui
      switch (this._eProgessBarType)
      {
        case eProgessBarType.Speed:
          cprBar1.SuperscriptText = "spr";
          break;
        case eProgessBarType.Temperature:
          cprBar1.SuperscriptText = "oC";
          break;
        case eProgessBarType.Humidity:
          cprBar1.SuperscriptText = "Độ ẩm";
          break;
        default: break;
      }

    }













    string Namemachine;


    public void SetNameMachine(string _nameMachine)
    {
      this.Namemachine = _nameMachine;
      lblNameMachine.Text = _nameMachine;
    }

    public UserControlProgessBar()
    {
      InitializeComponent();
    }

    public void ChangeValue(int data)
    {
      cprBar1.Text = data.ToString();
      cprBar1.Value = data;
    }

  }
}
