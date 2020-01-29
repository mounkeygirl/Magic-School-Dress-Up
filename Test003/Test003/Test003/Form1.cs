using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test003
{
    public partial class Form1 : Form
    {
        Story myStory;
        Story nextStory;
        Boolean eventBoxActive = false;
        List<Story> allStories = new List<Story>();
        int storySelection = 0;


        public Form1(Story inportStory, int position=0)
        {
            InitializeComponent();
            myStory = inportStory;
        }

        public Form1(List<Story> inportStory, int position=0)
        {
            InitializeComponent();
            //in case of multiple stories, start at the first story
            allStories = inportStory;
            myStory = inportStory[storySelection];


        }


        private void Form1_Load(object sender, EventArgs e)
        {
              //default foreground to false
            foregroundImage.Visible = false;
            foregroundImage.Image = Properties.Resources.LoadingPage;
            backgroundImage.Controls.Add(middleCharacterBoxImage);
            middleCharacterBoxImage.BackColor = Color.Transparent;


            //Add details to the button box;
            buttonOptionBox.BackColor = Color.Black;

            //if I've changed position 0 I need to reload anyway
            checkForImageChange();

            outputLbl.Text = myStory.start();

        }

        public bool Loading
        {
            get;
            set;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            next();
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void nextBtn_Click(object sender, EventArgs e)
        {
            next();

        }

        private void colorButtonGrey(Button button)
        {
            button.ForeColor = Color.Gray;

        }

        private void colorButtonBlack(Button button)
        {
            button.ForeColor = Color.Black;

        }

        private void checkButtonColor()
        {
            //check if next button should be greyed
            if (!myStory.hasNext())
            {
                colorButtonGrey(nextBtn);
            }
            else
            {
                colorButtonBlack(nextBtn);
            }


            //check if prev button should be greyed
            if (!myStory.hasPrev())
            {
                colorButtonGrey(prevButton);
            }
            else
            {
                colorButtonBlack(prevButton);
            }


        }


        //indicate the page is loading
        private void playLoad()
        {
            Loading = true;
            TimeLeft = 10;
            loadingTimer.Start();

            //set foreground image to loading
            foregroundImage.BringToFront();
            foregroundImage.Visible = true;
        }

        public int TimeLeft
        {
            get;
            set;
        }


        private void next()
        {
            if (myStory.Minigames[myStory.Position] != null)
            {
                playLoad();
                nextBtn.ForeColor = Color.Gray;
                prevButton.ForeColor = Color.Gray;
            }

            if (eventBoxActive == false)
            {
                outputLbl.Text = myStory.next();
            }
            

            //This has become the method to check for all changes
            checkForImageChange();

        }




        private void prevButton_Click(object sender, EventArgs e)
        {
            if (eventBoxActive == false)
            {
                outputLbl.Text = myStory.last();
            }

            if (buttonOptionBox.Visible==true)
            {
                buttonOptionBox.Visible = false;

            }

            checkForImageChange();
        }

        //checks for story changes. This includes but is not limited to images.
        private void checkForImageChange()
        {
            int num = myStory.Position;
            Bitmap currentMiddleCharacterImage = myStory.MiddleCharacterPicture[num];
            Bitmap currentBackgroundImage = myStory.BackgroundPicture[num];
            Occurance currentOccurence = myStory.StoryOccurances[num];
            
            //combined Foreground Image 
            Bitmap currentForegroundImage = myStory.ForegroundPicture[num];
            //Boolean currentForegroundImageOn = myStory.ForegroundPictureOn[num];

            //update images
            if (currentMiddleCharacterImage != null)
            {
                middleCharacterBoxImage.Visible = true;
                middleCharacterBoxImage.Image = currentMiddleCharacterImage;
            }
            else
            {
                middleCharacterBoxImage.Visible = false;

            }

            if (currentBackgroundImage != null)
            {
                backgroundImage.Image = currentBackgroundImage;
            }

            if (currentForegroundImage != null)
            {
                foregroundImage.Visible = true;
                foregroundImage.Image = currentForegroundImage;
            }
            else
            {
                foregroundImage.Visible = false;
            }

            //check for events 

            if (eventBoxActive == true)
            {
                occuranceSwitch(false);

            }
            else if (currentOccurence != null && currentOccurence.Occured==false)
            {
                eventAlertPanel.BringToFront();
                eventOutputLbl.Text = currentOccurence.Name + "\n" + currentOccurence.Description;
                occuranceSwitch(true);
                currentOccurence.Occured = true;
            }
            if (myStory.Position==myStory.TextEndPosition-1 && myStory.HasChoices==true)
            {
                showMultipleChoiceRoutes();
                nextStory=allStories[storySelection];


            }

            //check for  button change
            checkButtonColor();



        }

        public void occuranceSwitch(Boolean onOrOff)
        {
            eventAlertPanel.Visible = onOrOff;
            eventBoxActive = onOrOff;

        }




        public void showMultipleChoiceRoutes()
        {
            buttonOptionBox.Visible = true;
            int i = 0;

            Choice[] choices = myStory.Choices;

                foreach (var button in buttonOptionBox.Controls.OfType<Button>())
                {

                    if (choices[i] == null)
                    {

                        button.Text = "This test should only appear when there is no choice in here "+i;
                        button.Visible = false;

                    }
                    else
                    {

                        button.Text = choices[i].ButtonText;
                        button.Visible = true;
                }
                if(i<2)
                {
                    i++;

                }


                }


        }

        private void multipleChoiceABtn_Click(object sender, EventArgs e)
        {
            selectNextStory(0);

        }

        private void multipleChoiceBBtn_Click(object sender, EventArgs e)
        {
            selectNextStory(1);

        }

        private void multipleChoiceCBtn_Click(object sender, EventArgs e)
        {
            selectNextStory(2);
        }
        
        private void selectNextStory(int arrayPosition)
        {
            if (myStory.Choices[arrayPosition]!=null)
            {
                //set next story
                Story myNextStory = myStory.Choices[arrayPosition].Story;

                //if I've changed position 0 I need to reload anyway
                
                myStory = myNextStory;
                myStory.Position = 0;
                checkForImageChange();


                outputLbl.Text = myStory.start();

                //turn button box invisable
                buttonOptionBox.Visible = false;
            }
            else
            {

                MessageBox.Show("No vailid option connected to this button, please select another (or, Anna, YOU can fix this)");

            }
        }

        private void middleCharacterBoxImage_Click(object sender, EventArgs e)
        {

        }

        private void backgroundImage_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eventAlertPanel_Click(object sender, EventArgs e)
        {
                next();
         
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            //pulled timer tutorial form here https://www.instructables.com/id/How-to-create-a-Splash-Screen-in-C-Visual-Studio/

            if (TimeLeft > 0)
            {
                TimeLeft -= 1;
            }
            else
            {
                loadingTimer.Stop();
            }
        }
    }
}
