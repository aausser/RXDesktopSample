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
    ///The SelectGender recording.
    /// </summary>
    [TestModule("34aab7d1-0dcb-43d8-bf89-6ca0d151a5dc", ModuleType.Recording, 1)]
    public partial class SelectGender : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ModuleLibrary.ModuleLibraryRepository repository.
        /// </summary>
        public static global::ModuleLibrary.ModuleLibraryRepository repo = global::ModuleLibrary.ModuleLibraryRepository.Instance;

        static SelectGender instance = new SelectGender();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectGender()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectGender Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varGender.
        /// </summary>
        [TestVariable("febf3128-3b96-4fe7-8605-a9fa65f4b1f0")]
        public string varGender
        {
            get { return repo.varGender; }
            set { repo.varGender = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RXDemoApplication.Test_database_panel.Form_fields.RdbGender' at Center.", repo.RXDemoApplication.Test_database_panel.Form_fields.RdbGenderInfo, new RecordItemIndex(0));
            repo.RXDemoApplication.Test_database_panel.Form_fields.RdbGender.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
