using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Test003
{
    public class GameData
    {
        List<Item> inventory = new List<Item>();
        Panel eventAlertPanel = new Panel();

        GameData(Panel eventAlertPanel) {
            this.eventAlertPanel = eventAlertPanel;

        }

        public Panel EventPanel {
            get;
            set;
        }


        //plots from various files

        //INport story file
        private static Story inportStoryFile(string fileName, Hero hero, Boolean hasBranchingChoices = false)
        {
            List<string> testText = new List<string>();
            Story myStory = new Story(testText,hero , hasBranchingChoices);


            StreamReader inputFile = File.OpenText(fileName);

            while (!inputFile.EndOfStream)
            {
                testText.Add(inputFile.ReadLine());

            }

            inputFile.Close();
            return myStory;
        }



        //Glamor hobo plot
        //This was used to start programming the visual novel section before
        //the magic school story was written
        public static Story initilizeGlamorHobosAdventure()
        {
            Hero glamorHobo = new Hero();
            Story myStory;
            myStory=inportStoryFile("Story.txt",glamorHobo);


            

            //resize arrays based on new testText file size
            myStory.updateImageArraySizes();


            myStory.addMiddleCharacterImage(0, 0, Properties.Resources.James_Green_Think_full);
            myStory.addMiddleCharacterImage(1, 2, Properties.Resources.James_Green_Vashoom_full);
            myStory.addMiddleCharacterImage(3, 3, Properties.Resources.pumpernickel001);
            myStory.addMiddleCharacterImage(4, 6, Properties.Resources.James_Green_Vashoom_full);
            myStory.addBackgroundImage(0, 4, Properties.Resources.GlamorLair001);
            myStory.addBackgroundImage(5, 6, Properties.Resources.DefaultOutdoor);

            Item testItem = new Item("Test Item");
            myStory.findItem(6,testItem);

            return myStory;
        }


        public static Story initilizeStory(string storyFile,Hero hero, Boolean hasBranchingChoices = false)
        {
            Story myStory= inportStoryFile(storyFile,hero, hasBranchingChoices);
            //resize arrays based on new testText file size
            myStory.updateImageArraySizes();

            //add storyfile for future pulls
            myStory.StoryFile = storyFile;


            return myStory;
        }

    }
}
