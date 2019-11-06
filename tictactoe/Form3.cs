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
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
        }
        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        public static int sayac1 = 0;
        public static int sayac2 = 0;

        private void buttonClick(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    turns++;
                    player++;
                    Otimer.Enabled = true;
                    TTimer.Enabled = false;
                   
                }
                else
                {
                    button.Text = "O";
                    turns++;
                    player++;
                    Otimer.Enabled = false;
                    TTimer.Enabled = true;
                }
                if (CheckDraw() == true && CheckWinner() == false)
                {
                    sd++;
                    SureKarsilastir();
                    YeniOyun();
                    
                    

                }
                if (CheckWinner() == true)
                {
                    if (button.Text=="X")
                    {
                        s1++;
                        YeniOyun();
                        MessageBox.Show("X Kazandın!");
                        
                    }
                    else
                    {
                        s2++; 
                        YeniOyun();
                        MessageBox.Show("O Kazandı!");
                       
                    }
                   
                }      
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblXWinor.Text = "XWinor";
            lblDraws1.Text = "Draws" ;
            lblOWinor.Text = "OWinor";
        }
        void YeniOyun()
        {
            
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            turns = 0;
            player=2;
            XScore.Text = s1.ToString();
            OScore.Text = s2.ToString();
            DrawsCount1.Text = sd.ToString();  
            sayac1 = 0;
            sayac2 = 0;
            lblXSure.Text = "0";
            lblOSure.Text = "0";
            TTimer.Enabled = false;
            Otimer.Enabled = false;
          
           
            

        }

        private void btnYeniOyun1_Click(object sender, EventArgs e)
        {
            YeniOyun();
        }

        bool CheckDraw()
        {
            if ((turns == 9)&& CheckWinner() == false)
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
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
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

        private void btnTemizle1_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            YeniOyun();
        }

        private void btnCikis1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void TTimer_Tick(object sender, EventArgs e)
        {
            sayac1++;
            lblXSure.Text = sayac1.ToString();           
        }

        private void Otimer_Tick(object sender, EventArgs e)
        {
            sayac2++;
            lblOSure.Text = sayac2.ToString();
        }

       
        public void SureKarsilastir()
        {
            if (Convert.ToInt32(lblXSure.Text) < Convert.ToInt32(lblOSure.Text))
            {
                MessageBox.Show("X Kazandı");
            }
            else if(Convert.ToInt32(lblXSure.Text) > Convert.ToInt32(lblOSure.Text))
            {
                MessageBox.Show("O Kazandı");
            }
            else
            {
                MessageBox.Show("Berabere Kalındı");
            }
            TTimer.Enabled = false;
            Otimer.Enabled = false;
        }

       


        
    }
}
