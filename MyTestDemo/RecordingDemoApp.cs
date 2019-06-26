﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace MyTestDemo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RecordingDemoApp recording.
    /// </summary>
    [TestModule("59581eaf-3c21-4c9d-8c8c-7e6b8f5dcf27", ModuleType.Recording, 1)]
    public partial class RecordingDemoApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTestDemoRepository repository.
        /// </summary>
        public static MyTestDemoRepository repo = MyTestDemoRepository.Instance;

        static RecordingDemoApp instance = new RecordingDemoApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RecordingDemoApp()
        {
            varFirstName = "sathish";
            varLastName = "kumar";
            intAge = "40";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RecordingDemoApp Instance
        {
            get { return instance; }
        }

#region Variables

        string _varFirstName;

        /// <summary>
        /// Gets or sets the value of variable varFirstName.
        /// </summary>
        [TestVariable("d3e8ec62-29e7-412f-8b9e-dca4dac2a141")]
        public string varFirstName
        {
            get { return _varFirstName; }
            set { _varFirstName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable lstItem.
        /// </summary>
        [TestVariable("e49d9783-8597-4398-9376-f933573bd101")]
        public string lstItem
        {
            get { return repo.lstItem; }
            set { repo.lstItem = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable selectGender.
        /// </summary>
        [TestVariable("abc06e86-b5b0-4fcc-820f-fd7d3236b9f8")]
        public string selectGender
        {
            get { return repo.selectGender; }
            set { repo.selectGender = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varLastName.
        /// </summary>
        [TestVariable("cca52f47-baed-4306-b641-7e4ef318d590")]
        public string varLastName
        {
            get { return repo.varLastName; }
            set { repo.varLastName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable intAge.
        /// </summary>
        [TestVariable("d878cc08-93ae-4fbd-83ba-20a9570d8542")]
        public string intAge
        {
            get { return repo.intAge; }
            set { repo.intAge = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.TestDatabase' at 31;6.", repo.RxMainFrame.TestDatabaseInfo, new RecordItemIndex(0));
            repo.RxMainFrame.TestDatabase.Click("31;6");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.FirstName' at 84;11.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(1));
            repo.RxMainFrame.RxTabStandard.FirstName.Click("84;11");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varFirstName' with focus on 'RxMainFrame.RxTabStandard.FirstName'.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(2));
            repo.RxMainFrame.RxTabStandard.FirstName.PressKeys(varFirstName);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.LastName' at 33;10.", repo.RxMainFrame.RxTabStandard.LastNameInfo, new RecordItemIndex(3));
            repo.RxMainFrame.RxTabStandard.LastName.Click("33;10");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varLastName' with focus on 'RxMainFrame.RxTabStandard.LastName'.", repo.RxMainFrame.RxTabStandard.LastNameInfo, new RecordItemIndex(4));
            repo.RxMainFrame.RxTabStandard.LastName.PressKeys(varLastName);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.Open' at 7;11.", repo.RxMainFrame.RxTabStandard.OpenInfo, new RecordItemIndex(5));
            repo.RxMainFrame.RxTabStandard.Open.Click("7;11");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ProjectManagement' at 132;10.", repo.List1000.ProjectManagementInfo, new RecordItemIndex(6));
            repo.List1000.ProjectManagement.Click("132;10");
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Clear() on item 'RxMainFrame.RxTabStandard.Age'.", repo.RxMainFrame.RxTabStandard.AgeInfo, new RecordItemIndex(7));
            repo.RxMainFrame.RxTabStandard.Age.Element.InvokeActionWithText("Clear");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$intAge' with focus on 'RxMainFrame.RxTabStandard.Age'.", repo.RxMainFrame.RxTabStandard.AgeInfo, new RecordItemIndex(8));
            repo.RxMainFrame.RxTabStandard.Age.PressKeys(intAge);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.RdbFemale' at 4;8.", repo.RxMainFrame.RxTabStandard.RdbFemaleInfo, new RecordItemIndex(9));
            repo.RxMainFrame.RxTabStandard.RdbFemale.Click("4;8");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
