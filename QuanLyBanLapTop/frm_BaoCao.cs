﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanLapTop
{
    public partial class frm_BaoCao : Form
    {
        public frm_BaoCao()
        {
            InitializeComponent();
        }

        private void frm_BaoCao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
