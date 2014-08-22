﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Vocals {
    public partial class FormAction : Form {
        Keys[] keyDataSource;

        public float selectedTimer { get; set; }

        public Keys selectedKey { get; set; }

        public string selectedType { get; set; }
        
        public FormAction() {

            InitializeComponent();

            keyDataSource = (Keys[])Enum.GetValues(typeof(Keys)).Cast<Keys>();
            comboBox2.DataSource = keyDataSource;
          
            comboBox1.DataSource = new string[]{"Key press","Timer"};

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = 0.1M;
        }

        private void FormAction_Load(object sender, System.EventArgs e) {
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            selectedType = (string)comboBox1.SelectedItem;
            switch (selectedType) {
                case "Key press" :
                    numericUpDown1.Enabled = false;
                    comboBox2.Enabled = true;
                    break;
                case "Timer":
                    numericUpDown1.Enabled = true;
                    comboBox2.Enabled = false;
                    break;
                default :
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            selectedTimer = (float)numericUpDown1.Value;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            selectedKey = (Keys)comboBox2.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            selectedType = "";
            selectedTimer = 0;
            selectedKey = Keys.None;
            this.Close();
        }





    }
}