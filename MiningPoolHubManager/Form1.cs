using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MiningPoolHubManager
{
    public partial class Form1 : Form
    {
        public static String paramText = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // add coins
            //coinBindingSource1.Add(new Coin("Adzcoin", 20529, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Checkcoin", 20502, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Crevacoin", 20531, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Dash", 20465, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Digibyte (Groestl)", 20499, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Digibyte (Qubit)", 20517, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Digibyte (Skein)", 20527, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Digitalcoin (x11)", 20530, "hub.miningpoolhub.com"));
            coinBindingSource1.Add(new Coin("Ethereum", 20535, "ethereum.miningpoolhub.com"));
            coinBindingSource1.Add(new Coin("Ethereum-Classic", 20555, "ethereum-classic.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Expanse", 20565, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Feathercoin", 20510, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Geocoin", 20524, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Globalboosty", 20543, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Groestlcoin", 20486, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Influx", 20532, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Litecoin", 20460, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Maxcoin", 20461, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Myriadcoin (Groestl)", 20479, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Myriadcoin (Skein)", 20528, "hub.miningpoolhub.com"));
            // coinBindingSource1.Add(new Coin("Phoenixcoin", 20508, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Sexcoin", 20463, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Siacoin", 20550, "hub.miningpoolhub.com"));
            // coinBindingSource1.Add(new Coin("Smartcoin", 20518, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Solarcoin", 20468, "hub.miningpoolhub.com"));
            // coinBindingSource1.Add(new Coin("Startcoin", 20509, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Ufocoin", 20504, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Uro", 20513, "hub.miningpoolhub.com"));
            // coinBindingSource1.Add(new Coin("Vcash", 20533, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Vertcoin", 20507, "hub.miningpoolhub.com"));
            //coinBindingSource1.Add(new Coin("Verge (Scrypt)", 20523, "hub.miningpoolhub.com"));
            coinBindingSource1.Add(new Coin("Zcash", 20570, "zcash.miningpoolhub.com"));

            // add servers
            //serverBindingSource.Add(new Server("us-east"));
            serverBindingSource.Add(new Server("us-east1"));
            //serverBindingSource.Add(new Server("europe"));
            serverBindingSource.Add(new Server("europe1"));
            //serverBindingSource.Add(new Server("asia"));
            serverBindingSource.Add(new Server("asia1"));

            loadFromXML();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem);
        }

        private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem);
        }

        private void loginTextField_TextChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem);
        }

        private void passwordTextField_TextChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Coin coin = (Coin)coinComboBox.SelectedItem;
            Process miner = new Process();
            String fileName = null;
            String workingDirectory = null;
            if (coin.name == "Zcash")
            {
                if (cpuRadioButton.Checked)
                {
                    workingDirectory = Environment.CurrentDirectory + "\\nheqminer_zec\\";
                    fileName = "nheqminer.exe";
                }
                else if (gpuAMDRadioButton.Checked)
                {
                    workingDirectory = Environment.CurrentDirectory + "\\claymore_zec\\";
                    fileName = "ZecMiner64.exe";
                }
                else if (gpuNVIDIARadioButton.Checked)
                {
                    workingDirectory = Environment.CurrentDirectory + "\\nheqminer_zec\\";
                    fileName = "nheqminer.exe";
                }
            }
            else if (coin.name == "Ethereum" || coin.name == "Ethereum-classic")
            {
                if (gpuAMDRadioButton.Checked)
                {
                    workingDirectory = Environment.CurrentDirectory + "\\claymore_eth\\";
                    fileName = "EthDcrMiner64.exe";
                }
                else if (gpuNVIDIARadioButton.Checked)
                {
                    workingDirectory = Environment.CurrentDirectory + "\\claymore_eth\\";
                    fileName = "EthDcrMiner64.exe";
                }
            }
            if (fileName != null)
            {
                try
                {
                    miner.StartInfo.WorkingDirectory = Path.GetDirectoryName(workingDirectory);
                    miner.StartInfo.FileName = fileName;
                    miner.StartInfo.Arguments = paramText;
                    miner.Start();
                }
                catch(Exception exc)
                {
                    resultLabel.Text = "Could not start " + fileName + " miner! Make sure it is placed in the directory: \n " + workingDirectory + "";
                }
                
            }
            
        }

        private void computeParameter(Coin coin, Server server)
        {
            if (coin != null && server != null)
            {
                resultLabel.Text = "Coin: " + coin.name + "\nServer: " + server.name + "." + coin.host + "\nPort: " + coin.port + "\nLogin: " + loginTextField.Text + ":x";
                if (coin.name == "Zcash")
                {
                    cpuRadioButton.Enabled = true;
                    if (cpuRadioButton.Checked)
                    {
                        paramText = "-l " + server.name + "." + coin.host + ":" + coin.port + " -u " + loginTextField.Text + " -p " + passwordTextField.Text + "";
                    }
                    else if(gpuNVIDIARadioButton.Checked)
                    {
                        paramText = "-l " + server.name + "." + coin.host + ":" + coin.port + " -u " + loginTextField.Text + " -p "+ passwordTextField.Text + " -cd 0";
                    }
                    else if(gpuAMDRadioButton.Checked)
                    {
                        paramText = "-zpool " + server.name + "." + coin.host + ":" + coin.port + " -zwal " + loginTextField.Text + " -zpsw "+ passwordTextField.Text + " -allpools 1";
                    }
                }
                else if(coin.name == "Ethereum" || coin.name == "Ethereum-Classic")
                {
                    cpuRadioButton.Enabled = false;
                    cpuRadioButton.Checked = false;
                    if (gpuNVIDIARadioButton.Checked)
                    {
                        paramText = "-epool " + server.name + "." + coin.host + ":" + coin.port + " -ewal " + loginTextField.Text + " -epsw " + passwordTextField.Text + " -allpools 1";
                    }
                    else if (gpuAMDRadioButton.Checked)
                    {
                        paramText = "-epool " + server.name + "." + coin.host + ":" + coin.port + " -ewal " + loginTextField.Text + " -epsw " + passwordTextField.Text + " -allpools 1";
                    }
                }
            }
            configTextBox.Text = paramText;
            startButton.Enabled = true;
            
        }

        private void cpuRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem);
        }

        private void gpuAMDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem);
        }

        private void gpuNVIDIARadioButton_CheckedChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://miningpoolhub.com/");
        }

        private void saveToXML()
        {
            try
            {
                XmlTextWriter configXMLWriter = new XmlTextWriter("config.xml",
                                                           System.Text.Encoding.UTF8);
                configXMLWriter.Formatting = Formatting.Indented;
                configXMLWriter.WriteStartDocument(false);

                configXMLWriter.WriteComment("MiningPoolHubManager - Configurationfile");

                configXMLWriter.WriteStartElement("settings");

                configXMLWriter.WriteElementString("login", loginTextField.Text);
                configXMLWriter.WriteElementString("password", passwordTextField.Text);
                configXMLWriter.WriteElementString("coin", coinComboBox.SelectedIndex.ToString());
                configXMLWriter.WriteElementString("server", serverComboBox.SelectedIndex.ToString());
                if (cpuRadioButton.Checked)
                    configXMLWriter.WriteElementString("miningMode", "0");
                else if (gpuAMDRadioButton.Checked)
                    configXMLWriter.WriteElementString("miningMode", "1");
                else
                    configXMLWriter.WriteElementString("miningMode", "2");
                configXMLWriter.WriteEndElement();

                configXMLWriter.Flush();
                configXMLWriter.Close();
            }
            catch (Exception e)
            {
                
            }
        }

        private void loadFromXML()
        {
            try
            {
                XDocument xml = XDocument.Load("config.xml");

                var xmlQuery = from item in xml.Descendants("settings")
                               select item;


                foreach (XElement items in xmlQuery)
                {
                    loginTextField.Text = items.Element("login").Value;
                    passwordTextField.Text = items.Element("password").Value;
                    coinComboBox.SelectedIndex = Int32.Parse(items.Element("coin").Value);
                    serverComboBox.SelectedIndex = Int32.Parse(items.Element("server").Value);
                    int temp = Int32.Parse(items.Element("miningMode").Value);
                    if (temp == 0)
                        cpuRadioButton.Checked = true;
                    else if (temp == 1)
                        gpuAMDRadioButton.Checked = true;
                    else
                        gpuNVIDIARadioButton.Checked = true;
                }
            }
            catch(Exception e)
            {

            }

        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            saveToXML();
            resultLabel.Text = "Settings saved to file: config.xml";
        }
    }
}
