using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace ropingEntries
{
    public partial class Form1 : Form
    {
        List<string> headerEntries = new List<string>();
        List<string> heelerEntries = new List<string>();
        List<string> heelerEntriesTwo = new List<string>();
        List<string> myTeams = new List<string>();
        static Random rnd = new Random();
        int headerCount = 0;
        int heelerCount = 0;
        int myCount = 0;
        String firstRound;
        String partnerOne;
        String partnerTwo;

        public Form1()
        {
            headerEntries.Add("A");
            headerEntries.Add("B");
            headerEntries.Add("C");
            headerEntries.Add("D");
            headerEntries.Add("E");
            headerEntries.Add("F");
            heelerEntries.Add("G");
            heelerEntries.Add("H");
            heelerEntries.Add("I");
            heelerEntries.Add("J");
            heelerEntries.Add("K");
            heelerEntries.Add("L");
            heelerEntriesTwo.Add("G");
            heelerEntriesTwo.Add("H");
            heelerEntriesTwo.Add("I");
            heelerEntriesTwo.Add("J");
            heelerEntriesTwo.Add("K");
            heelerEntriesTwo.Add("L");

            InitializeComponent();
            comboBox1.Items.Add("Header");
            comboBox1.Items.Add("Heeler");
            using (StreamWriter writeRopers = new StreamWriter("headers.txt"))
            {
                writeRopers.Write("");
            }
            using (StreamWriter writeRopers = new StreamWriter("heelers.txt"))
            {
                writeRopers.Write("");
            }
            using (StreamWriter writeRopers = new StreamWriter("heelers2.txt"))
            {
                writeRopers.Write("");
            }
            using (StreamWriter writeRopers = new StreamWriter("myTeams.txt"))
            {
                writeRopers.WriteLine("Choose Partner Round");
                writeRopers.WriteLine("");
            }
            using (StreamWriter writerRopers = new StreamWriter("teams.txt"))
            {
                writerRopers.Write("");
            }
            /*
            using (StreamWriter writeRopers = new StreamWriter("teams.txt"))
            {
                writeRopers.Write("");
            }
            */
        }

        private void addEntry_Click(object sender, EventArgs e)
        {       
            if (entryName.Text == "")
            {
                MessageBox.Show("Please enter a name for the entrant");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a role");
                return;
            }
            if (pickPartner.Text == "")
            {
                MessageBox.Show("Please pick a partner to rope with");
                return;
            }         
            else
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    headerEntries.Add(entryName.Text);                   
                    using (StreamWriter writeRopers = File.AppendText("headers.txt"))
                    {
                        writeRopers.WriteLine(entryName.Text);
                    }
                    using (StreamWriter writeRopers = File.AppendText("teams.txt"))
                    {
                        writeRopers.WriteLine(entryName.Text + " & " + pickPartner.Text);
                    }
                    using (StreamWriter writeRopers = File.AppendText("myTeams.txt"))
                    {
                        writeRopers.WriteLine(entryName.Text + " & " + pickPartner.Text);
                    }
                    Debug.WriteLine(entryName.Text + " has been added as a header");
                    MessageBox.Show(entryName.Text + " has been added as a header, with " + pickPartner.Text + " as their heeler");
                    headerCount = headerCount + 1;
                    entryName.Clear();
                    pickPartner.Clear();
                    comboBox1.SelectedIndex = -1;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    heelerEntries.Add(entryName.Text);
                    heelerEntriesTwo.Add(entryName.Text);
                    using (StreamWriter writeRopers = File.AppendText("heelers.txt"))
                    {
                        writeRopers.WriteLine(entryName.Text);
                    }
                    using (StreamWriter writeRopers = File.AppendText("teams.txt"))
                    {
                        writeRopers.WriteLine(pickPartner.Text + " & " + entryName.Text);
                    }
                    using (StreamWriter writeRopers = File.AppendText("myTeams.txt"))
                    {
                        writeRopers.WriteLine(pickPartner.Text + " & " + entryName.Text);
                    }
                    Debug.WriteLine(entryName.Text + " has been added as a heeler");
                    MessageBox.Show(entryName.Text + " has been added as a heeler, with " + pickPartner.Text + " as their header");
                    heelerCount = heelerCount + 1;
                    entryName.Clear();
                    pickPartner.Clear();
                    comboBox1.SelectedIndex = -1;
                }
            }
        }

        private void randomEntries_Click(object sender, EventArgs e)
        {
            /*
            if(headerCount == 0)
            {
                MessageBox.Show("Please enter at least 1 header");
            }
            if (heelerCount == 0)
            {
                MessageBox.Show("Please enter at least 1 heeler");
            }
            */
            //Debug.WriteLine("Headers: ");
           
            foreach (String i in headerEntries)
            {
                int spotOne = rnd.Next(heelerEntries.Count);
                partnerOne = heelerEntries[spotOne];
                using (StreamWriter writeRopers = File.AppendText("myTeams.txt"))
                {
                    writeRopers.WriteLine(" ");
                    writeRopers.WriteLine("Draw Round One");
                    writeRopers.WriteLine(i + " & " + partnerOne);
                }
                using (StreamWriter writeRopers = File.AppendText("teams.txt"))
                {
                    writeRopers.WriteLine(i + " & " + partnerOne);
                }
                firstRound = (i + "&" + partnerOne);
                //MessageBox.Show("First Round" + firstRound);
                heelerEntries.RemoveAt(spotOne);
            }
            //this has to be own loop!
            foreach (String i in headerEntries)
            {
                int spotTwo = rnd.Next(heelerEntries.Count);
                partnerTwo = heelerEntriesTwo[spotTwo];
                String secondRound = (i + "&" + partnerTwo);
                while (firstRound.Equals(secondRound))
                {
                    //MessageBox.Show("They are the same team" + firstRound.ToString() + "------" + secondRound);
                    myCount = myCount + 1;
                    spotTwo = rnd.Next(heelerEntries.Count);
                    partnerTwo = heelerEntriesTwo[spotTwo];
                    secondRound = (i + "&" + partnerTwo);
                    if (myCount == 5)
                    {
                        MessageBox.Show("Fucked up 5 times");
                        break;
                    }                    
                }
                //MessageBox.Show("Second Round: " + secondRound);
                //MessageBox.Show(firstRound.ToString() + "------" + secondRound);
                using (StreamWriter writeRopers = File.AppendText("myTeams.txt"))
                {
                    writeRopers.WriteLine(" ");
                    writeRopers.WriteLine("Draw Round Two");
                    writeRopers.WriteLine(i + " & " + partnerTwo);
                }
                using (StreamWriter writeRopers = File.AppendText("teams.txt"))
                {
                    writeRopers.WriteLine(i + " & " + partnerTwo);
                }
                heelerEntriesTwo.RemoveAt(spotTwo);
            }           
            MessageBox.Show("Done! All teams are made!");        
        }
        private void csvExport_Click(object sender, EventArgs e)
        {
            string[] teams = File.ReadAllLines("teams.txt");
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Header, Heeler, Run 1, Run 2, Run 3, Total");
            foreach (string team in teams)
            {
                var temp = team.Split('&');
                builder.AppendLine(string.Format("{0}, {1}", temp[0], temp[1]));
            }

            File.WriteAllText("myTeams.csv", builder.ToString());
            MessageBox.Show("Files exported to CSV");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }
    }
}
