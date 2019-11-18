/*
 * Created by Ranorex
 * User: aausserhofer
 * Date: 9/17/2019
 * Time: 9:32 AM
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

namespace ModuleLibrary.Code_modules
{
    /// <summary>
    /// Description of RemoveAllEntries.
    /// </summary>
    [TestModule("6047BF50-79FB-4FF5-A7E0-CBE78DE6E7E7", ModuleType.UserCode, 1)]
    public class RemoveAllEntries : ITestModule
    {
    	
    	// Module variable to hand over the current number of database entries
   		// ===================================================================
    	string _varCurrentEntries = "0";
    	[TestVariable("885cd11c-de30-4ea0-aac7-74c1d5bcfe8b")]
    	public string varCurrentEntries
    	{
    		get { return _varCurrentEntries; }
    		set { _varCurrentEntries = value; }
    	}
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RemoveAllEntries()
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
            
            // Definition of loop variable to count down deleted database items
            // Number retrieved from string-module variable 'varCurrentEntries'
            int numberOfEntries = Convert.ToInt32(varCurrentEntries);
            
            // As long as there is a database item to delete ...
            while (numberOfEntries > 0) {
            	
            	// retrieve the text-information of the first list item
            	string delInfo = ModuleLibraryRepository.Instance.RXDemoApplication.Test_database_panel.FirstListItem.Text;
            	// write a info-log of which list item is to be deleted next
            	Report.Log(ReportLevel.Info, "Deleting " + delInfo);
            	// select the first list item
            	ModuleLibraryRepository.Instance.RXDemoApplication.Test_database_panel.FirstListItem.Select();
            	// delete the first list item
            	ModuleLibraryRepository.Instance.RXDemoApplication.Test_database_panel.Buttons.BtnRemoveEntry.Click();
            	// decrease number of items still to delete
            	numberOfEntries--;
            	
            }
            
        }
    }
}
