/*
 * Created by Ranorex
 * User: ADMIN
 * Date: 26-06-2019
 * Time: 11:21 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyTestDemo.CodeModules
{
    /// <summary>
    /// Description of addEntry.
    /// </summary>
    [TestModule("C7262A48-AB4E-4911-868D-5826B6B4D2E4", ModuleType.UserCode, 1)]
    public class addEntry : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public addEntry()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            MyTestDemoRepository myTest = new MyTestDemoRepository();
            var button = myTest.RxMainFrame.BtnAddPerson;
            button.Click();
        }
    }
}
