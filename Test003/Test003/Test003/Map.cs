using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Test003
{
    public partial class Map : Form
    {
        Story glamorLairStory =GameData.initilizeGlamorHobosAdventure();
        List<Story> magicSchoolStories = new List<Story>();

        public Map()
        {
            InitializeComponent();

            /*
            Story dressUpMagicSchoolStory = GameData.initilizeStory("MagicSchool.txt",true);
            dressUpMagicSchoolStory.addBackgroundImage(0, Properties.Resources.PumpkinFarm001);
            dressUpMagicSchoolStory.addMiddleCharacterImage(0, Properties.Resources.farmerMother001);
            dressUpMagicSchoolStory.addMiddleCharacterImage(1,3, Properties.Resources.Henry001);
            dressUpMagicSchoolStory.addBackgroundImage(1, Properties.Resources.TownFestival001);
            

            Story henrysFirstSchoolDay = GameData.initilizeStory("HenrysFirstDayOfSchool.txt");
            henrysFirstSchoolDay.addBackgroundImage(0, Properties.Resources.School_A);


            Choice choiceGoToGirlsSchool = new Choice( "Go To Girl's School", henrysFirstSchoolDay);
            dressUpMagicSchoolStory.branchStory(choiceGoToGirlsSchool);

            magicSchoolStories.Add(dressUpMagicSchoolStory);
            magicSchoolStories.Add(henrysFirstSchoolDay);
            */

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void glamorLairPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mapPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 glamorLair = new Form1(glamorLairStory,0);
            glamorLair.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        public void resumeWorld(Story myStory)
        {
            int position = myStory.Position;
            Form1 openWorld = new Form1(glamorLairStory,position);
            openWorld.ShowDialog();

        }

        private void dressUpGameButton_Click(object sender, EventArgs e)
        {
            Form1 glamorLair = new Form1(magicSchoolStories);
            glamorLair.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Map_Load(object sender, EventArgs e)
        {

        }
    }
}
