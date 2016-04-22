using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using TCD.System.TouchInjection;

namespace HydraTouch
{
    static class HydraTouch
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ControllerData.plugin.Start(); // Start the Hydra plugin

            ControllerData.controller.Add(new HydraPluginGlobal(0, ControllerData.plugin));
            ControllerData.controller.Add(new HydraPluginGlobal(1, ControllerData.plugin));

            TouchInjector.InitializeTouchInjection(256, TouchFeedback.INDIRECT); //initialize touch injection with num max touch points, indirect feedback to show hover position
            TouchActions.InitializeContacts();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Task Settings = Task.Factory.StartNew(() => Application.Run(new SettingsWindow()));
            //Task InjectTouch = Task.Factory.StartNew(() => TouchActions.Run());
            //Task.WaitAll(Settings, InjectTouch);

            Application.Run(new SettingsWindow());
        }
    }
}
