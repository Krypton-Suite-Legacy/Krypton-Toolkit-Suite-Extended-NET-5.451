﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.451/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace KryptonToolkitSuiteExtendedCore
{
    /// <summary>
    /// Provides a rounded <seealso cref="KryptonTextBox"/> like Google Chrome's current Omnibox design.
    /// </summary>
    [ToolboxBitmap(typeof(KryptonTextBox)), ToolboxItem(true), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All), Description("Provides a rounded textbox like Google Chrome's current Omnibox design.")]
    public class KryptonRoundedTextBox : KryptonTextBox
    {
        #region Variables
        private int _cornerRadius;
        #endregion

        #region Properties
        [Category("Appearance"), DefaultValue(25), Description("Size of corner radius. (-1 is the 'default system look' value)")]
        public int CornerRadius { get => _cornerRadius; set { _cornerRadius = value; Invalidate(); } }
        #endregion

        #region Constructor
        public KryptonRoundedTextBox()
        {
            CornerRadius = 25;

            StateCommon.Border.Rounding = CornerRadius;
        }
        #endregion

        #region Override
        protected override void OnPaint(PaintEventArgs e)
        {
            StateCommon.Border.Rounding = CornerRadius;

            base.OnPaint(e);
        }
        #endregion
    }
}