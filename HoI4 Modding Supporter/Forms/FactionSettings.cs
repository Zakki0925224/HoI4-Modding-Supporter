﻿using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using HoI4_Modding_Supporter.Database;
using HoI4_Modding_Supporter.Mediators;
using System.Collections.Generic;

namespace HoI4_Modding_Supporter.Forms
{
    public partial class FactionSettings : Form
    {
        UserController uc = new UserController();

        public FactionSettings()
        {
            InitializeComponent();

            Variable variable = new Variable();

            textBox1.Text = variable.FactionInternalName;
            textBox2.Text = variable.FactionName;

            if (variable.FactionParticipatingCountries != null)
            {
                for (int cnt = 0; cnt < variable.FactionParticipatingCountries.Length; cnt++)
                {
                    listBox1.Items.Add(variable.FactionParticipatingCountries[cnt]);
                }
            }
        }

        /// <summary>
        /// 入力ミスなどをチェック
        /// </summary>
        private int Check()
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBox1);
            textBoxes.Add(textBox2);

            return uc.FactionSettingsChecker(textBoxes);
        }

        /// <summary>
        /// データの変数化処理
        /// </summary>
        private void DataAssignment()
        {
            Variable variable = new Variable();

            variable.FactionInternalName = textBox1.Text.Replace(" ", "_");
            variable.FactionName = textBox2.Text;

            if (listBox1.Items.Count != 0)
            {
                variable.FactionParticipatingCountries = listBox1.Items.Cast<string>().ToArray();
            }
            else
            {
                variable.FactionParticipatingCountries = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cResult = Check();
            if (cResult == 1)
            {
                return;
            }

            DataAssignment();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text) && listBox1.Items.IndexOf(textBox3.Text) == -1)
            {
                listBox1.Items.Add(textBox3.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
