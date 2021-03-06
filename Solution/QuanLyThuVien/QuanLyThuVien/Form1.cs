﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frm_Start : Form
    {
        public frm_Start()
        {
            InitializeComponent();
            butHuongDan.Enabled = butBanDoc.Enabled = butNXB.Enabled = butPhieuMuon.Enabled = butSach.Enabled = true;
            butHuongDan.Visible = butBanDoc.Visible = butNXB.Visible = butPhieuMuon.Visible = butSach.Visible = true;
        }

        private void butBanDoc_Click(object sender, EventArgs e)
        {
            BanDoc frm = new BanDoc();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butSach_Click(object sender, EventArgs e)
        {
            Sach frm = new Sach();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }

        private void butNXB_Click(object sender, EventArgs e)
        {
               NXBTL frm = new NXBTL();
               frm.ShowDialog();
               frm.Close();
               frm.Dispose();
          }

        private void butPhieuMuon_Click(object sender, EventArgs e)
        {
            PhieuMuon frm = new PhieuMuon();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }
        


        private void butHuongDan_Click(object sender, EventArgs e)
        {

        }

    }
}
