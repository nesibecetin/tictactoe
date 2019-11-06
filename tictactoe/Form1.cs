using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public bool onturn = true;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        public Button CPU()
        {
            Button button = null;
            button = CPUTryWinorDefend("O");
            if (button != null)
                return button;
            else
            {
                button = CPUTryWinorDefend("X");
                if (button != null)
                    return button;
                else
                    return CPUMoveRandom();
            }

        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text=="")
            {
                     if (onturn==true)
                         button.Text = "X";
                     else
                         button.Text = "O";
                       
                  turns++;
                  onturn=!onturn;
                  if(CheckWinner()==true)
                  {
                    if(onturn==false)
                    {
                        s1++;
                        MessageBox.Show("Sen Kazandın!");
                        YeniOyun();
                    }
                    else
                    {
                        s2++;
                        MessageBox.Show("CPU Kazandı!");
                        YeniOyun();
                    }
                  }      
                    
                if(CheckDraw()==true&&CheckWinner()==false)
                { 
                    sd++;
                    MessageBox.Show("Berabere");
                    YeniOyun();
                }
                if(onturn==false)
                {
                    CPU().PerformClick();
                }
               
            }
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMe.Text = "Me";
            lblDraws.Text = "Draws";
            lblCPU.Text = "CPU";
        }

       void YeniOyun()
        {
            
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text=""; 
            turns = 0;
            onturn = true;
            MyScore.Text = s1.ToString();
            CPUScore.Text = s2.ToString();
            DrawsCount.Text = sd.ToString();
           
        }

       private void btnYeniOyun_Click(object sender, EventArgs e)
       {
           YeniOyun();
       }
        bool CheckDraw()
       {
            if((turns==9)&&CheckWinner()==false)
            {
                return true;
            }
            else
            {
                return false;
            }
       }
        bool CheckWinner()
        {
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                return true;
            else if((A10.Text==A11.Text)&&(A11.Text==A12.Text)&&A10.Text!="")
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;
           
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;


            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
                return true;
            else
                return false;
        }

        public Button CPUTryWinorDefend(string s)
        {
            Button button = null;
            if ((A00.Text) == (A01.Text) && A00.Text == s && A02.Text == "")
                return A02;
            else if (A00.Text == A02.Text && A00.Text == s && A01.Text == "")
                return A01;
            else if (A01.Text == A02.Text && A01.Text == s && A00.Text == "")
                return A00;
            else if (A10.Text == A12.Text && A10.Text == s && A11.Text == "")
                return A11;
            else if (A10.Text == A11.Text && A10.Text == s && A02.Text == "")
                return A02;
            else if (A12.Text == A11.Text && A11.Text == s && A10.Text == "")
                return A10;
            else if (A20.Text == A22.Text && A20.Text == s && A21.Text == "")
                return A21;
            else if (A20.Text == A21.Text && A20.Text == s && A22.Text == "")
                return A22;
            else if (A22.Text == A21.Text && A22.Text == s && A20.Text == "")
                return A20;
            else if ((A00.Text) == (A10.Text) && A00.Text == s && A20.Text == "")
                return A20;
            else if (A00.Text == A20.Text && A00.Text == s && A10.Text == "")
                return A10;
            else if (A20.Text == A10.Text && A10.Text == s && A00.Text == "")
                return A00;
            else if (A21.Text == A11.Text && A11.Text == s && A10.Text == "")
                return A01;
            else if (A21.Text == A01.Text && A01.Text == s && A11.Text == "")
                return A11;
            else if (A01.Text == A11.Text && A01.Text == s && A21.Text == "")
                return A21;
            else if (A22.Text == A12.Text && A12.Text == s && A02.Text == "")
                return A02;
            else if (A22.Text == A02.Text && A02.Text == s && A12.Text == "")
                return A12;
            else if (A02.Text == A12.Text && A01.Text == s && A22.Text == "")
                return A22;
            else if (A00.Text == A11.Text && A11.Text == s && A22.Text == "")
                return A22;
            else if (A22.Text == A00.Text && A22.Text == s && A11.Text == "")
                return A11;
            else if (A22.Text == A11.Text && A11.Text == s && A00.Text == "")
                return A00;
            else if (A20.Text == A11.Text && A11.Text == s && A02.Text == "")
                return A02;
            else if (A20.Text == A02.Text && A02.Text == s && A11.Text == "")
                return A11;
            else if (A02.Text == A11.Text && A11.Text == s && A20.Text == "")
                return A20;
            else
                return null;

           
        }
        public Button CPUMoveRandom()
        {
            Button button = null;
            foreach(Control C in Controls)
            {
                button = C as Button;
                if(button!=null)
                {
                    if (button.Text == "")
                        return button;
                }
                
            }
            return null;
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            YeniOyun();
        }
    }
}
