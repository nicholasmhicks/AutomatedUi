namespace CodedUITestProject2
{
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

    public partial class UIMap
    {
        public UIMap()
        {
            this.UIMainWindowWindow.UIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
        }
        /// <summary>
        /// SimpleTestApp - Use 'SimpleTestAppParams' to pass parameters into this method.
        /// </summary>
        public void ModifiedSimpleAppTest()
        {
            #region Variable Declarations
            WpfButton uIStartButton = this.UIMainWindowWindow.UIStartButton;
            WpfCheckBox uICheckBoxCheckBox = this.UIMainWindowWindow.UICheckBoxCheckBox;
            #endregion

            // Click 'Start' button
            Mouse.Click(uIStartButton, new Point(27, 9));

            uICheckBoxCheckBox.WaitForControlEnabled();

            // Select 'CheckBox' check box
            uICheckBoxCheckBox.Checked = this.SimpleTestAppParams.UICheckBoxCheckBoxChecked;
        }

        public virtual SimpleTestAppParams SimpleTestAppParams
        {
            get
            {
                if ((this.mSimpleTestAppParams == null))
                {
                    this.mSimpleTestAppParams = new SimpleTestAppParams();
                }
                return this.mSimpleTestAppParams;
            }
        }

        private SimpleTestAppParams mSimpleTestAppParams;
    }
    /// <summary>
    /// Parameters to be passed into 'SimpleTestApp'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SimpleTestAppParams
    {

        #region Fields
        /// <summary>
        /// Select 'CheckBox' check box
        /// </summary>
        public bool UICheckBoxCheckBoxChecked = true;
        #endregion
    }
}
