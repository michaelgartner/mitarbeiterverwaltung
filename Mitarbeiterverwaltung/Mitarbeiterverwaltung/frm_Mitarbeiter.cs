﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeiterverwaltung
{
    public partial class frm_Mitarbeiter : Form
    {
        public string username { get; set; }
        private void frm_Mitarbeiter_Load(object sender, EventArgs e)
        {
            this.Text = this.username;
        }

        public frm_Mitarbeiter()
        {
            InitializeComponent();
        }

        private void btn_Schliessen_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frm_Mitarbeiter_Load_1(object sender, EventArgs e)
        {
            team05Entities me = new team05Entities();
            Mitarbeiter ma = new Mitarbeiter();

            lbl_Name.Text = me.Mitarbeiter.FirstOrDefault(c => c.Benutzername == username).Name + " " + me.Mitarbeiter.FirstOrDefault(c => c.Benutzername == username).Vorname;
        }
    }
}
