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
using System.Xml.Linq;

namespace X4SkillBooster
{
    public partial class Form1 : Form
    {
        string file;
        XElement xml;
        public Form1()
        {
            InitializeComponent();
            this.Text = "X4 Skill Booster";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Prepare and present file picker
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Uncompressed X4 Save|*.xml";
            openFileDialog1.Title = "Select X4 Save...";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                try
                {
                    textBox1.Text = "Opening "+ file + ". Please wait...";
                    textBox1.Update();
                    xml = XElement.Load(file);
                    textBox1.AppendText(Environment.NewLine+"Save loaded. Click \"Boost!\" to continue.");
                    button2.Enabled = true;
                }
                catch (IOException)
                {
                }
                catch (System.Xml.XmlException)
                {
                    MessageBox.Show("Non-XML file selected. Are you sure you selected an uncompressed X4 Foundations save file?",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            textBox1.AppendText(Environment.NewLine + "Boosting employee skills...");
            textBox1.Update();
            String timeStamp = DateTime.Now.ToString("yyyyMMddHHmm");
            xml.Save(file + "." + timeStamp);
            textBox1.AppendText(Environment.NewLine + "Backed up save file as "+ file + "." + timeStamp);
            textBox1.Update();
            ScanSkills(xml.Elements(), 0);
            xml.Save(file);
            textBox1.AppendText(Environment.NewLine + "Boosting complete. Enjoy!");
            MessageBox.Show("Boosting complete. Enjoy!",
                "Boosting complete.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private static void ScanSkills(IEnumerable<XElement> elements, int layer)
        {
            foreach (var element in elements)
            {
                if (element.HasAttributes)
                {
                    foreach (var attribute in element.Attributes())
                    {
                        if (attribute.Name == "owner" && attribute.Value == "player")
                        {
                            if (element.HasElements)
                            {
                                Boost(element.Elements(), layer + 1);
                            }
                        }
                    }
                }

                if (element.HasElements)
                {
                    ScanSkills(element.Elements(), layer + 1);
                }
            }
        }

        private static void Boost(IEnumerable<XElement> elements, int layer)
        {
            foreach (var element in elements)
            {
                if (element.Name == "skill")
                {
                    foreach (var attribute in element.Attributes())
                    {
                        if (attribute.Name == "value")
                        {
                            attribute.Value = "15";
                        }
                    }
                }
                if (element.HasElements)
                {
                    Boost(element.Elements(), layer + 1);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/zyamada/x4skillbooster");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't open link. Please visit https://github.com/zyamada/x4skillbooster.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
