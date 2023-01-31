/* FormControl.cs
* Assignment 3
* Revision History
*       Xiangdong Li, 2022.11.05: Created
*       Xiangdong Li, 2022.11.06: Debugging complete
*       Xiangdong Li, 2020.11.06: Comments added
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLiQGame
{
    /// <summary>
    /// A  class that shows "Control Form" infomation.
    /// </summary>
    public partial class frmControl : Form
    {
        /// <summary>
        /// Constructor of the Control Form.
        /// </summary>
        public frmControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method executes when Design Button is clicked, 
        /// and trasnsfer to Design Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesign_Click(object sender, EventArgs e)
        {
            FormDesign frmDesign = new FormDesign();
            frmDesign.ShowDialog();
        }

        /// <summary>
        /// This method executes when Exit Button is clicked, 
        /// and the Program terminates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Showing the result on a MessageBox for user options
            if (MessageBox.Show("Are you sure you want quit QGame?", 
                "QGame", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }  
        }

        /// <summary>
        /// This method executes when Play Button is clicked, 
        /// and trasnsfer to Play Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormPlay formPlay = new FormPlay();
            formPlay.ShowDialog();
            
        }
    }
}
