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

namespace ModuleLibrary.Recording_modules.Database
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InsertFirstName recording.
    /// </summary>
    [TestModule("03699524-49a8-4b4f-9c27-84e52ea6b449", ModuleType.Recording, 1)]
    public partial class InsertFirstName : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ModuleLibrary.ModuleLibraryRepository repository.
        /// </summary>
        public static global::ModuleLibrary.ModuleLibraryRepository repo = global::ModuleLibrary.ModuleLibraryRepository.Instance;

        static InsertFirstName instance = new InsertFirstName();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertFirstName()
        {
            varFirstName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsertFirstName Instance
        {
            get { return instance; }
        }

#region Variables

        string _varFirstName;

        /// <summary>
        /// Gets or sets the value of variable varFirstName.
        /// </summary>
        [TestVariable("b410c6e5-e0e9-4c4f-9b2b-7adf7e08d114")]
        public string varFirstName
        {
            get { return _varFirstName; }
            set { _varFirstName = value; }
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RXDemoApplication.Test_database_panel.Form_fields.TxtFirstName' at Center.", repo.RXDemoApplication.Test_database_panel.Form_fields.TxtFirstNameInfo, new RecordItemIndex(0));
            repo.RXDemoApplication.Test_database_panel.Form_fields.TxtFirstName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varFirstName' with focus on 'RXDemoApplication.Test_database_panel.Form_fields.TxtFirstName'.", repo.RXDemoApplication.Test_database_panel.Form_fields.TxtFirstNameInfo, new RecordItemIndex(1));
            repo.RXDemoApplication.Test_database_panel.Form_fields.TxtFirstName.PressKeys(varFirstName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
