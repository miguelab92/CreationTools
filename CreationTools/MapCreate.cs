///Author: Miguel Bermudez
///Brief: Creates the outlines of a randomized map

using System;
using System.Drawing;
using System.Windows.Forms;

namespace CreationTools
{
    public partial class MapCreate : Form
    {
        //Main color selected
        Color mainColor;
        //All possible colors
        Color[] colors = new Color[5]
        {
            Color.ForestGreen,
            Color.Aqua,
            Color.Black,
            Color.Yellow,
            Color.Purple
        };
        Graphics graphic;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MapCreate()
        {
            InitializeComponent();

            //Create graphics class based on the canvas
            graphic = canvas.CreateGraphics();
        }

        /// <summary>
        /// Start button clicked
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void ssButton_Click(object sender, EventArgs e)
        {
            //If the options are valid
            if (ValidateSelections())
            {
                //Get the main color
                switch (dropList.SelectedIndex)
                {
                    case 0:
                        mainColor = colors[0]; break;
                    case 1:
                        mainColor = colors[1]; break;
                    case 2:
                        mainColor = colors[2]; break;
                    case 3:
                        mainColor = colors[3]; break;
                    default:
                        mainColor = colors[4]; break;
                }
                
                //Dispose of old graphic
                graphic.Clear(Color.White);

                //Run the drawer
                RunDrawer(int.Parse(smColorUse.Text), 
                    int.Parse(lgColorUse.Text), int.Parse(colorVariance.Text), 
                    int.Parse(runTime.Text));
            }
        }

        /// <summary>
        /// Validates Inputs
        /// </summary>
        /// <returns>Valid or not</returns>
        private bool ValidateSelections()
        {
            //Start assuming its not valid
            bool valid = false;

            //Check dropdown
            if (dropList.SelectedIndex >= 0 && dropList.SelectedIndex < 4)
            {
                //Try because of the int parse
                try
                {
                    int tempNum;
                    
                    //Check smallest color
                    tempNum = int.Parse(smColorUse.Text);
                    if (tempNum >= 0)
                    {
                        //Check largest color
                        tempNum = int.Parse(lgColorUse.Text);
                        if (tempNum >= 0 && 
                            int.Parse(smColorUse.Text) < 
                            int.Parse(lgColorUse.Text))
                        {
                            //Check color variance
                            tempNum = int.Parse(colorVariance.Text);
                            if (tempNum >=0)
                            {
                                //Check runtime
                                tempNum = int.Parse(runTime.Text);
                                if (tempNum > 0)
                                {
                                    valid = true;
                                }
                            }
                        }
                    }
                    //Ignore problems as we assume failure
                } catch {}
            }

            //If not valid then we tell the user
            if (!valid)
            {
                MessageBox.Show("Not valid");
            }

            //Return results
            return valid;
        }

        /// <summary>
        /// Run drawing animation
        /// </summary>
        private void RunDrawer(int small, int large, int var, int timeToRun)
        {
            Pen aPen = new Pen(mainColor);

            //Start in the middle
            int x1 = 150;
            int y1 = 150;

            //Random number generator
            Random rnd = new Random();
            int length;

            //While we are not closing
            while (timeToRun > 0)
            {
                //Get the next length
                length = rnd.Next(small, large);

                //Get the next color
                switch (rnd.Next(var + 4))
                {
                    case 0:
                        aPen.Color = colors[0]; break;
                    case 1:
                        aPen.Color = colors[1]; break;
                    case 2:
                        aPen.Color = colors[2]; break;
                    case 3:
                        aPen.Color = colors[3]; break;
                    case 4:
                        aPen.Color = colors[4]; break;
                    default:
                        aPen.Color = mainColor; break;
                }

                //For the length
                for (int i = 0; i < length; ++i)
                {
                    //Get new change and draw
                    GetRandomChange(ref x1, ref y1, ref rnd);
                    graphic.DrawLine(aPen, x1, y1, x1 + 1, y1 + 1);
                }

                //Decrease the time to run
                --timeToRun;
            }
        }

        /// <summary>
        /// Get a new random direction for x and y
        /// </summary>
        /// <param name="x1">x</param>
        /// <param name="y1">y</param>
        /// <param name="rnd">Random object</param>
        private void GetRandomChange( ref int x1, ref int y1, ref Random rnd)
        {
            //Get a new random number
            switch (rnd.Next(4))
            {
                case 0:
                    if (x1 < 350 && y1 < 350)
                    {
                        ++x1; ++y1;
                    }
                    break;
                case 1:
                    if (x1 < 350 && y1 > -50)
                    {
                        ++x1; --y1;
                    }
                    break;
                case 2:
                    if (x1 > -50 && y1 < 350)
                    {
                        --x1; ++y1;
                    }
                    break;
                default:
                    if (x1 > -50 && y1 > -50)
                    {
                        --x1; --y1;
                    }
                    break;
            }
        }

        /// <summary>
        /// Show the color selected
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void dropList_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorLabel.BackColor = colors[dropList.SelectedIndex];
        }
    }
}
