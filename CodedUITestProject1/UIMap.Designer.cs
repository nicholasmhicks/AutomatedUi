﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod2
        /// </summary>
        public void RecordedMethod2()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            #endregion

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(33, 2));

            // Click 'CheckBox' check box
            Mouse.Click(uICheckBoxCheckBox, new Point(6, 4));
        }
        
        /// <summary>
        /// RecordedMethod3 - Use 'RecordedMethod3Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod3()
        {
            #region Variable Declarations
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            #endregion

            // Click 'CheckBox' check box
            Mouse.Click(uICheckBoxCheckBox, new Point(10, 6));

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(40, 9));

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.RecordedMethod3Params.UICheckBoxCheckBoxChecked;
        }
        
        /// <summary>
        /// RecordedMethod4
        /// </summary>
        public void RecordedMethod4()
        {
            #region Variable Declarations
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            #endregion

            // Click 'CheckBox' check box
            Mouse.Click(uICheckBoxCheckBox, new Point(6, 7));

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(35, 4));

            // Click 'CheckBox' check box
            Mouse.Click(uICheckBoxCheckBox, new Point(9, 7));
        }
        
        #region Properties
        public virtual RecordedMethod3Params RecordedMethod3Params
        {
            get
            {
                if ((this.mRecordedMethod3Params == null))
                {
                    this.mRecordedMethod3Params = new RecordedMethod3Params();
                }
                return this.mRecordedMethod3Params;
            }
        }
        
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod3Params mRecordedMethod3Params;
        
        private UIMainWindowWindow mUIMainWindowWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod3'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class RecordedMethod3Params
    {
        
        #region Fields
        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfCheckBox UICheckBoxCheckBox
        {
            get
            {
                if ((this.mUICheckBoxCheckBox == null))
                {
                    this.mUICheckBoxCheckBox = new WpfCheckBox(this);
                    #region Search Criteria
                    this.mUICheckBoxCheckBox.SearchProperties[WpfCheckBox.PropertyNames.AutomationId] = "checkBox1";
                    this.mUICheckBoxCheckBox.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUICheckBoxCheckBox;
            }
        }
        
        public WpfButton UIStartButton
        {
            get
            {
                if ((this.mUIStartButton == null))
                {
                    this.mUIStartButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "button1";
                    this.mUIStartButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIStartButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfCheckBox mUICheckBoxCheckBox;
        
        private WpfButton mUIStartButton;
        #endregion
    }
}