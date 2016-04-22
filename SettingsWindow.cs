using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Windows;

namespace HydraTouch
{

    public partial class SettingsWindow : Form
    {
        // Global variables
        public bool allowFormClose = false;
        public static string[] debugText = new string[] {"", "", "none", "none"};
        public static int debugCounter = 0;
        public static bool running = false;

        private const int LEFT = 0;
        private const int RIGHT = 1;

        
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            //hideSettings(); // minimize settings window to tray
        }

        //show settings window
        private void showSettings()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        //minimize settings window to tray
        private void hideSettings()
        {
            this.Hide();
            this.ShowInTaskbar = false;
        }

        //tray icon is double clicked (left mouse)
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            showSettings();
        }

        //"Settings" from tray icon menu
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showSettings();
        }

        //"Exit HydraTouch" from tray icon menu
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            allowFormClose = true;
            this.Close();
        }

        //if settings window is closed, minimize to tray instead
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowFormClose)
            {
                e.Cancel = true;
                hideSettings();
            }
        }

        //exit button
        private void button1_Click(object sender, EventArgs e)
        {
            allowFormClose = true;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ControllerData.UpdateAllData();

            TouchActions.Run();


            for (int i = 0; i < ControllerData.controller.Count(); i++)
            {
             debugText[i] = "side: " + ControllerData.controller[i].side + "\n\n" +

             "X: " + ControllerData.controller[i].x + 
             "\nY: " + ControllerData.controller[i].y + 
             "\nZ: " + ControllerData.controller[i].z + "\n\n" +

             "q0: " + ControllerData.controller[i].q0 + 
             "\nq1: " + ControllerData.controller[i].q1 + 
             "\nq2: " + ControllerData.controller[i].q2 + 
             "\nq3: " + ControllerData.controller[i].q3 + "\n\n" +

             "yaw: " + ControllerData.controller[i].yaw + 
             "\npitch: " + ControllerData.controller[i].pitch + 
             "\nroll: " + ControllerData.controller[i].roll + "\n\n" +

             "joyX: " + ControllerData.controller[i].joyx + 
             "\njoyY: " + ControllerData.controller[i].joyy + "\n\n" +

             "joybutton: " + ControllerData.controller[i].joybutton +
             "\ntrigger: " + ControllerData.controller[i].trigger + 
             "\nbumper: " + ControllerData.controller[i].bumper + 
             "\nstart: " + ControllerData.controller[i].start + "\n\n" +

             "one: " + ControllerData.controller[i].one + 
             "\ntwo: " + ControllerData.controller[i].two + 
             "\nthree: " + ControllerData.controller[i].three + 
             "\nfour: " + ControllerData.controller[i].four + "\n\n" +

             "docked: " + ControllerData.controller[i].docked;


            }

            lblDebug0.Text = debugText[0];
            lblDebug1.Text = debugText[1];
            lblDebug2.Text = debugCounter + "\n" + debugText[2];
            lblDebug3.Text = debugText[3];

            //label1.Text = ControllerData.rotMat[1].M11 + "   " + ControllerData.rotMat[1].M12 + "   " + ControllerData.rotMat[1].M13 + "\n" +
            //                ControllerData.rotMat[1].M21 + "   " + ControllerData.rotMat[1].M22 + "   " + ControllerData.rotMat[1].M23 + "\n" +
            //                ControllerData.rotMat[1].M31 + "   " + ControllerData.rotMat[1].M32 + "   " + ControllerData.rotMat[1].M33;
        }
    }
}
