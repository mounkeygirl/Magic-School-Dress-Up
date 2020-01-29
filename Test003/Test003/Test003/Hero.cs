using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Test003
{
    public enum SEX
    {
        MALE,
        FAMALE
    }

    public class Hero
    {


        public Hero(String name = "Henry", string nickname = "Henrietta", SEX sex = SEX.MALE)
        {
            Name = name;
            Nickname = nickname;
            Sex = sex;
            //Will be using TYPESOFCLOTHING enum in multiple locations
            int clothingTypeSize = (int)Enum.GetNames(typeof(TYPESOFCLOTHING)).Length;

            //initlizie wardrobe array with first position being size of TYPESOF CLOTHING ENUM
            //setting second  number as maximum number of clothing pieces in here
            Wardrobe = new Clothing[clothingTypeSize][];
            Wardrobe[(int)TYPESOFCLOTHING.SHIRT] = new Clothing[(int)Enum.GetNames(typeof(SHIRTSENUM)).Length];
            Wardrobe[(int)TYPESOFCLOTHING.PANTS] = new Clothing[(int)Enum.GetNames(typeof(PANTSENUM)).Length];
            Wardrobe[(int)TYPESOFCLOTHING.FACE] = new Clothing[(int)Enum.GetNames(typeof(FACES_ENUM)).Length];
            Wardrobe[(int)TYPESOFCLOTHING.HAIR] = new Clothing[(int)Enum.GetNames(typeof(HAIR_ENUM)).Length];
            Wardrobe[(int)TYPESOFCLOTHING.GLASSES] = new Clothing[(int)Enum.GetNames(typeof(GLASSES_ENUM)).Length];
            Wardrobe[(int)TYPESOFCLOTHING.SHOES] = new Clothing[(int)Enum.GetNames(typeof(SHOES_ENUM)).Length];
            Wardrobe[(int)TYPESOFCLOTHING.SOCKS] = new Clothing[(int)Enum.GetNames(typeof(SOCKS_ENUM)).Length];


            Body = Properties.Resources.Henry004;

            //Will access the positions in this array bassed on DistinctClothing Pieces ENUM
            Outfit = new Clothing[clothingTypeSize];


            //This will be the outfit that Henry will be wearying when the game starts
            //layer order taken care of in dressHero(). Not important here
            //Should also add to Henry's wardrobe, so that later in the game he can select this again

            int outfitTypeNum = (int)TYPESOFCLOTHING.SHIRT;
            int subNum = (int)SHIRTSENUM.WEAVY_BLUE;


            starterOutfit(outfitTypeNum, subNum);


            outfitTypeNum = (int)TYPESOFCLOTHING.PANTS;
            subNum = (int)PANTSENUM.SKIRT_BLUE;

            starterOutfit(outfitTypeNum, subNum);


            outfitTypeNum = (int)TYPESOFCLOTHING.FACE;
            subNum = (int)FACES_ENUM.DERP;

            starterOutfit(outfitTypeNum, subNum);

            outfitTypeNum = (int)TYPESOFCLOTHING.HAIR;
            subNum = (int)HAIR_ENUM.CURLY_PURPLE;

            starterOutfit(outfitTypeNum, subNum);
            starterOutfit((int)TYPESOFCLOTHING.SOCKS, (int)SOCKS_ENUM.PINK);

            starterOutfit((int)TYPESOFCLOTHING.SHOES, (int)SHOES_ENUM.CLOGS_BROWN);


            DressedHero = dressHero();


        }

        private void starterOutfit(int outfitTypeNum, int subNum)
        {
            Outfit[outfitTypeNum] = Clothing.Wardrobe[outfitTypeNum][subNum];
            addToWardrobe(outfitTypeNum, subNum);


        }

        public string Name
        {
            get;
            set;

        }

        public string Nickname
        {
            get;
            set;
        }

        public Bitmap Body
        {
            get;
            set;
        }

        public Clothing[] Outfit
        {
            get;
            set;
        }

        public Bitmap DressedHero
        {
            get;
            set;
        }

        public int OutfitScore
        {
            get {
                return calculateOutfitScore();
                    }
        }

        private int calculateOutfitScore()
        {
            int score = 0;
            foreach (Clothing item in Outfit)
            {
                if (item != null) { score += item.Score; }

            }
            return score;
        }

        //wardrobe is to keep track of clothing that henry owns. It should return null
        //where Henry dosen't have that clothing piece yet
        public Clothing[][] Wardrobe
        {
            get;

        }

        public Clothing[] Shirts
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.SHIRT]; }
        }

        public Clothing[] Pants
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.PANTS]; }
        }

        public Clothing[] Glasses
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.GLASSES]; }
        }

        //I plan to include checks for a lack of shirt in the dress up minigame. If the character
        //is male he fails his goal to cross dress to attend school then automatically loses
        public SEX Sex
        {
            get;
        }

        public void addToWardrobe(int clothingTypeEnum, int clothingItemEnum)
        {

            //pull static refrenece to all items from Clothing
            Clothing workingItem = Clothing.Wardrobe[clothingTypeEnum][clothingItemEnum];

            //assign it to the hero's personal wardrobe.
            //if it isn't in there at all, add it.
            if (Wardrobe[clothingTypeEnum][clothingItemEnum] == null)
            {

                Wardrobe[clothingTypeEnum][clothingItemEnum] = workingItem;


            }
            //Then increase the number availiable. Future updates may allow selling of extras, or combining

            try{

                Wardrobe[clothingTypeEnum][clothingItemEnum].Number++;

            }
            catch (NullReferenceException)
            {
                System.Diagnostics.Debug.WriteLine("NullReferenceException exception for clothingTypeEnum" + clothingTypeEnum+ ", clothingItemEnum: " + clothingItemEnum);


            }


        }

        public Bitmap dressHero()
        {

            //clone hero body, so that base is untouched
            Bitmap newHero = (Bitmap)Body.Clone();

            //use graphics object as base to dress
            Graphics graphics = Graphics.FromImage(newHero);




            updateDrawImage(graphics, newHero, TYPESOFCLOTHING.FACE);
            updateDrawImage(graphics, newHero, TYPESOFCLOTHING.SOCKS);
            updateDrawImage(graphics, newHero, TYPESOFCLOTHING.PANTS);
            updateDrawImage(graphics, newHero, TYPESOFCLOTHING.SHIRT);
            updateDrawImage(graphics, newHero, TYPESOFCLOTHING.HAIR);
            updateDrawImage(graphics, newHero, TYPESOFCLOTHING.SHOES);
            updateDrawImage(graphics, newHero, TYPESOFCLOTHING.GLASSES);


            //draw arm on top off all clothing
            graphics.DrawImage(Properties.Resources.forground_arm, 0, 0, newHero.Size.Width, newHero.Size.Height);


            //Releases resources used by graphics
            graphics.Dispose();





            Bitmap output = newHero;

            return output;
        }

        private void updateDrawImage(Graphics graphics, Bitmap newHero, TYPESOFCLOTHING type)
        {
            Clothing clothing = Outfit[(int)type];

            if (clothing != null)
            {
                graphics.DrawImage(clothing.Image, 0, 0, newHero.Size.Width, newHero.Size.Height);

            }

        }

        public void changeShirt(Clothing clothing)
        {

            Outfit[(int)TYPESOFCLOTHING.SHIRT] = clothing;
            DressedHero = dressHero();


        }

        public void changeClothing(TYPESOFCLOTHING typeOfClothing, Clothing clothing){
            Outfit[(int)typeOfClothing] = clothing;
            DressedHero = dressHero();
        }
    }
}
