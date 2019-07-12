﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 遥感卫星系统性能评估
{
    public partial class appSatisfyEff : Form
    {
        public appSatisfyEff()
        {
            InitializeComponent();
            dataInit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            performanceEvaluation p = (performanceEvaluation)this.Owner;
            p.scaleEff_temperEff = Convert.ToDouble(appSatisfydataGrid.Rows[0].Cells[0].Value.ToString());
            p.scaleEff_windEff = Convert.ToDouble(appSatisfydataGrid.Rows[0].Cells[1].Value.ToString());
            p.temperEff_windEff = Convert.ToDouble(appSatisfydataGrid.Rows[0].Cells[2].Value.ToString());
            this.Close();
        }
        private void dataInit()
        {
            appSatisfydataGrid.Rows[0].Cells[0].Value = "2";//
            appSatisfydataGrid.Rows[0].Cells[1].Value = "3";
            appSatisfydataGrid.Rows[0].Cells[2].Value = "4";          

        }
    }
}
