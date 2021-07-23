using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HelloWorldCsharp
{
    public partial class btn_Hello : Form
    {

        private int combo1 = -1;
        private int combo2 = -1;
        private int combo3 = -1;
        private int combo4 = -1;
        private int combo5 = -1;
        private int combo6 = -1;
        private int combo7 = -1;
        private int combo8 = -1;
        private int combo9 = -1;
        private int combo10 = -1;

        private FileParsing myParse;


        private int digital1 = -1;
        private int digital2 = -1;
        private int digital3 = -1;
        private int digital4 = -1;
        private int digital5 = -1;
        private int digital6 = -1;
        private int digital7 = -1;
        private int digital8 = -1;
        private int digital9 = -1;
        private int digital10 = -1;


        private string startTime;
        private string endTime;

        private int startIndex = -1;
        private int endIndex = -1;

        ArrayList myTimes = new ArrayList();


        public btn_Hello()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV File|*.csv";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var filestream = ofd.OpenFile();
                FileParsing parse = new FileParsing(filestream);
                myParse = parse;
                lbl_path.Text = ofd.FileName;
            }
        }

        private void comb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String chosen = (string)comb1.SelectedItem;      //Read Combo box selection
                                                     //Hard Coding selection to location of bit.
                                                     // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
                                                     //Digitals: location of bit to-be-graphed within each 32-bit number of each node
            if (chosen.Equals("L1 Admit"))
            {
                combo1 = 2;
                digital1 = 31;
            }
            else if (chosen.Equals("L2 Admit"))
            {
                combo1 = 2;
                digital1 = 7;
            }
            else if (chosen.Equals("S1L1"))
            {
                combo1 = 1;
                digital1 = 3;
            }
            else if (chosen.Equals("S1L2"))
            {
                combo1 = 1;
                digital1 = 12;
            }
            else if (chosen.Equals("S3L1"))
            {
                combo1 = 3;
                digital1 = 21;
            }
            else if (chosen.Equals("S3L2"))
            {
                combo1 = 3;
                digital1 = 25;
            }
            else if (chosen.Equals("Entr Open"))
            {
                combo1 = 3;
                digital1 = 6;
            }
            else if (chosen.Equals("Entr Close"))
            {
                combo1 = 3;
                digital1 = 7;
            }
            else if (chosen.Equals("Exit Open"))
            {
                combo1 = 3;
                digital1 = 8;
            }
            else if (chosen.Equals("Exit Close"))
            {
                combo1 = 3;
                digital1 = 9;
            }
            else if (chosen.Equals("Chamber Conveyor"))
            {
                combo1 = 4;
                digital1 = 26;
            }
            else if (chosen.Equals("ATM Switch"))
            {
                combo1 = 3;
                digital1 = 3;
            }
            else if (chosen.Equals("Iso Valve"))
            {
                combo1 = 4;
                digital1 = 31;
            }
            else if (chosen.Equals("S7L1"))
            {
                combo1 = 3;
                digital1 = 23;
            }
            else if (chosen.Equals("S7L2"))
            {
                combo1 = 3;
                digital1 = 26;
            }
            else if (chosen.Equals("S9L1"))
            {
                combo1 = 1;
                digital1 = 4;
            }
            else if (chosen.Equals("S9L2"))
            {
                combo1 = 1;
                digital1 = 13;
            }
            else if (chosen.Equals("L1 D/S"))
            {
                combo1 = 1;
                digital1 = 5;
            }
            else if (chosen.Equals("L2 D/S"))
            {
                combo1 = 1;
                digital1 = 14;
            }
            else if (chosen.Equals("Green Light"))
            {
                combo1 = 2;
                digital1 = 27;
            }

            else
                combo1 = -1;



        }

        private void comb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String chosen = (string)comb2.SelectedItem;      //Read Combo box selection
                                                             //Hard Coding selection to location of bit.
                                                             // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
                                                             //Digitals: location of bit to-be-graphed within each 32-bit number of each node
            if (chosen.Equals("L1 Admit"))
            {
                combo2 = 2;
                digital2 = 31;
            }
            else if (chosen.Equals("L2 Admit"))
            {
                combo2 = 2;
                digital2 = 7;
            }
            else if (chosen.Equals("S1L1"))
            {
                combo2 = 1;
                digital2 = 3;
            }
            else if (chosen.Equals("S1L2"))
            {
                combo2 = 1;
                digital2 = 12;
            }
            else if (chosen.Equals("S3L1"))
            {
                combo2 = 3;
                digital2 = 21;
            }
            else if (chosen.Equals("S3L2"))
            {
                combo2 = 3;
                digital2 = 25;
            }
            else if (chosen.Equals("Entr Open"))
            {
                combo2 = 3;
                digital2 = 6;
            }
            else if (chosen.Equals("Entr Close"))
            {
                combo2 = 3;
                digital2 = 7;
            }
            else if (chosen.Equals("Exit Open"))
            {
                combo2 = 3;
                digital2 = 8;
            }
            else if (chosen.Equals("Exit Close"))
            {
                combo2 = 3;
                digital2 = 9;
            }
            else if (chosen.Equals("Chamber Conveyor"))
            {
                combo2 = 4;
                digital2 = 26;
            }
            else if (chosen.Equals("ATM Switch"))
            {
                combo2 = 3;
                digital2 = 3;
            }
            else if (chosen.Equals("Iso Valve"))
            {
                combo2 = 4;
                digital2 = 31;
            }
            else if (chosen.Equals("S7L1"))
            {
                combo2 = 3;
                digital2 = 23;
            }
            else if (chosen.Equals("S7L2"))
            {
                combo2 = 3;
                digital2 = 26;
            }
            else if (chosen.Equals("S9L1"))
            {
                combo2 = 1;
                digital2 = 4;
            }
            else if (chosen.Equals("S9L2"))
            {
                combo2 = 1;
                digital2 = 13;
            }
            else if (chosen.Equals("L1 D/S"))
            {
                combo2 = 1;
                digital2 = 5;
            }
            else if (chosen.Equals("L2 D/S"))
            {
                combo2 = 1;
                digital2 = 14;
            }
            else if (chosen.Equals("Green Light"))
            {
                combo2 = 2;
                digital2 = 27;
            }

            else
                combo2 = -1;



        }

        private void comb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String chosen = (string)comb3.SelectedItem;      //Read Combo box selection
                                                             //Hard Coding selection to location of bit.
                                                             // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
                                                             //Digitals: location of bit to-be-graphed within each 32-bit number of each node
            if (chosen.Equals("L1 Admit"))
            {
                combo3 = 2;
                digital3 = 31;
            }
            else if (chosen.Equals("L2 Admit"))
            {
                combo3 = 2;
                digital3 = 7;
            }
            else if (chosen.Equals("S1L1"))
            {
                combo3 = 1;
                digital3 = 3;
            }
            else if (chosen.Equals("S1L2"))
            {
                combo3 = 1;
                digital3 = 12;
            }
            else if (chosen.Equals("S3L1"))
            {
                combo3 = 3;
                digital3 = 21;
            }
            else if (chosen.Equals("S3L2"))
            {
                combo3 = 3;
                digital3 = 25;
            }
            else if (chosen.Equals("Entr Open"))
            {
                combo3 = 3;
                digital3 = 6;
            }
            else if (chosen.Equals("Entr Close"))
            {
                combo3 = 3;
                digital3 = 7;
            }
            else if (chosen.Equals("Exit Open"))
            {
                combo3 = 3;
                digital3 = 8;
            }
            else if (chosen.Equals("Exit Close"))
            {
                combo3 = 3;
                digital3 = 9;
            }
            else if (chosen.Equals("Chamber Conveyor"))
            {
                combo3 = 4;
                digital3 = 26;
            }
            else if (chosen.Equals("ATM Switch"))
            {
                combo3 = 3;
                digital3 = 3;
            }
            else if (chosen.Equals("Iso Valve"))
            {
                combo3 = 4;
                digital3 = 31;
            }
            else if (chosen.Equals("S7L1"))
            {
                combo3 = 3;
                digital3 = 23;
            }
            else if (chosen.Equals("S7L2"))
            {
                combo3 = 3;
                digital3 = 26;
            }
            else if (chosen.Equals("S9L1"))
            {
                combo3 = 1;
                digital3 = 4;
            }
            else if (chosen.Equals("S9L2"))
            {
                combo3 = 1;
                digital3 = 13;
            }
            else if (chosen.Equals("L1 D/S"))
            {
                combo3 = 1;
                digital3 = 5;
            }
            else if (chosen.Equals("L2 D/S"))
            {
                combo3 = 1;
                digital3 = 14;
            }
            else if (chosen.Equals("Green Light"))
            {
                combo3 = 2;
                digital3 = 27;
            }

            else
                combo3 = -1;


        }

        private void comb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            String chosen = (string)comb4.SelectedItem;      //Read Combo box selection
                                                             //Hard Coding selection to location of bit.
                                                             // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
                                                             //Digitals: location of bit to-be-graphed within each 32-bit number of each node
            if (chosen.Equals("L1 Admit"))
            {
                combo4 = 2;
                digital4 = 31;
            }
            else if (chosen.Equals("L2 Admit"))
            {
                combo4 = 2;
                digital4 = 7;
            }
            else if (chosen.Equals("S1L1"))
            {
                combo4 = 1;
                digital4 = 3;
            }
            else if (chosen.Equals("S1L2"))
            {
                combo4 = 1;
                digital4 = 12;
            }
            else if (chosen.Equals("S3L1"))
            {
                combo4 = 3;
                digital4 = 21;
            }
            else if (chosen.Equals("S3L2"))
            {
                combo4 = 3;
                digital4 = 25;
            }
            else if (chosen.Equals("Entr Open"))
            {
                combo4 = 3;
                digital4 = 6;
            }
            else if (chosen.Equals("Entr Close"))
            {
                combo4 = 3;
                digital4 = 7;
            }
            else if (chosen.Equals("Exit Open"))
            {
                combo4 = 3;
                digital4 = 8;
            }
            else if (chosen.Equals("Exit Close"))
            {
                combo4 = 3;
                digital4 = 9;
            }
            else if (chosen.Equals("Chamber Conveyor"))
            {
                combo4 = 4;
                digital4 = 26;
            }
            else if (chosen.Equals("ATM Switch"))
            {
                combo4 = 3;
                digital4 = 3;
            }
            else if (chosen.Equals("Iso Valve"))
            {
                combo4 = 4;
                digital4 = 31;
            }
            else if (chosen.Equals("S7L1"))
            {
                combo4 = 3;
                digital4 = 23;
            }
            else if (chosen.Equals("S7L2"))
            {
                combo4 = 3;
                digital4 = 26;
            }
            else if (chosen.Equals("S9L1"))
            {
                combo4 = 1;
                digital4 = 4;
            }
            else if (chosen.Equals("S9L2"))
            {
                combo4 = 1;
                digital4 = 13;
            }
            else if (chosen.Equals("L1 D/S"))
            {
                combo4 = 1;
                digital4 = 5;
            }
            else if (chosen.Equals("L2 D/S"))
            {
                combo4 = 1;
                digital4 = 14;
            }
            else if (chosen.Equals("Green Light"))
            {
                combo4 = 2;
                digital4 = 27;
            }

            else
                combo4 = -1;


        }

        private void combo5_SelectedIndexChanged(object sender, EventArgs e)
        {
            String chosen = (string)comb5.SelectedItem;      //Read Combo box selection
                                                             //Hard Coding selection to location of bit.
                                                             // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
                                                             //Digitals: location of bit to-be-graphed within each 32-bit number of each node
            if (chosen.Equals("L1 Admit"))
            {
                combo5 = 2;
                digital5 = 31;
            }
            else if (chosen.Equals("L2 Admit"))
            {
                combo5 = 2;
                digital5 = 7;
            }
            else if (chosen.Equals("S1L1"))
            {
                combo5 = 1;
                digital5 = 3;
            }
            else if (chosen.Equals("S1L2"))
            {
                combo5 = 1;
                digital5 = 12;
            }
            else if (chosen.Equals("S3L1"))
            {
                combo5 = 3;
                digital5 = 21;
            }
            else if (chosen.Equals("S3L2"))
            {
                combo5 = 3;
                digital5 = 25;
            }
            else if (chosen.Equals("Entr Open"))
            {
                combo5 = 3;
                digital5 = 6;
            }
            else if (chosen.Equals("Entr Close"))
            {
                combo5 = 3;
                digital5 = 7;
            }
            else if (chosen.Equals("Exit Open"))
            {
                combo5 = 3;
                digital5 = 8;
            }
            else if (chosen.Equals("Exit Close"))
            {
                combo5 = 3;
                digital5 = 9;
            }
            else if (chosen.Equals("Chamber Conveyor"))
            {
                combo5 = 4;
                digital5 = 26;
            }
            else if (chosen.Equals("ATM Switch"))
            {
                combo5 = 3;
                digital5 = 3;
            }
            else if (chosen.Equals("Iso Valve"))
            {
                combo5 = 4;
                digital5 = 31;
            }
            else if (chosen.Equals("S7L1"))
            {
                combo5 = 3;
                digital5 = 23;
            }
            else if (chosen.Equals("S7L2"))
            {
                combo5 = 3;
                digital5 = 26;
            }
            else if (chosen.Equals("S9L1"))
            {
                combo5 = 1;
                digital5 = 4;
            }
            else if (chosen.Equals("S9L2"))
            {
                combo5 = 1;
                digital5 = 13;
            }
            else if (chosen.Equals("L1 D/S"))
            {
                combo5 = 1;
                digital5 = 5;
            }
            else if (chosen.Equals("L2 D/S"))
            {
                combo5 = 1;
                digital5 = 14;
            }
            else if (chosen.Equals("Green Light"))
            {
                combo5 = 2;
                digital5 = 27;
            }

            else
                combo5 = -1;


        }

        private void comb6_SelectedIndexChanged(object sender, EventArgs e)
        {
            String chosen = (string)comb6.SelectedItem;      //Read Combo box selection
                                                             //Hard Coding selection to location of bit.
                                                             // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
                                                             //Digitals: location of bit to-be-graphed within each 32-bit number of each node
            if (chosen.Equals("L1 Admit"))
            {
                combo6 = 2;
                digital6 = 31;
            }
            else if (chosen.Equals("L2 Admit"))
            {
                combo6 = 2;
                digital6 = 7;
            }
            else if (chosen.Equals("S1L1"))
            {
                combo6 = 1;
                digital6 = 3;
            }
            else if (chosen.Equals("S1L2"))
            {
                combo6 = 1;
                digital6 = 12;
            }
            else if (chosen.Equals("S3L1"))
            {
                combo6 = 3;
                digital6 = 21;
            }
            else if (chosen.Equals("S3L2"))
            {
                combo6 = 3;
                digital6 = 25;
            }
            else if (chosen.Equals("Entr Open"))
            {
                combo6 = 3;
                digital6 = 6;
            }
            else if (chosen.Equals("Entr Close"))
            {
                combo6 = 3;
                digital6 = 7;
            }
            else if (chosen.Equals("Exit Open"))
            {
                combo6 = 3;
                digital6 = 8;
            }
            else if (chosen.Equals("Exit Close"))
            {
                combo6 = 3;
                digital6 = 9;
            }
            else if (chosen.Equals("Chamber Conveyor"))
            {
                combo6 = 4;
                digital6 = 26;
            }
            else if (chosen.Equals("ATM Switch"))
            {
                combo6 = 3;
                digital6 = 3;
            }
            else if (chosen.Equals("Iso Valve"))
            {
                combo6 = 4;
                digital6 = 31;
            }
            else if (chosen.Equals("S7L1"))
            {
                combo6 = 3;
                digital6 = 23;
            }
            else if (chosen.Equals("S7L2"))
            {
                combo6 = 3;
                digital6 = 26;
            }
            else if (chosen.Equals("S9L1"))
            {
                combo6 = 1;
                digital6 = 4;
            }
            else if (chosen.Equals("S9L2"))
            {
                combo6 = 1;
                digital6 = 13;
            }
            else if (chosen.Equals("L1 D/S"))
            {
                combo6 = 1;
                digital6 = 5;
            }
            else if (chosen.Equals("L2 D/S"))
            {
                combo6 = 1;
                digital6 = 14;
            }
            else if (chosen.Equals("Green Light"))
            {
                combo6 = 2;
                digital6 = 27;
            }

            else
                combo6 = -1;


        }

        private void comb7_SelectedIndexChanged(object sender, EventArgs e)
        {
            String chosen = (string)comb7.SelectedItem;      //Read Combo box selection
                                                             //Hard Coding selection to location of bit.
                                                             // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
                                                             //Digitals: location of bit to-be-graphed within each 32-bit number of each node
            if (chosen.Equals("L1 Admit"))
            {
                combo7 = 2;
                digital7 = 31;
            }
            else if (chosen.Equals("L2 Admit"))
            {
                combo7 = 2;
                digital7 = 7;
            }
            else if (chosen.Equals("S1L1"))
            {
                combo7 = 1;
                digital7 = 3;
            }
            else if (chosen.Equals("S1L2"))
            {
                combo7 = 1;
                digital7 = 12;
            }
            else if (chosen.Equals("S3L1"))
            {
                combo7 = 3;
                digital7 = 21;
            }
            else if (chosen.Equals("S3L2"))
            {
                combo7 = 3;
                digital7 = 25;
            }
            else if (chosen.Equals("Entr Open"))
            {
                combo7 = 3;
                digital7 = 6;
            }
            else if (chosen.Equals("Entr Close"))
            {
                combo7 = 3;
                digital7 = 7;
            }
            else if (chosen.Equals("Exit Open"))
            {
                combo7 = 3;
                digital7 = 8;
            }
            else if (chosen.Equals("Exit Close"))
            {
                combo7 = 3;
                digital7 = 9;
            }
            else if (chosen.Equals("Chamber Conveyor"))
            {
                combo7 = 4;
                digital7 = 26;
            }
            else if (chosen.Equals("ATM Switch"))
            {
                combo7 = 3;
                digital7 = 3;
            }
            else if (chosen.Equals("Iso Valve"))
            {
                combo7 = 4;
                digital7 = 31;
            }
            else if (chosen.Equals("S7L1"))
            {
                combo7 = 3;
                digital7 = 23;
            }
            else if (chosen.Equals("S7L2"))
            {
                combo7 = 3;
                digital7 = 26;
            }
            else if (chosen.Equals("S9L1"))
            {
                combo7 = 1;
                digital7 = 4;
            }
            else if (chosen.Equals("S9L2"))
            {
                combo7 = 1;
                digital7 = 13;
            }
            else if (chosen.Equals("L1 D/S"))
            {
                combo7 = 1;
                digital7 = 5;
            }
            else if (chosen.Equals("L2 D/S"))
            {
                combo7 = 1;
                digital7 = 14;
            }
            else if (chosen.Equals("Green Light"))
            {
                combo7 = 2;
                digital7 = 27;
            }

            else
                combo7 = -1;


        }

        private void comb8_SelectedIndexChanged(object sender, EventArgs e)
        {
            String chosen = (string)comb8.SelectedItem;      //Read Combo box selection
                                                             //Hard Coding selection to location of bit.
                                                             // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
                                                             //Digitals: location of bit to-be-graphed within each 32-bit number of each node
            if (chosen.Equals("L1 Admit"))
            {
                combo8 = 2;
                digital8 = 31;
            }
            else if (chosen.Equals("L2 Admit"))
            {
                combo8 = 2;
                digital8 = 7;
            }
            else if (chosen.Equals("S1L1"))
            {
                combo8 = 1;
                digital8 = 3;
            }
            else if (chosen.Equals("S1L2"))
            {
                combo8 = 1;
                digital8 = 12;
            }
            else if (chosen.Equals("S3L1"))
            {
                combo8 = 3;
                digital8 = 21;
            }
            else if (chosen.Equals("S3L2"))
            {
                combo8 = 3;
                digital8 = 25;
            }
            else if (chosen.Equals("Entr Open"))
            {
                combo8 = 3;
                digital8 = 6;
            }
            else if (chosen.Equals("Entr Close"))
            {
                combo8 = 3;
                digital8 = 7;
            }
            else if (chosen.Equals("Exit Open"))
            {
                combo8 = 3;
                digital8 = 8;
            }
            else if (chosen.Equals("Exit Close"))
            {
                combo8 = 3;
                digital8 = 9;
            }
            else if (chosen.Equals("Chamber Conveyor"))
            {
                combo8 = 4;
                digital8 = 26;
            }
            else if (chosen.Equals("ATM Switch"))
            {
                combo8 = 3;
                digital8 = 3;
            }
            else if (chosen.Equals("Iso Valve"))
            {
                combo8 = 4;
                digital8 = 31;
            }
            else if (chosen.Equals("S7L1"))
            {
                combo8 = 3;
                digital8 = 23;
            }
            else if (chosen.Equals("S7L2"))
            {
                combo8 = 3;
                digital8 = 26;
            }
            else if (chosen.Equals("S9L1"))
            {
                combo8 = 1;
                digital8 = 4;
            }
            else if (chosen.Equals("S9L2"))
            {
                combo8 = 1;
                digital8 = 13;
            }
            else if (chosen.Equals("L1 D/S"))
            {
                combo8 = 1;
                digital8 = 5;
            }
            else if (chosen.Equals("L2 D/S"))
            {
                combo8 = 1;
                digital8 = 14;
            }
            else if (chosen.Equals("Green Light"))
            {
                combo8 = 2;
                digital8 = 27;
            }

            else
                combo8 = -1;



        }

        private void comb9_SelectedIndexChanged(object sender, EventArgs e)
        {
            String chosen = (string)comb9.SelectedItem;      //Read Combo box selection
                                                             //Hard Coding selection to location of bit.
                                                             // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
                                                             //Digitals: location of bit to-be-graphed within each 32-bit number of each node
            if (chosen.Equals("L1 Admit"))
            {
                combo9 = 2;
                digital9 = 31;
            }
            else if (chosen.Equals("L2 Admit"))
            {
                combo9 = 2;
                digital9 = 7;
            }
            else if (chosen.Equals("S1L1"))
            {
                combo9 = 1;
                digital9 = 3;
            }
            else if (chosen.Equals("S1L2"))
            {
                combo9 = 1;
                digital9 = 12;
            }
            else if (chosen.Equals("S3L1"))
            {
                combo9 = 3;
                digital9 = 21;
            }
            else if (chosen.Equals("S3L2"))
            {
                combo9 = 3;
                digital9 = 25;
            }
            else if (chosen.Equals("Entr Open"))
            {
                combo9 = 3;
                digital9 = 6;
            }
            else if (chosen.Equals("Entr Close"))
            {
                combo9 = 3;
                digital9 = 7;
            }
            else if (chosen.Equals("Exit Open"))
            {
                combo9 = 3;
                digital9 = 8;
            }
            else if (chosen.Equals("Exit Close"))
            {
                combo9 = 3;
                digital9 = 9;
            }
            else if (chosen.Equals("Chamber Conveyor"))
            {
                combo9 = 4;
                digital9 = 26;
            }
            else if (chosen.Equals("ATM Switch"))
            {
                combo9 = 3;
                digital9 = 3;
            }
            else if (chosen.Equals("Iso Valve"))
            {
                combo9 = 4;
                digital9 = 31;
            }
            else if (chosen.Equals("S7L1"))
            {
                combo9 = 3;
                digital9 = 23;
            }
            else if (chosen.Equals("S7L2"))
            {
                combo9 = 3;
                digital9 = 26;
            }
            else if (chosen.Equals("S9L1"))
            {
                combo9 = 1;
                digital9 = 4;
            }
            else if (chosen.Equals("S9L2"))
            {
                combo9 = 1;
                digital9 = 13;
            }
            else if (chosen.Equals("L1 D/S"))
            {
                combo9 = 1;
                digital9 = 5;
            }
            else if (chosen.Equals("L2 D/S"))
            {
                combo9 = 1;
                digital9 = 14;
            }
            else if (chosen.Equals("Green Light"))
            {
                combo9 = 2;
                digital9 = 27;
            }

            else
                combo9 = -1;



        }

        private void comb10_SelectedIndexChanged(object sender, EventArgs e)
        {
            String chosen = (string)comb10.SelectedItem;      //Read Combo box selection
                                                             //Hard Coding selection to location of bit.
                                                             // Combo box values meaning - 1: Node 1 Inputs, 2: Node 1 Outputs, 3: Node 2 Inputs, 4: Node 2 Outputs
                                                             //Digitals: location of bit to-be-graphed within each 32-bit number of each node
            if (chosen.Equals("L1 Admit"))
            {
                combo10 = 2;
                digital10 = 31;
            }
            else if (chosen.Equals("L2 Admit"))
            {
                combo10 = 2;
                digital10 = 7;
            }
            else if (chosen.Equals("S1L1"))
            {
                combo10 = 1;
                digital10 = 3;
            }
            else if (chosen.Equals("S1L2"))
            {
                combo10 = 1;
                digital10 = 12;
            }
            else if (chosen.Equals("S3L1"))
            {
                combo10 = 3;
                digital10 = 21;
            }
            else if (chosen.Equals("S3L2"))
            {
                combo10 = 3;
                digital10 = 25;
            }
            else if (chosen.Equals("Entr Open"))
            {
                combo10 = 3;
                digital10 = 6;
            }
            else if (chosen.Equals("Entr Close"))
            {
                combo10 = 3;
                digital10 = 7;
            }
            else if (chosen.Equals("Exit Open"))
            {
                combo10 = 3;
                digital10 = 8;
            }
            else if (chosen.Equals("Exit Close"))
            {
                combo10 = 3;
                digital10 = 9;
            }
            else if (chosen.Equals("Chamber Conveyor"))
            {
                combo10 = 4;
                digital10 = 26;
            }
            else if (chosen.Equals("ATM Switch"))
            {
                combo10 = 3;
                digital10 = 3;
            }
            else if (chosen.Equals("Iso Valve"))
            {
                combo10 = 4;
                digital10 = 31;
            }
            else if (chosen.Equals("S7L1"))
            {
                combo10 = 3;
                digital10 = 23;
            }
            else if (chosen.Equals("S7L2"))
            {
                combo10 = 3;
                digital10 = 26;
            }
            else if (chosen.Equals("S9L1"))
            {
                combo10 = 1;
                digital10 = 4;
            }
            else if (chosen.Equals("S9L2"))
            {
                combo10 = 1;
                digital10 = 13;
            }
            else if (chosen.Equals("L1 D/S"))
            {
                combo10 = 1;
                digital10 = 5;
            }
            else if (chosen.Equals("L2 D/S"))
            {
                combo10 = 1;
                digital10 = 14;
            }
            else if (chosen.Equals("Green Light"))
            {
                combo10 = 2;
                digital10 = 27;
            }

            else
                combo10 = -1;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            startTime = textBox1.Text;
            //System.Diagnostics.Debug.WriteLine(startTime);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            endTime = textBox2.Text;
            //System.Diagnostics.Debug.WriteLine(endTime);
        }

        public void timeStringtoIndex()
        {
            myTimes.Clear();

            ArrayList unformattedTime = myParse.getTime();

            foreach (string unformatted in unformattedTime)
            {

                System.Diagnostics.Debug.WriteLine(unformatted);


                string formatted = unformatted.Substring(unformatted.Length - 8);
                //System.Diagnostics.Debug.WriteLine(formatted);
                myTimes.Add(formatted);
            }


            
            for (int a = 0; a < myTimes.Count; a++)
            {
                string time = (string)myTimes[a];

                if (a < 1000)
                {
                    System.Diagnostics.Debug.WriteLine(time);
                }



                if (time.IndexOf(startTime) != -1)
                {
                    startIndex = a;

                    System.Diagnostics.Debug.WriteLine(startIndex);
                }
            }

            for (int b = 0; b < myTimes.Count; b++)
            {
                if (((string)myTimes[b]).IndexOf(endTime) != -1)
                {

                    endIndex = b;

                    System.Diagnostics.Debug.WriteLine(endIndex);
                }
            }

            //System.Diagnostics.Debug.WriteLine(myTimes.Count);

            //System.Diagnostics.Debug.WriteLine(startTime);

            //System.Diagnostics.Debug.WriteLine(endTime);
        }

        private void btn_Load_Graph_Click(object sender, EventArgs e)
        {

            
            timeStringtoIndex();

            //System.Diagnostics.Debug.Write("       " + startIndex + "     " + endIndex);

            /*foreach (var series in lineDisplay.Series)
            {
                series.Points.Clear();
            }
            */

            List<int[][]> methods = new List<int[][]>();
            methods.Add(myParse.getNode1InputsArr());
            methods.Add(myParse.getNode1OutputsArr());
            methods.Add(myParse.getNode2InputsArr());
            methods.Add(myParse.getNode2OutputsArr());

            //System.Diagnostics.Debug.Write("       " + combo1 + "     " + digital1);

            if (combo1 != -1 && digital1 != -1)  //Check that the first combo box is actually selected by user
            {

                string[] tempTimes = new string[endIndex-startIndex];
                int[] nums = new int[endIndex - startIndex];

                lineDisplay.Series[0].ChartType = SeriesChartType.Line;  //Declare a new series to be graphed
                for (int i = startIndex; i < endIndex - 1; i++) //Data will be added from the csv file from start time to end time
                {

                    lineDisplay.Series[0].Points.AddXY((string)myTimes[i], (methods[combo1 - 1])[i][digital1 - 1] );

                    tempTimes[i - startIndex] = (string)myTimes[i];
                    nums[i - startIndex] = (methods[combo1 - 1])[i][digital1 - 1];
                    
                    //^ 1 is subtracted from combo1 and digital1 for proper indexing
                }
                
            }

        }
    }
}
