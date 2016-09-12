using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OpenCode_Studio
{
    public partial class Form1 : Form
    {
        string projektname = "unbekannt";
        Dictionary<string, string> fcss = new Dictionary<string, string>();
        Dictionary<string, string> lang = new Dictionary<string, string>();
        public Form1()
        {
            //projektname = "search for file";

            fcss["version"] = "0.0.0.1";
            fcss["name"] = "OpenCode Studio";
            fcss["language_name"] = "Opencode";

            lang["in_version"] = "in der Version"; //später auslagern
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AlignItems();
            //Report
            Ausgabe(fcss["name"] + " " + fcss["version"] + " " + lang["in_version"] + " " + " wurde erfolgreich geladen.", 2, Color.Green);
        }

        private void AlignItems()
        {
            mainProgress.Location = new Point(0, Form1.ActiveForm.Height);// - mainProgress.Height);
        }

        private void Ausgabe(string p, int umbruch = 1, Color? schriftfarbe = null)
        {
            if (umbruch == 1) {
                p = "\n" + p;
            }
            //Berichte.ForeColor = schriftfarbe.HasValue ? schriftfarbe.Value : Color.Black;
            //Berichte.AppendText(p);
            int start = Berichte.TextLength;
            Berichte.AppendText(p);
            int end = Berichte.TextLength;

            // Textbox may transform chars, so (end-start) != text.Length
            Berichte.Select(start, end - start);
            {
                Berichte.SelectionColor = schriftfarbe.HasValue ? schriftfarbe.Value : Color.Black;
                // could set box.SelectionBackColor, box.SelectionFont too.
            }
            Berichte.SelectionLength = 0; // clear
            Berichte.SelectionStart = Berichte.Text.Length; //Set the current caret position at the end
            Berichte.ScrollToCaret();
        }

        private void ausführenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Starten();
        }

        private void Starten()
        {
            mainProgress.Value = 0;
            //Array Befehle[];
            //Befehle[1] = "";
            Ausgabe("Projekt " + projektname + " wird gestartet.");
            mainProgress.Value = 10;
            string source = Quelltext.Text;
            Ausgabe("Quelltext eingelesen");
            mainProgress.Value = 20;

            Ausgabe(source);
            string compiled = Compile(source);
            Ausgabe(compiled);
            mainProgress.Value = 90;

            Run(compiled);
            mainProgress.Value = 100;
        }

        private string Compile(string input)
        {
            Ausgabe("kompiliere Quelltext...");

            /*Keep it SHORT*/
            //einzeilige Kommentare entfernen
            input = Regex.Replace(input, @"//.*", "");
            //mehrzeilige Kommentare entfernen
            input = Regex.Replace(input, @"\/\*((.|\n)*?)\*\/", "");
            //Umbrüche entfernen
            input = Regex.Replace(input, @"\t|\n|\r", "");
            //Leerzeichen entfernen(contraproductive)
            //input = Regex.Replace(input, @" ", "");
            Ausgabe("Source Code successfully minified");

            /*And SIMPLE*/
            //(replace foreign commands and attributes with internal, short, commands)

            Ausgabe("Source Code successfully compiled");
            return input;
        }

        private void Run(string program)
        {
            Ausgabe("Programm wird gestartet...");
            Ausgabe("--------------------------");
            int length = program.Length;
            /*Später auskommentieren*/Ausgabe("Quellcodelänge: " + length.ToString());
            for (int i = 0; i == (length - 1); i++)
            {
                string sign = program.Substring(i, 1);
                Ausgabe(sign);
                if (sign == ";") {
                    Ausgabe("Semikolon(Befehlsende) gefunden");
                }
            }
            Ausgabe("--------------------------");
            Ausgabe("Programmausführung beendet!");
            GetVersionFromRegistry();
        }

        private static void GetVersionFromRegistry()
        {
            // Opens the registry key for the .NET Framework entry.
            using (RegistryKey ndpKey =
                RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "").
                OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
            {
                // As an alternative, if you know the computers you will query are running .NET Framework 4.5 
                // or later, you can use:
                // using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, 
                // RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
                foreach (string versionKeyName in ndpKey.GetSubKeyNames())
                {
                    if (versionKeyName.StartsWith("v"))
                    {

                        RegistryKey versionKey = ndpKey.OpenSubKey(versionKeyName);
                        string name = (string)versionKey.GetValue("Version", "");
                        string sp = versionKey.GetValue("SP", "").ToString();
                        string install = versionKey.GetValue("Install", "").ToString();
                        if (install == "") //no install info, must be later.
                            Console.WriteLine(versionKeyName + "  " + name);
                        else
                        {
                            if (sp != "" && install == "1")
                            {
                                Console.WriteLine(versionKeyName + "  " + name + "  SP" + sp);
                            }

                        }
                        if (name != "")
                        {
                            continue;
                        }
                        foreach (string subKeyName in versionKey.GetSubKeyNames())
                        {
                            RegistryKey subKey = versionKey.OpenSubKey(subKeyName);
                            name = (string)subKey.GetValue("Version", "");
                            if (name != "")
                                sp = subKey.GetValue("SP", "").ToString();
                            install = subKey.GetValue("Install", "").ToString();
                            if (install == "") //no install info, must be later.
                                Console.WriteLine(versionKeyName + "  " + name);
                            else
                            {
                                if (sp != "" && install == "1")
                                {
                                    Console.WriteLine("  " + subKeyName + "  " + name + "  SP" + sp);
                                }
                                else if (install == "1")
                                {
                                    Console.WriteLine("  " + subKeyName + "  " + name);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void taschenrechnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
            //System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            //p.WaitForInputIdle();
            //NativeMethods.SetParent(p.MainWindowHandle, this.Handle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Starten();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AlignItems();
        }

        private void eingabeaufforderungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", ".");
        }

        private void noParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }
    }
}
