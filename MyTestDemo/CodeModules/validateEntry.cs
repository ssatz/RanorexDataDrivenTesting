/*
 * Created by Ranorex
 * User: ADMIN
 * Date: 26-06-2019
 * Time: 11:27 AM
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
    /// Description of validateEntry.
    /// </summary>
    [TestModule("AF81A1CD-E2CA-453E-A529-77FD8604643F", ModuleType.UserCode, 1)]
    public class validateEntry : ITestModule
    {
    string _itemEntry = "1";
    [TestVariable("6077a88b-20f8-497e-8257-c82e024f8d1c")]
    public string itemEntry
    {
    	get { return _itemEntry; }
    	set { _itemEntry = value; }
    }
    
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateEntry()
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
              
              if(Validate.Equals(myTest.RxMainFrame.LblNumberOfPersonsNumber.TextValue,itemEntry)){
                 	Report.Success("Validation","Correct");
                 }else{
                 	Report.Success("Validation","Entry number wrong!");
                 	               
                 }
        }
    }
}
