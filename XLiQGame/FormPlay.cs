/* FormPlay.cs
* Assignment 3
* Revision History
*       Xiangdong Li, 2022.12.02: Created
*       Xiangdong Li, 2022.12.02: Debugging complete
*       Xiangdong Li, 2020.12.02: Comments added
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace XLiQGame
{
    /// <summary>
    /// A  class that shows "Play Form" infomation.
    /// Invoked by click the Play button of Control Panel Form
    /// </summary>
    public partial class FormPlay : Form
    {
        //declare images
        Image wall = Properties.Resources.Wall;
        Image redDoor = Properties.Resources.Red_Door;
        Image greenDoor = Properties.Resources.Green_Door;
        Image redBox = Properties.Resources.Red_Box;
        Image greenBox = Properties.Resources.Green_Box;

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

        // Declaring constant & variables.
        const int TILE_WIDTH = 60;
        const int TILE_HEIGHT = 60;
        const int INIT_LEFT = 50;
        const int INIT_TOP = 50;
        public int numOfBoxes;
        public int numOfMoves;
        public PictureBox currentTile;
        public int currentRow;
        public int currentCol;
        public Tile getDoor;
        int qtyRow;
        int qtyCol;

        /// <summary>
        /// Constructor of the Play Form.
        /// </summary>
        public FormPlay()
        {
            InitializeComponent();
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            txtRemaningBoxes.Text = numOfBoxes.ToString();
            txtMoves.Text = numOfMoves.ToString();
        }

        /// <summary>
        /// method for loading a level saved in text file
        /// </summary>
        /// <param name="fileName"></param>
        private void load(string fileName)
        {
            try
            {
                using (var reader = new StreamReader(fileName))
                {
                    qtyRow = int.Parse(reader.ReadLine());
                    qtyCol = int.Parse(reader.ReadLine());
                    int totalTiles = qtyRow * qtyCol;

                    Tiles = new Tile[qtyRow, qtyCol];
                    PictureBoxes = new PictureBox[qtyRow, qtyCol];

                    for (int i = 0; i < totalTiles; i++)
                    {
                        int row = int.Parse(reader.ReadLine());
                        int col = int.Parse(reader.ReadLine());
                        int tileType = int.Parse(reader.ReadLine());

                        //count numbers of box
                        switch ((Tile)tileType)
                        {
                            case Tile.RedBox:
                                this.numOfBoxes++;
                                break;
                            case Tile.GreenBox:
                                this.numOfBoxes++;
                                break;
                        }

                        //Setting each PictureBox
                        PictureBox pb = new PictureBox();
                        pb.Location = new Point(TILE_WIDTH * col + INIT_LEFT, TILE_HEIGHT * row + INIT_TOP);
                        pb.Size = new Size(TILE_WIDTH, TILE_WIDTH);
                        pb.Image = Images((Tile)tileType);
                        pb.BorderStyle = BorderStyle.None;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;

                        Point point = new Point(col, row);
                        pb.Tag = point;
                        pb.Click += PictureBox_Click;

                        Tiles[row, col] = (Tile)tileType;
                        PictureBoxes[row, col] = pb;

                        this.pnlGame.Controls.Add(pb);
                    }

                    txtRemaningBoxes.Text = numOfBoxes.ToString();

                    btnUp.Enabled = true;
                    btnDown.Enabled = true;
                    btnLeft.Enabled = true;
                    btnRight.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to load game, please laod correct game file",
                    "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// return image type for each enum type
        /// </summary>
        /// <param name="tile"></param>
        /// <returns></returns>
        private Image Images(Tile tile)
        {
            switch ((Tile)tile)
            {
                case Tile.Wall:
                    return wall;
                case Tile.RedDoor:
                    return redDoor;
                case Tile.GreenDoor:
                    return greenDoor;
                case Tile.RedBox:
                    return redBox;
                case Tile.GreenBox:
                    return greenBox;
                default:
                    return null;
            }
        }

        /// <summary>
        /// initialize game for remove all picture boxes when game over 
        /// and ready to load another level
        /// </summary>
        private void initializeGame()
        {
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;

            this.currentTile = null;
            this.currentRow = 0;
            this.currentCol = 0;
            this.getDoor = Tile.None;

            this.numOfBoxes = 0;
            this.numOfMoves = 0;

            txtRemaningBoxes.Text = numOfBoxes.ToString();
            txtMoves.Text = numOfMoves.ToString();

            this.Tiles = null;

            if (this.PictureBoxes != null)
            {
                foreach (var picture in PictureBoxes)
                {
                    if (picture != null)
                    {
                        this.Controls.Remove(picture);
                        picture.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// loading level text file whem click on load from Menue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initializeGame();
            DialogResult dialogResult = dlgOpen.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                load(dlgOpen.FileName);
            }
        }

        /// <summary>
        /// This method executes when each PictureBox is clicked, 
        /// and click game pad for moving Green Box and Red Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            pb.BorderStyle = BorderStyle.Fixed3D;
            Point point = (Point)pb.Tag;

            if (this.Tiles[point.Y, point.X] == Tile.GreenBox || this.Tiles[point.Y, point.X] == Tile.RedBox)
            {

                if (currentTile != null)
                {
                    currentTile.BorderStyle = BorderStyle.None;
                }
                else
                {
                    pb.BorderStyle = BorderStyle.Fixed3D;
                }

                //col = X, row = Y
                currentTile = pb;
                currentRow = point.Y;
                currentCol = point.X;

                if (this.Tiles[point.Y, point.X] == Tile.RedBox)
                {
                    getDoor = Tile.RedDoor;
                }
                else
                {
                    getDoor = Tile.GreenDoor;
                }
            }
            else
            {
                MessageBox.Show("Click a box to start", "QGame",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        /// <summary>
        /// control pad of 4 buttons (Left, Right, Up, Down) for user click to control 
        /// Green boxes and red boxex move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controlPad_Click(object sender, EventArgs e)
        {
            if (currentTile == null)
            {
                MessageBox.Show("Click a box to start", "QGame",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Button button = (Button)sender;

            numOfMoves++;
            txtMoves.Text = numOfMoves.ToString();

            bool isMatched = false;
            int newRow, newCol;

            newRow = currentRow;
            newCol = currentCol;

            if (button.Text == "Up")
            {
                for (newRow--; newRow >= 0; newRow--)
                {
                    if (this.Tiles[newRow, newCol] == getDoor)
                    {
                        isMatched = true;
                        break;
                    }
                    else if (this.Tiles[newRow, newCol] != Tile.None)
                    {
                        newRow++;
                        break;
                    }
                }
                newRow = Math.Max(newRow, 0);
            }
            else if (button.Text == "Down")
            {
                for (newRow++; newRow < qtyRow; newRow++)
                {
                    if (this.Tiles[newRow, newCol] == getDoor)
                    {
                        isMatched = true;
                        break;
                    }
                    else if (this.Tiles[newRow, newCol] != Tile.None)
                    {
                        newRow--;
                        break;
                    }
                }
                newRow = Math.Min(newRow, qtyRow -1);
            }
            else if (button.Text == "Left")
            {
                for (newCol--; newCol >= 0; newCol--)
                {
                    if (this.Tiles[newRow, newCol] == getDoor)
                    {
                        isMatched = true;
                        break;
                    }
                    else if (this.Tiles[newRow, newCol] != Tile.None)
                    {
                        newCol++;
                        break;
                    }
                }
                newCol = Math.Max(newCol, 0);
            }
            else if (button.Text == "Right")
            {
                for (newCol++; newCol < qtyCol; newCol++)
                {
                    if (this.Tiles[newRow, newCol] == getDoor)
                    {
                        isMatched = true;
                        break;
                    }
                    else if (this.Tiles[newRow, newCol] != Tile.None)
                    {
                        newCol--;
                        break;
                    }
                }
                newCol = Math.Min(newCol, qtyCol - 1);
            }

            if (isMatched)
            {
                this.numOfBoxes--;
                txtRemaningBoxes.Text = this.numOfBoxes.ToString();
                this.Tiles[currentRow, currentCol] = Tile.None;

                this.PictureBoxes[currentRow, currentCol].Image = Images(Tile.None);
                this.PictureBoxes[currentRow, currentCol].BorderStyle = BorderStyle.None;
                this.currentTile = null;

                if (this.numOfBoxes == 0)
                {
                    MessageBox.Show("Congratulations! The game over!", "QGame",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    initializeGame();
                    return;
                }
            }
            else if (currentRow != newRow || currentCol != newCol)
            {
                this.Tiles[newRow, newCol] = this.Tiles[currentRow, currentCol];
                this.Tiles[currentRow, currentCol] = Tile.None;

                this.PictureBoxes[newRow, newCol].Image = this.PictureBoxes[currentRow, currentCol].Image;

                this.PictureBoxes[currentRow, currentCol].Image = Images(Tile.None);
                this.PictureBoxes[currentRow, currentCol].BorderStyle = BorderStyle.None;

                currentTile = this.PictureBoxes[newRow, newCol];
                this.PictureBoxes[newRow, newCol].BorderStyle = BorderStyle.Fixed3D;
                currentRow = newRow;
                currentCol = newCol;
            }
        }
        
        /// <summary>
        /// This method executes when Close under Menu is clicked, 
        /// and the Design Form terminates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Showing the result on a MessageBox user options
            if (MessageBox.Show("Are you sure you want close Play Form?",
                "Play Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
