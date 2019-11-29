using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_DriodNavigation {
    public partial class Form1 : Form {
        
        //List of commands
        public static List<CommandClass> Commands = new List<CommandClass>();

        //Angle the droid is at
        private int angle = 0;
        private int previousAngle = 0;
        private bool usePreviousAngle;

        //current psotions
        private int[] positin = { 0, 0 };

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Btn_ImportFiles_Click(object sender, EventArgs e) {
            //Resets the veriables
            ResetVeriables();
            //Clears the command box
            TXT_Commands.Text = "";
            //Opens a file browser
            FileBrowser = new OpenFileDialog();
            if (FileBrowser.ShowDialog() == DialogResult.OK) {
                //Gets the file name
                string fileName = FileBrowser.FileName;
                //Gets the text from the file
                StreamReader readFile;
                readFile = new StreamReader(fileName);
                //Stores the text in a string
                string lines = readFile.ReadLine();
                //Splits the lines into commands and adds them to a list
                if (lines.Length > 0) {
                    foreach (string command in lines.Split(' ')) Commands.Add(new CommandClass(command));
                    LBL_EndLocation.Text = GiveComands(Commands);
                }   
            }
        }
        
        //Gets the commands and calls the exicution order
        public string GiveComands(List<CommandClass> list) {
            //Loops through the commands
            foreach (CommandClass c in list) {
                //Sets the angle
                determinNewDirection(c.Direction());
                //Calculates the new position
                setDriodsPosition(c.GetSetps());
                //Adds comand t the text box
                TXT_Commands.Text += c.ShowComabd() + "\n";
            }
            //Returs the new position
            return getFInalPosition(positin);
        }

        public void ResetVeriables() {
            positin[0] = 0;
            positin[1] = 0;
            angle = 0;
            previousAngle = 0;
            usePreviousAngle = false;
            Commands.Clear();
        }

        //Gets the driods final postion
        public string getFInalPosition(int[] pos) {
            return "(" + pos[0].ToString() + "," + pos[1].ToString() + ")";
        }

        //culates the direction the driod should be facing
        private void determinNewDirection(char d) {
            //Sets the previous angle to the last useed angle
            previousAngle = angle;
            //Switch based on the input
            switch (d) {
                //Left and right
                case 'L':
                    turnDroid(angle - 90);
                    usePreviousAngle = false;
                    break;
                case 'R':
                    turnDroid(angle + 90);
                    usePreviousAngle = false;
                    break;
                //North, East, South, West
                case 'N':
                    turnDroid(0);
                    usePreviousAngle = true;
                    break;
                case 'E':
                    turnDroid(90);
                    usePreviousAngle = true;
                    break;
                case 'S':
                    turnDroid(180);
                    usePreviousAngle = true;
                    break;
                case 'W':
                    turnDroid(270);
                    usePreviousAngle = true;
                    break;
                default: break;
            }
        }

        //Turns the droid
        private void turnDroid(int a) {
            //Sets the new angle
            angle = a;
            //Restricts the angle
            if (angle < 0) angle = 270;
            else if (angle > 270) angle = 0;
        }

        //Sets the driods position
        private void setDriodsPosition(int steps) {
            //Sets the position based on the current angle
            switch (angle) {
                //up and down
                case 0:
                    positin[1] = positin[1] + (steps * 1);
                    break;
                case 180:
                    positin[1] = positin[1] + (steps * -1);
                    break;
                //Left and right
                case 90:
                    positin[0] = positin[0] + (steps * 1);
                    break;
                case 270:
                    positin[0] = positin[0] + (steps * -1);
                    break;
                default: break;
            }
            //resets the angle if needed
            if (usePreviousAngle) angle = previousAngle;

        }

        private void FileBrowser_FileOk(object sender, CancelEventArgs e) {

        }
    }

    

}
