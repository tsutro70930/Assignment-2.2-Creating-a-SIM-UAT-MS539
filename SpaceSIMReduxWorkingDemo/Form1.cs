using SpaceSIMNavagation_controls;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace SpaceSIMReduxWorkingDemo
{
    public partial class Form1 : Form
    { //variables and object declarations for the classes that will be used in the click events of the buttons to display the planet pictures and resources in the list boxes and picture box. These classes will be created in the SpaceSIMNavigation_controls DLL and will have methods that will be called in the click events of the buttons in Form1.cs to display the planet pictures and resources.

        // CardControls object_Yardrat = new CardControls();
        //CardControls object_Earth = new CardControls();
        //  CardControls object_heKindom = new CardControls();




        public Form1()
        {
            InitializeComponent();

            //BACKGROUND IMAGE
            // Set the background image to a space-themed image from resources
            this.BackgroundImage = Properties.Resources.space_background;
            // Set the background image layout to stretch to fill the form.
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //Double-click handler so a file name in the list becomes clickable.
            //this.yardratBoxListBox.DoubleClick += yardratBoxListBox_DoubleClick;

        }
        //fIRST BUTTON ACTIONS
        private void yardrat_Click(object sender, EventArgs e)
        //Variables
        //var planetInfo = Properties.Resources.ReadMeYardrat; // This will be the text from the read me file that will be displayed in the list box when the yardrat button is clicked.

        {//Function DLL class call plan
         //Call Method from DLL CLass that will display the yardrat planet picture in the piccture box and display the resources in a label or text box.
         //Call Method from DLL 

            //To be called in clear class and put as a single class method call for earch button to clear the UI
            //Clear the yardrat planet picture from the picture box and clear the resources from the list box when the yardrat button is clicked again.
            pictureBox1.Image = null;// Clear the picture box by setting the image to null.
            yardratBoxListBox.Items.Clear();// Clear the list box by clearing all items.
            textBox1.Clear();// Clear the text box by clearing all text.




            //Preliminary class code
            //Call my class CardConrol method m from my SpaceSIMNavigation controls DLL that will display the yardrat planet picture and resources.
            // object_Yardrat.DisplayYardratInfo(pictureBox1, yardratBoxListBox);

            //Functional code to be moved to classes later, I will be doing with all utilities. Functionality then Class structure So as to find unifying Methods and properties for the classes.
            //For now, this is just a placeholder to test the button click event and display the yardrat planet picture and resources.
            //Display yardrat planet picture in picture box and fill the Planet species Image with the read me file that will both be clickable and dispayed one in the image box and one in the list view.
            pictureBox1.Image = Properties.Resources.Sunset_on_Mars;
            //pictureBox1.Image = Image.FromFile("sunset_on_mars.png"); Other strategy tried but did not work, reasources folder access is a better way
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;// Set the size mode to stretch the image to fit the picture box.

            //Display yardrat planet resources in list box
            yardratBoxListBox.Items.Clear();// Clear the list box before adding new items.
            yardratBoxListBox.Items.Add("Planet Info");
            //yardratBoxListBox.Items.Add("ReadMeYardrat.txt");
            yardratBoxListBox.Items.Add("Known Species");


            //the next line will add the text from the reade file to the list box or the text box depending on which one i can get to work.
            //  listBox2.Items.Add(Properties.Resources.ReadMeYardrat);


            //  textBox1.Text = Properties.Resources.ReadMeYardrat; // Set the text of the text box to the text from the read me file.
            textBox1.ReadOnly = true; // Set the text box to read-only so the user cannot edit the text from the read me file.

            //


            //Display yardrat planet resources in label

            //   listBox1.di = Properties.Resources.ReadMeYardrat;
            //label1.Text = "Yardrat Planet Resources:\n- Gravity Control\n- Time Manipulation\n- Space-Time Distortion";// 
        }
        //This is for the second action for the yardrat button....not sure if I am saying thay right.
        private void yardratBoxListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = yardratBoxListBox.SelectedItem.ToString();

            if (selectedItem == "Planet Info")
            {
                textBox1.Text = Properties.Resources.ReadMeYardrat;

            }
            else if (selectedItem == "Known Species")
            {
                pictureBox1.Image = Properties.Resources.Goku;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }



        //Now the strucrure for final class design and implementaion of DLL methods for the use of accomplishing the logic for the 
        //--------------------------------------------------------------------------

        //SECOND BUTTON ACTIONS
        private void button3_Click(object sender, EventArgs e)//Earth Button
        {
            ///Clearing all windows upon button click.

            //To be called in clear class and put as a single class method call for earch button to clear the UI
            //Clear the yardrat planet picture from the picture box and clear the resources from the list box when the yardrat button is clicked again.
            pictureBox1.Image = null;// Clear the picture box by setting the image to null.
            listBoxLandOfWater.Items.Clear();//Celar the list bos by clearing all itmes.
            listBoxEarth.Items.Clear();//Clear the list list box by clearing all items.
            yardratBoxListBox.Items.Clear();// Clear the list box by clearing all items.
            textBox1.Clear();// Clear the text box by clearing all text.

            ///Load resources for the button click
            ///

            //Load picureBox
            pictureBox1.Image = Properties.Resources.Sunset_on_Mars;//remember to add other planet photo resource.
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //Display yardrat planet resources in list box
            listBoxEarth.Items.Clear();// Clear the list box before adding new items.
            listBoxEarth.Items.Add("Planet Info");
            //yardratBoxListBox.Items.Add("ReadMeYardrat.txt");
            listBoxEarth.Items.Add("Known Species");

            textBox1.ReadOnly = true; // Set the text box to read-only so the user cannot edit the text from the read me file.
        }

        //This is for the second action for the earth button....not sure if I am saying thay right.
        private void listBoxEarth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBoxEarth.SelectedItem.ToString();

            if (selectedItem == "Planet Info")
            {
                textBox1.Text = Properties.Resources.ReadMeEarth;

            }
            else if (selectedItem == "Known Species")
            {
                pictureBox1.Image = Properties.Resources.Wolverine;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

 
        //-----------------------------------------------------------------------------


        //secrte level that displays the solar system with the kindom in it, gear the click to swap between the 
        //two cards but it will be rabit in the hat, will switch to another card with a single button and a picure with the textbox in the same spot and then it will switch back when clicked again.
        //private void textBox1_TextChanged(object sender, EventArgs e)
        // {

        // }
        //------------------------------------------------------------------------------


        //THIRD BUTTON ACTIONS
       private void buttonOnePiece_Click(object sender, EventArgs e)//Land of water button
        {
            ///Clearing all windows upon button click.

            //To be called in clear class and put as a single class method call for earch button to clear the UI
            //Clear the yardrat planet picture from the picture box and clear the resources from the list box when the yardrat button is clicked again.
            pictureBox1.Image = null;// Clear the picture box by setting the image to null.
            listBoxLandOfWater.Items.Clear();//Celar the list bos by clearing all itmes.
            listBoxEarth.Items.Clear();//Clear the list list box by clearing all items.
            yardratBoxListBox.Items.Clear();// Clear the list box by clearing all items.
            textBox1.Clear();// Clear the text box by clearing all text.

            ///Load resources for the button click
            ///

            //Load picureBox
            pictureBox1.Image = Properties.Resources.Sunset_on_Mars;//remember to add other planet photo resource.
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //Display yardrat planet resources in list box
            listBoxLandOfWater.Items.Clear();// Clear the list box before adding new items.
            listBoxLandOfWater.Items.Add("Planet Info");
            //yardratBoxListBox.Items.Add("ReadMeYardrat.txt");
            listBoxLandOfWater.Items.Add("Known Species");

            textBox1.ReadOnly = true; // Set the text box to read-only so the user cannot edit the text from the read me file.


        }

        private void listBoxLandOfWater_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBoxLandOfWater.SelectedItem.ToString();

            if (selectedItem == "Planet Info")
            {
                textBox1.Text = Properties.Resources.ReadMeOnePiece;

            }
            else if (selectedItem == "Known Species")
            {
                pictureBox1.Image = Properties.Resources.Luffy;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //Will include exit button and class structure in the next assignments submissions as as work on the 
        //windows form transition to another form.


        // private void Yardrat_Click(object sender, EventArgs e)
        //{
        //Call click event for yardrat button that will pull a custom method from a class in the DLL(to be created)
        // This class will have a method that will display the yardrate planet picture and resources.
        //YardratPlanet.DisplayYardratInfo();
        //   }
    }
}
