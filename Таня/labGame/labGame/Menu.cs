﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            StartVirus SV = new StartVirus();
            SV.ShowDialog();
        }

        private void finish_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SudokuGame(object sender, EventArgs e)
        {
            Sudoku S = new Sudoku();
            S.ShowDialog();
        }
    }
}
