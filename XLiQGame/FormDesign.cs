/* FormDesign.cs
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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XLiQGame
{
    /// <summary>
    /// A  class that shows "Design Form" infomation.
    /// </summary>
    public partial class FormDesign : Form
    {
        /// <summary>
        /// Declaring Class enum (a group of constants) for assign a interger fot each button tool.
        /// </summary>
        public enum Tile
        {
            None = 0,
            Wall = 1,
            RedDoor = 2,
            GreenDoor = 3,
            RedBox = 6,
            GreenBox = 7
        }

        // Declaring 2D arrays for dynamic PitureBoxes.
        private Tile[,] Tiles;
        private PictureBox[,] PictureBoxes;

        // Declaring array for box_Content each type of Images.
        public int[] CountImages = new int[5];

        // Declaring constant & variables.
        const int TILE_WIDTH = 60;
        const int TILE_HEIGHT = 60;
        const int INIT_LEFT = 140;
        const int INIT_TOP = 140;
        public Tile selectedBox = Tile.None;

        /// <summary>
        /// Constructor of the Design Form.
        /// </summary>
        public FormDesign()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method executes when Generate Button is clicked, 
        /// and generate dynamic PictureBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Error handling for user input invalid format 
            try
            {
                int row = int.Parse(txtRow.Text);
                int col = int.Parse(txtColumn.Text);

                Tiles = new Tile[row, col];
                PictureBoxes = new PictureBox[row, col];

                //For loop for 2D grid of PictureBoxes
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Tiles[i, j] = Tile.None;

                        //Setting each PictureBox
                        PictureBox pb = new PictureBox();
                        pb.Location = new Point(TILE_WIDTH * (j + 1) + INIT_LEFT, TILE_HEIGHT * i + INIT_TOP);
                        pb.Size = new Size(TILE_WIDTH, TILE_WIDTH);
                        pb.Image = null;
                        pb.BorderStyle = BorderStyle.Fixed3D;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;

                        //Determine which PictureBox is clicked
                        Point point = new Point(i, j);
                        pb.Tag = point;
                        pb.Click += PictureBox_Click;

                        //Add each PictureBox
                        Controls.Add(pb);

                        PictureBoxes[i, j] = pb;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please provide valid data for rows and columns (Both must be intergers)",
                    "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method for each button tool return to each image and counting clicks
        /// </summary>
        /// <returns></returns>
        private Image getCurrentBoxImage()
        {
            switch (this.selectedBox)
            {
                case Tile.None:
                    return null;
                case Tile.Wall:
                    return imageList1.Images[1];
                case Tile.RedDoor:
                    return imageList1.Images[2];
                case Tile.GreenDoor:
                    return imageList1.Images[3];
                case Tile.RedBox:
                    return imageList1.Images[4];
                case Tile.GreenBox:
                    return imageList1.Images[5];
                default:
                    return null;
            }
        }

        /// <summary>
        /// This method executes when each PictureBox is clicked, 
        /// and recently selected tool’s image will show up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Click(object sender, EventArgs e)
        {
            //Combine PictureBoxes to one Click event
            PictureBox p = (PictureBox)sender;

            //Get position of the clicked PictureBox object
            Point point = (Point)p.Tag;

            //Set object in PictureBoxes
            p.Image = getCurrentBoxImage();
            this.Tiles[point.X, point.Y] = this.selectedBox;
        }

        /// <summary>
        /// This method executes when Save under File menu is clicked, 
        /// save the design level as a txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgSave.Filter = "Text File|*.QGAME|all files|*.*";
            DialogResult result = dlgSave.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Error handling for user input empty
                try
                {
                    int row = int.Parse(txtRow.Text);
                    int column = int.Parse(txtColumn.Text);

                    //Local variables.
                    int box_Content = 0;

                    StreamWriter writer = new StreamWriter(dlgSave.FileName);
                    writer.WriteLine(row + "\n" + column);

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            //Counting numbers of each image
                            box_Content = (int)Tiles[i, j];
                            if (box_Content == 1)
                            {
                                this.CountImages[0]++;
                            }
                            else if (box_Content == 2)
                            {
                                this.CountImages[1]++;
                            }
                            else if (box_Content == 3)
                            {
                                this.CountImages[2]++;
                            }
                            else if (box_Content == 6)
                            {
                                this.CountImages[3]++;
                            }
                            else if (box_Content == 7)
                            {
                                this.CountImages[4]++;
                            }

                            writer.WriteLine($"{i}\n{j}\n{(int)Tiles[i, j]}");
                        }
                    }

                    writer.Close();

                    // Showing the result on a MessageBox
                    MessageBox.Show("File saved successfully: \n" +
                                    $"Total Number of Walls: {this.CountImages[0]}\n" +
                                     $"Total Number of Doors: {this.CountImages[1] + this.CountImages[2]}\n" +
                                      $"Total Number of boxes: {this.CountImages[3] + this.CountImages[4]}\n",
                                    "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error in file save! Please save all QGame design information!",
                        "QGame", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// This method executes when any Toll Button is clicked, 
        /// and assign interger value for which button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTool_Click(object sender, EventArgs e)
        {
            //Combine Tool Button to one Click event
            Button btn = (Button)sender;

            if (btnNone.Focused)
            {
                this.selectedBox = Tile.None;
            }
            else if (btnWall.Focused)
            {
                this.selectedBox = Tile.Wall;
            }
            else if (btnRedDoor.Focused)
            {
                this.selectedBox = Tile.RedDoor;
            }
            else if (btnGreenDoor.Focused)
            {
                this.selectedBox = Tile.GreenDoor;
            }
            else if (btnRedBox.Focused)
            {
                this.selectedBox = Tile.RedBox;
            }
            else if (btnGreenBox.Focused)
            {
                this.selectedBox = Tile.GreenBox;
            }

            ImageList.ImageCollection images = imageList1.Images;
        }

        /// <summary>
        /// This method executes when Close under File Menu is clicked, 
        /// and the Design Form terminates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Showing the result on a MessageBox user options
            if (MessageBox.Show("Are you sure you want close Design Form?",
                "Design Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
