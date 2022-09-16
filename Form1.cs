/**
 * @file   form1.cs
 * @author Jessy Grimard-Maheu
 * @date   8/28/2022
 * @brief  LaboChaines(lab1) pour le cours 247-516-SH-A22.
 * Le but de ce laboratoire est de se familiariser avec les types string (chaine de caractère).
 * Le programme contient 12 boutons ayant tous des actions différentes; 
 * - Retire Espaces ; Efface les espaces dans la string
 * - Inverse Caractère ; Inverse les caractère de la string
 * - Doubler Caractère ; Double les caractère de la string
 * - Sauter 1 Caractère ; Saute 1 caractère sur 2
 * - Maj-Min ; Alternation entre un caractère majuscule et minuscule
 * - Mot de Passe ; Vérifie si la string est un mot de passe valide
 * - 1 Seul Espace ; Garde une seule espace entre chaque mots
 * - Inverse Mots ; Inverse les mots de la string
 * - Compte Mots ; Compte le nombre de mots dans la string
 * - Rotation ; Rotation de la string
 * - ASCII ; Conversion de la string avec le code ASCII
 *
 * @version 1.0 : Première version
 * Environnement de développement: Visual Studio 2022
 * Matériel: N/A
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Linq.Expressions;

namespace lab1_JGM
{
    public partial class frmLab1 : Form
    {
        public frmLab1()
        {
            InitializeComponent();  // Permet l'initialisation des composants
        }


        private void button_UART(object sender, EventArgs e)
        {
            btnUART.Enabled = false;
            btnUART.BackColor = Color.LimeGreen;
            btnUDP.Enabled = true;
            btnUDP.BackColor = Color.White;
            currentlyUsingtextBox.Text = "Currently using UART";
        }

        private void button_UDP(object sender, EventArgs e)
        {
            btnUART.Enabled = true;
            btnUART.BackColor = Color.White;
            btnUDP.Enabled = false;
            btnUDP.BackColor = Color.LimeGreen;
            currentlyUsingtextBox.Text = "Currently using UDP";
        }

        private void button_SendData(object sender, EventArgs e)
        {
            if(tmr1000ms.Enabled)
            { 
                btnSend.Text = "Send data (loop)";// Change le texte 
                tmr1000ms.Enabled = false;   // Stop le timer de 1000ms
            }
            else
            {
                if (hostnameTextBox.Text.Length > 0)  // Si resultBox n'est pas vide
                {
                    btnSend.Text = "Stop sending data";// Change le texte
                    tmr1000ms.Enabled = true;    // Start le timer de 1000ms
                }
            }
        }


        /// <summary>
        /// Timer de 1000ms pour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmr1000ms_Tick(object sender, EventArgs e)
        {
            if (!btnUDP.Enabled)
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                IPAddress broadcast = IPAddress.Parse(hostnameTextBox.Text);

                if(CmdTextBox.Text == "random")
                {
                    var random = new Random();
                    string commandeRandom = "";

                    int volts = random.Next(0,16);
                    int temperature = random.Next(-50,50);
                    int temperature1 = random.Next(-50, 50);
                    int temperature2 = random.Next(-50, 50);
                    int temperature3 = random.Next(-50, 50);
                    int humidity = random.Next(0,100);
                    int pression = random.Next(90,110);

                    int typenumber = random.Next(0,4);
                    switch (typenumber)
                    {
                        case 0:
                            // code for ADC
                            commandeRandom = "fur {\"type\":\"ADC\",\"volts\":" + volts.ToString() + ",\"ts\":\"\"}";
                            break;
                        case 1:
                            // code for DHT22
                            commandeRandom = "fur {\"type\":\"DHT22\",\"T\":" + temperature.ToString() + ",\"HR\":" + humidity.ToString() + ",\"ts\":\"\"}";
                            break;
                        case 2:
                            // code for BME280
                            commandeRandom = "fur {\"type\":\"BME280\",\"Temperature\":" + temperature.ToString() + ",\"Pression\":" + pression.ToString() + ",\"Humidity\":" + humidity.ToString() + ",\"ts\":\"\"}";
                            break;
                        case 3:
                            // code for DS1820
                            commandeRandom = "fur {\"type\":\"DS1820\",\"T\":[" + temperature.ToString() + "," + temperature1.ToString() + "," + temperature2.ToString() + "," + temperature3.ToString() + "],\"ts\":\"\"}";
                            break;
                        default:
                            // code block
                            break;
                    }
                    byte[] sendbuf = Encoding.ASCII.GetBytes(commandeRandom);
                    IPEndPoint ep = new IPEndPoint(broadcast, Int32.Parse(portTextBox.Text));
                    s.SendTo(sendbuf, ep);
                }
                else 
                {
                    byte[] sendbuf = Encoding.ASCII.GetBytes(CmdTextBox.Text);
                    IPEndPoint ep = new IPEndPoint(broadcast, Int32.Parse(portTextBox.Text));
                    s.SendTo(sendbuf, ep);
                }
                
            }
            else if (!btnUART.Enabled)
            {
                SerialPort portSerieESP;
                portSerieESP = new SerialPort();
                portSerieESP.PortName = comPortTextBox.Text;
                portSerieESP.BaudRate = 115200;

                if (!portSerieESP.IsOpen)
                {
                    portSerieESP.Open();
                }

                if (CmdTextBox.Text == "random")
                {
                    var random = new Random();
                    string commandeRandom = "";

                    int volts = random.Next(0, 16);
                    int temperature = random.Next(-50, 50);
                    int temperature1 = random.Next(-50, 50);
                    int temperature2 = random.Next(-50, 50);
                    int temperature3 = random.Next(-50, 50);
                    int humidity = random.Next(0, 100);
                    int pression = random.Next(90, 110);

                    int typenumber = random.Next(0, 4);
                    switch (typenumber)
                    {
                        case 0:
                            // code for ADC
                            commandeRandom = "fur {\"type\":\"ADC\",\"volts\":" + volts.ToString() + ",\"ts\":\"\"}";
                            break;
                        case 1:
                            // code for DHT22
                            commandeRandom = "fur {\"type\":\"DHT22\",\"T\":" + temperature.ToString() + ",\"HR\":" + humidity.ToString() + ",\"ts\":\"\"}";
                            break;
                        case 2:
                            // code for BME280
                            commandeRandom = "fur {\"type\":\"BME280\",\"Temperature\":" + temperature.ToString() + ",\"Pression\":" + pression.ToString() + ",\"Humidity\":" + humidity.ToString() + ",\"ts\":\"\"}";
                            break;
                        case 3:
                            // code for DS1820
                            commandeRandom = "fur {\"type\":\"DS1820\",\"T\":[" + temperature.ToString() + "," + temperature1.ToString() + "," + temperature2.ToString() + "," + temperature3.ToString() + "],\"ts\":\"\"}";
                            break;
                        default:
                            // code block
                            break;
                    }

                    portSerieESP.WriteLine(commandeRandom);
                    portSerieESP.Close();
                }
                else
                {
                    portSerieESP.WriteLine(CmdTextBox.Text);
                    portSerieESP.Close();
                }
            }
            else
            {
                // error
            }
        }

        /// <summary>
        /// Permet de quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitter_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Quitter l'application
        }

        private void btnSendOnce_Click(object sender, EventArgs e)
        {
            if (!btnUDP.Enabled)
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                IPAddress broadcast = IPAddress.Parse(hostnameTextBox.Text);

                byte[] sendbuf = Encoding.ASCII.GetBytes(CmdTextBox.Text);
                IPEndPoint ep = new IPEndPoint(broadcast, Int32.Parse(portTextBox.Text));

                s.SendTo(sendbuf, ep);
            }
            else if (!btnUART.Enabled)
            {
                SerialPort portSerieESP;
                portSerieESP = new SerialPort();
                portSerieESP.PortName = comPortTextBox.Text;
                portSerieESP.BaudRate = 115200;

                if (!portSerieESP.IsOpen)
                {
                    portSerieESP.Open();
                }

                portSerieESP.WriteLine(CmdTextBox.Text);
                portSerieESP.Close();
            }
            else
            {
                // error
            }
        }
    }
}
