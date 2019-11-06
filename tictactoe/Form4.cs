using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace tictactoe
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        private void Form4_Load(object sender, EventArgs e)
        {
            lblX.Text = "X";
            lblDraws2.Text = "Draws";
            lblO.Text = "O";
            // set up socket

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }

        private void btnYeniOyun1_Click(object sender, EventArgs e)
        {

            epLocal = new IPEndPoint(IPAddress.Parse(GetLocalIP()), 84);
            sck.Bind(epLocal);
            // Connecting to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(GetLocalIP()), 82);
            sck.Connect(epRemote);
            // Listening to specific port

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void MessageCallBack(IAsyncResult aResult)
      {
          byte[] receivedData = new byte[1500];
          receivedData = (byte[])aResult.AsyncState;

          ASCIIEncoding aEncoding = new ASCIIEncoding();
          string receivedMessage = aEncoding.GetString(receivedData);

          buffer = new byte[1500];
          sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {

                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }

            }

            return "127.0.0.1";
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
                    MessageBox.Show("Berabere");           
                     SureKarsilastir();
                    YeniOyun();



                }
                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
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

        void YeniOyun()
        {

            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            turns = 0;
            player = 2;
            XWinScore.Text = s1.ToString();
            OWinScore.Text = s2.ToString();
            DrawsCount2.Text = sd.ToString();
            sayac1 = 0;
            sayac2 = 0;
            lblXtime.Text = "0";
            lblOtime.Text = "0";
            TTimer.Enabled = false;
            Otimer.Enabled = false;




        }

        private void btnYeniOyun1_Click(object sender, EventArgs e)
        {
            YeniOyun();
        }

        bool CheckDraw()
        {
            if ((turns == 9) && CheckWinner() == false)
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




        public void SureKarsilastir()
        {
            if (Convert.ToInt32(lblXtime.Text) < Convert.ToInt32(lblOtime.Text))
            {
                MessageBox.Show("X Kazandı");
            }
            else if (Convert.ToInt32(lblXtime.Text) > Convert.ToInt32(lblOtime.Text))
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
