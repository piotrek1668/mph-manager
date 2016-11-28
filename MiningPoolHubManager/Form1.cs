using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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
            coinBindingSource1.Add(new Coin("Adzcoin", 20529, "hub.miningpoolhub.com", "darkcoin-mod", "07"));
            coinBindingSource1.Add(new Coin("Checkcoin", 20502, "hub.miningpoolhub.com", "darkcoin-mod", "07"));
            coinBindingSource1.Add(new Coin("Crevacoin", 20531, "hub.miningpoolhub.com", "darkcoin-mod", "07"));
            coinBindingSource1.Add(new Coin("Dash", 20465, "dash.miningpoolhub.com", "darkcoin-mod", "07"));
            //coinBindingSource1.Add(new Coin("Digibyte (Groestl)", 20499, "hub.miningpoolhub.com", "groestlcoin"));
            coinBindingSource1.Add(new Coin("Digibyte (Qubit)", 20517, "hub.miningpoolhub.com", "qubitcoin", "14"));
            coinBindingSource1.Add(new Coin("Digibyte (Skein)", 20527, "hub.miningpoolhub.com", "skeincoin", "16"));
            coinBindingSource1.Add(new Coin("Digitalcoin (x11)", 20530, "hub.miningpoolhub.com", "darkcoin-mod", "07"));
            coinBindingSource1.Add(new Coin("Ethereum", 20535, "ethereum.miningpoolhub.com", "Ethash", "20"));
            coinBindingSource1.Add(new Coin("Ethereum-Classic", 20555, "ethereum-classic.miningpoolhub.com", "Ethash", "20"));
            coinBindingSource1.Add(new Coin("Expanse", 20565, "expanse.miningpoolhub.com", "Ethash", "20"));
            coinBindingSource1.Add(new Coin("Feathercoin", 20510, "hub.miningpoolhub.com", "neoscrypt", "12"));
            coinBindingSource1.Add(new Coin("Geocoin", 20524, "hub.miningpoolhub.com", "qubitcoin", "14"));
            coinBindingSource1.Add(new Coin("Globalboosty", 20543, "hub.miningpoolhub.com", "yescrypt", "21"));
            coinBindingSource1.Add(new Coin("Groestlcoin", 20486, "hub.miningpoolhub.com", "groestlcoin", "04"));
            coinBindingSource1.Add(new Coin("Influx", 20532, "hub.miningpoolhub.com", "darkcoin-mod", "07"));
            coinBindingSource1.Add(new Coin("Litecoin", 20460, "hub.miningpoolhub.com", "vanilla", "01"));
            coinBindingSource1.Add(new Coin("Maxcoin", 20461, "maxcoin.miningpoolhub.com", "maxcoin", "03"));
            coinBindingSource1.Add(new Coin("Myriadcoin (Groestl)", 20479, "myriadcoin-groestl.miningpoolhub.com", "myriadcoin-groestl", "05"));
            coinBindingSource1.Add(new Coin("Myriadcoin (Skein)", 20528, "hub.miningpoolhub.com", "skeincoin", "16"));
            coinBindingSource1.Add(new Coin("Phoenixcoin", 20508, "hub.miningpoolhub.com", "neoscrypt", "12"));
            coinBindingSource1.Add(new Coin("Sexcoin", 20463, "hub.miningpoolhub.com", "vanilla", "01"));
            coinBindingSource1.Add(new Coin("Siacoin", 20550, "hub.miningpoolhub.com", "Ethash", "22"));
            coinBindingSource1.Add(new Coin("Smartcoin", 20518, "hub.miningpoolhub.com", "darkcoin-mod", "07"));
            //coinBindingSource1.Add(new Coin("Solarcoin", 20468, "hub.miningpoolhub.com", "vanilla")); // not supported due a hard fork
            coinBindingSource1.Add(new Coin("Startcoin", 20509, "hub.miningpoolhub.com", "darkcoin-mod", "07"));
            coinBindingSource1.Add(new Coin("Ufocoin", 20504, "hub.miningpoolhub.com", "neoscrypt", "12"));
            coinBindingSource1.Add(new Coin("Uro", 20513, "hub.miningpoolhub.com", "darkcoin-mod", "07"));
            //coinBindingSource1.Add(new Coin("Vcash", 20533, "hub.miningpoolhub.com", "blake256r8"));
            coinBindingSource1.Add(new Coin("Vertcoin", 20507, "hub.miningpoolhub.com", "lyra2rev2", "18"));
            coinBindingSource1.Add(new Coin("Verge (Scrypt)", 20523, "hub.miningpoolhub.com", "vanilla", "01"));
            coinBindingSource1.Add(new Coin("Zcash", 20570, "zcash.miningpoolhub.com", "Equihash", "23"));
            coinBindingSource1.Add(new Coin("Zclassic", 20575, "zclassic.miningpoolhub.com", "Equihash", "23"));

            // add servers
            serverBindingSource.Add(new Server("us-east"));
            serverBindingSource.Add(new Server("europe"));
            serverBindingSource.Add(new Server("asia"));

            // add algos
            //algoBindingSource.Add(new Algo("Blake-Vanilla", 17019, "hub.miningpoolhub.com", "blake256r8"));
            algoBindingSource.Add(new Algo("Equihash", 17023, "equihash-hub.miningpoolhub.com", "Equihash"));
            algoBindingSource.Add(new Algo("Ethash", 17020, "ethash-hub.miningpoolhub.com", "Ethash"));
            algoBindingSource.Add(new Algo("Groestl", 17004, "hub.miningpoolhub.com", "groestlcoin"));
            algoBindingSource.Add(new Algo("Keccak", 17003, "hub.miningpoolhub.com", "maxcoin"));
            algoBindingSource.Add(new Algo("Lyra2RE2", 17018, "hub.miningpoolhub.com", "lyra2rev2"));
            algoBindingSource.Add(new Algo("Myriad-Groestl", 17005, "hub.miningpoolhub.com", "myriadcoin-groestl"));
            algoBindingSource.Add(new Algo("NeoScrypt", 17012, "hub.miningpoolhub.com", "neoscrypt"));
            algoBindingSource.Add(new Algo("Qubit", 17014, "hub.miningpoolhub.com", "qubitcoin"));
            algoBindingSource.Add(new Algo("Scrypt", 17001, "hub.miningpoolhub.com", "vanilla"));
            algoBindingSource.Add(new Algo("Sia", 17022, "hub.miningpoolhub.com", "Ethash"));
            algoBindingSource.Add(new Algo("Skein", 17016, "hub.miningpoolhub.com", "skeincoin"));
            algoBindingSource.Add(new Algo("X11", 17007, "hub.miningpoolhub.com", "darkcoin-mod"));
            algoBindingSource.Add(new Algo("Yescrypt", 17021, "hub.miningpoolhub.com", "yescrypt"));

            loadFromXML();
        }

        private void coinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem, (Algo)algoComboBox.SelectedItem);
        }

        private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem, (Algo)algoComboBox.SelectedItem);
        }

        private void loginTextField_TextChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem, (Algo)algoComboBox.SelectedItem);
        }

        private void passwordTextField_TextChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem, (Algo)algoComboBox.SelectedItem);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Coin coin = (Coin)coinComboBox.SelectedItem;
            Algo algo = (Algo)algoComboBox.SelectedItem;
            Process miner = new Process();
            String fileName = null;
            String workingDirectory = null;
            int mode = modeComboBox.SelectedIndex;
            string name = "";
            if (mode == 0)
                name = coin.name;
            else
                name = algo.name;

            switch(name)
            {
                case "Zcash":
                case "Zclassic":
                case "Equihash":
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
                    break;
                case "Ethereum":
                case "Ethereum-Classic":
                case "Expanse":
                case "Siacoin":
                case "Ethash":
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
                    break;
                default:
                    workingDirectory = Environment.CurrentDirectory + "\\sgminer\\";
                    fileName = "sgminer.exe";
                    break;
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
                catch(Exception)
                {
                    resultLabel.Text = "Could not start " + fileName + " miner! Make sure it is placed in the directory: \n " + workingDirectory + "";
                }
                
            }
            
        }

        private void computeParameter(Coin coin, Server server, Algo algo)
        {
            if (coin != null && server != null)
            {
                int mode = modeComboBox.SelectedIndex;
                string port = "";
                string host = "";
                string serverLocation = "";
                string sgminerAlgo = "";
                string nameCoinAlgo = "";
                int serverSelection = serverComboBox.SelectedIndex;

                if (mode == 0)
                {
                    port = coin.port.ToString();
                    host = coin.host;
                    if (serverSelection == 0)
                        serverLocation = "us-east1";
                    else if (serverSelection == 1)
                        serverLocation = "europe1";
                    else
                        serverLocation = "asia1";
                    sgminerAlgo = coin.algorithm;
                    nameCoinAlgo = coin.name;
                }
                else if (mode == 1)
                {
                    port = algo.port.ToString();
                    host = algo.host;
                    if (serverSelection == 0)
                        serverLocation = "us-east";
                    else if (serverSelection == 1)
                        serverLocation = "europe";
                    else
                        serverLocation = "asia";
                    sgminerAlgo = algo.algorithm;
                    nameCoinAlgo = algo.name;
                }
                else
                {
                    port = algo.port.ToString().Replace("170", "120");
                    host = algo.host;
                    if (serverSelection == 0)
                        serverLocation = "us-east";
                    else if (serverSelection == 1)
                        serverLocation = "europe";
                    else
                        serverLocation = "asia";
                    sgminerAlgo = algo.algorithm;
                    nameCoinAlgo = algo.name;
                }

                
                resultLabel.Text = "Coin/Algo: " + nameCoinAlgo + "\nServer: " + serverLocation + "." + host + "\nPort: " + port + "\nLogin: " + loginTextField.Text + ":x";
                string name = "";
                if (mode == 0)
                    name = coin.name;
                else
                    name = algo.name;

                switch (name)
                {
                    case "Zcash":
                    case "Zclassic":
                    case "Equihash":
                        cpuRadioButton.Enabled = true;
                        gpuNVIDIARadioButton.Enabled = true;
                        gpuAMDRadioButton.Enabled = true;
                        sgminerRadioButton.Enabled = false;
                        if (!cpuRadioButton.Checked && !gpuAMDRadioButton.Checked && !gpuNVIDIARadioButton.Checked)
                            gpuNVIDIARadioButton.Checked = true;
                        if (cpuRadioButton.Checked)
                        {
                            paramText = "-l " + serverLocation + "." + host + ":" + port + " -u " + loginTextField.Text + " -p " + passwordTextField.Text + "";
                        }
                        else if (gpuNVIDIARadioButton.Checked)
                        {
                            paramText = "-l " + serverLocation + "." + host + ":" + port + " -u " + loginTextField.Text + " -p " + passwordTextField.Text + " -cd 0";
                        }
                        else if (gpuAMDRadioButton.Checked)
                        {
                            paramText = "-zpool " + serverLocation + "." + host + ":" + port + " -zwal " + loginTextField.Text + " -zpsw " + passwordTextField.Text + " -allpools 1";
                        }
                        break;
                    case "Ethereum":
                    case "Ethereum-Classic":
                    case "Expanse":
                    case "Ethash":
                        cpuRadioButton.Enabled = false;
                        gpuNVIDIARadioButton.Enabled = true;
                        gpuAMDRadioButton.Enabled = true;
                        sgminerRadioButton.Enabled = false;
                        if (!gpuAMDRadioButton.Checked && !gpuNVIDIARadioButton.Checked)
                            gpuAMDRadioButton.Checked = true;
                        if (gpuNVIDIARadioButton.Checked)
                        {
                            paramText = "-epool " + serverLocation + "." + host + ":" + port + " -ewal " + loginTextField.Text + " -epsw " + passwordTextField.Text + " -allpools 1";
                        }
                        else if (gpuAMDRadioButton.Checked)
                        {
                            paramText = "-epool " + serverLocation + "." + host + ":" + port + " -ewal " + loginTextField.Text + " -epsw " + passwordTextField.Text + " -allpools 1";
                        }
                        break;
                    case "Siacoin":
                    case "Sia":
                        cpuRadioButton.Enabled = false;
                        gpuNVIDIARadioButton.Enabled = true;
                        gpuAMDRadioButton.Enabled = true;
                        sgminerRadioButton.Enabled = false;
                        Coin ethCoin = new Coin("Ethereum", 20535, "ethereum.miningpoolhub.com", "Ethash", "20");
                        if (!gpuAMDRadioButton.Checked && !gpuNVIDIARadioButton.Checked)
                            gpuAMDRadioButton.Checked = true;
                        if (gpuNVIDIARadioButton.Checked)
                        {
                            paramText = "-epool " + serverLocation + "." + host + ":" + port + " -ewal " + loginTextField.Text + " -epsw " + passwordTextField.Text + " -allpools 1 -dpool stratum+tcp://" + host + ":" + port + " -dwal " + loginTextField.Text + " -dpsw " + passwordTextField.Text + " -dcoin sia";
                        }
                        else if (gpuAMDRadioButton.Checked)
                        {
                            paramText = "-epool " + serverLocation + "." + host + ":" + port + " -ewal " + loginTextField.Text + " -epsw " + passwordTextField.Text + " -allpools 1 -dpool stratum+tcp://" + host + ":" + port + " -dwal " + loginTextField.Text + " -dpsw " + passwordTextField.Text + " -dcoin sia";
                        }
                        break;
                    case "Dash":
                        sgminerRadioButton.Enabled = true;
                        cpuRadioButton.Enabled = false;
                        gpuAMDRadioButton.Enabled = false;
                        gpuNVIDIARadioButton.Enabled = false;
                        if (!sgminerRadioButton.Checked)
                            sgminerRadioButton.Checked = true;
                        paramText = "--no-retry -k " + sgminerAlgo + " -o stratum+tcp://" + serverLocation + "." + host + ":" + port + " -u " + loginTextField.Text + " -p " + passwordTextField.Text + "";
                        resultLabel.Text = "Coin/Algo: " + nameCoinAlgo + "\nServer: stratum+tcp://" + serverLocation + "." + host + "\nPort: " + port + "\nLogin: " + loginTextField.Text + ":x";
                        break;
                    case "Maxcoin":
                        sgminerRadioButton.Enabled = true;
                        cpuRadioButton.Enabled = false;
                        gpuAMDRadioButton.Enabled = false;
                        gpuNVIDIARadioButton.Enabled = false;
                        if (!sgminerRadioButton.Checked)
                            sgminerRadioButton.Checked = true;
                        paramText = "--no-retry -k " + sgminerAlgo + " -o stratum+tcp://"+ serverLocation + "." + host + ":" + port + " -u " + loginTextField.Text + " -p " + passwordTextField.Text + "";
                        resultLabel.Text = "Coin/Algo: " + nameCoinAlgo + "\nServer: stratum+tcp://"+ serverLocation + "." + host + "\nPort: " + port + "\nLogin: " + loginTextField.Text + ":x";
                        break;
                    case "Myriadcoin (Groestl)":
                        sgminerRadioButton.Enabled = true;
                        cpuRadioButton.Enabled = false;
                        gpuAMDRadioButton.Enabled = false;
                        gpuNVIDIARadioButton.Enabled = false;
                        if (!sgminerRadioButton.Checked)
                            sgminerRadioButton.Checked = true;
                        paramText = "--no-retry -k " + sgminerAlgo + " -o stratum+tcp://" + serverLocation + "." + host + ":" + port + " -u " + loginTextField.Text + " -p " + passwordTextField.Text + "";
                        resultLabel.Text = "Coin/Algo: " + nameCoinAlgo + "\nServer: stratum+tcp://" + serverLocation + "." + host + "\nPort: " + port + "\nLogin: " + loginTextField.Text + ":x";
                        break;
                    default:
                        sgminerRadioButton.Enabled = true;
                        cpuRadioButton.Enabled = false;
                        gpuAMDRadioButton.Enabled = false;
                        gpuNVIDIARadioButton.Enabled = false;
                        if (!sgminerRadioButton.Checked)
                            sgminerRadioButton.Checked = true;
                        paramText = "--no-retry -k " + sgminerAlgo + " -o stratum+tcp://" + host + ":" + port + " -u " + loginTextField.Text + " -p " + passwordTextField.Text + "";
                        resultLabel.Text = "Coin/Algo: " + nameCoinAlgo + "\nServer: stratum+tcp://" + host + "\nPort: " + port + "\nLogin: " + loginTextField.Text + ":x";
                        break;
                }
            }
            configTextBox.Text = paramText;
            startButton.Enabled = true;
            
        }

        private void cpuRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem, (Algo)algoComboBox.SelectedItem);
        }

        private void gpuAMDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem, (Algo)algoComboBox.SelectedItem);
        }

        private void gpuNVIDIARadioButton_CheckedChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem, (Algo)algoComboBox.SelectedItem);
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
                configXMLWriter.WriteElementString("mode", modeComboBox.SelectedIndex.ToString());
                configXMLWriter.WriteElementString("algo", algoComboBox.SelectedIndex.ToString());
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
                    int mode = Int32.Parse(items.Element("mode").Value);
                    modeComboBox.SelectedIndex = mode;
                    if (mode == 0)
                    {
                        algoComboBox.Enabled = false;
                        coinComboBox.Enabled = true;
                    }
                    else
                    {
                        algoComboBox.Enabled = true;
                        coinComboBox.Enabled = false;
                    }
                   algoComboBox.SelectedIndex = Int32.Parse(items.Element("algo").Value);
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

        private void coinComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem, (Algo)algoComboBox.SelectedItem);
        }

        private void serverComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem, (Algo)algoComboBox.SelectedItem);
        }

        private void configTextBox_TextChanged(object sender, EventArgs e)
        {
            paramText = configTextBox.Text;
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modeComboBox.SelectedIndex == 0)
            {
                coinComboBox.Enabled = true;
                algoComboBox.Enabled = false;
            }
            else
            {
                coinComboBox.Enabled = false;
                algoComboBox.Enabled = true;
            }
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem, (Algo)algoComboBox.SelectedItem);
        }

        private void algoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            computeParameter((Coin)coinComboBox.SelectedItem, (Server)serverComboBox.SelectedItem, (Algo)algoComboBox.SelectedItem);
        }
    }
}
