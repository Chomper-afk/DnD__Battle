﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Battle {
    public partial class Info : Form {
        private ICreature Subject;
        public Info(ICreature _subject) {
            InitializeComponent();
            Subject = _subject;
        }

        private void Info_Load(object sender, EventArgs e) {
            TB_Name.Text = Subject.Name;
        }
    }
}
