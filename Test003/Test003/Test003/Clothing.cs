using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Test003
{

    public enum TYPESOFCLOTHING
    {
        FACE,
        SHIRT,
        PANTS,
        HAIR,
        GLASSES,
        SOCKS,
        SHOES
    }

    public enum SHIRTSENUM
    {
        WEAVY_BLUE, MAGIC_BLACK,TSHIRT_RED

    }

    public enum PANTSENUM
    {
        SKIRT_BLUE, JEANS_BLUE

    }

    public enum FACES_ENUM
    {
        DERP,ANIME,REALISITC
    }

    public enum HAIR_ENUM
    {
        CURLY_PURPLE,BRAIDS_BROWN,PIXIE_BLOND
    }

    public enum GLASSES_ENUM
    {
        RED_AND_GOLD,SUNGLASSES_BLACK
    }
    
    public enum SOCKS_ENUM
    {

        PINK    
    }

    public enum SHOES_ENUM
    {

        CLOGS_BROWN

    }



    public class Clothing
    {



        public Clothing(string name, Bitmap image, int score = 1)
        {
            Name = name;
            Image = image;
            Score = score;
        }


        public string Name
        {
            get;
            set;
        }

        public Bitmap Image
        {
            get;
            set;

        }

        public int Number
        {
            get;
            set;
        }

        public int Score
        {
            get;
            set;
        }

        //wardrobe is set up to be fastest way to acces clothing.
        //a double int array should be saved for faster movement in looking up clothing number, rather then search algorithms 
        public int Saved_ClothingTypeEnumNumber
        {
            get;
            set;

        }

        public int Saved_ClothingUniqueItemEnumNumer
        {
            get;
            set;
        }


        //holding an array backed by an enum for each clothing item

        public static Clothing[] Faces
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.FACE]; }
        }

        public static Clothing[] Shirts
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.SHIRT]; }

        }

        public static Clothing[] Pants
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.PANTS]; }

        }
        public static Clothing[] Hair
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.HAIR]; }

        }

        public static Clothing[] Glasses
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.GLASSES]; }

        }


        public static Clothing[] Shoes
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.SHOES]; }

        }


        public static Clothing[] Socks
        {
            get { return Wardrobe[(int)TYPESOFCLOTHING.SOCKS]; }

        }

        public static Clothing[][] Wardrobe
        {
            get {

                //Will be using TYPESOFCLOTHING enum in multiple locations
                int clothingTypeSize = (int)Enum.GetNames(typeof(TYPESOFCLOTHING)).Length;

                //initlizie wardrobe array with first position being size of TYPESOF CLOTHING ENUM
                //setting second  number as maximum number of clothing pieces in here
                //wardrobeLocation set at this time so cross reference from clothing item is easier
                Clothing[][] Wardrobe = new Clothing[clothingTypeSize][];
                Wardrobe[(int)TYPESOFCLOTHING.SHIRT] = initializeShirts();
                Wardrobe[(int)TYPESOFCLOTHING.PANTS] = initializePants();
                Wardrobe[(int)TYPESOFCLOTHING.FACE] = initializeFaces();
                Wardrobe[(int)TYPESOFCLOTHING.HAIR] = initializeHair();
                Wardrobe[(int)TYPESOFCLOTHING.GLASSES] = initializeGlasses();
                Wardrobe[(int)TYPESOFCLOTHING.SHOES] = initializeShoes();
                Wardrobe[(int)TYPESOFCLOTHING.SOCKS] = initializeSocks();

                return Wardrobe;
            }
        }


        //intilizing the items in the clothing arrays
        private static Clothing[] initializeFaces()
        {
            
            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(FACES_ENUM)).Length];
            createClothing(clothing, 
                new Clothing("Derp Face", Properties.Resources.face_derp_001, 0), 
                (int)TYPESOFCLOTHING.FACE, (int)FACES_ENUM.DERP);
            createClothing(clothing, 
                new Clothing("Anime Face", Properties.Resources.face_anime_001, 1), 
                (int)TYPESOFCLOTHING.FACE, (int)FACES_ENUM.ANIME);
            createClothing(clothing, 
                new Clothing("Realistic Face", Properties.Resources.face_realistic_001, 2), 
                (int)TYPESOFCLOTHING.FACE, (int)FACES_ENUM.REALISITC);
            return clothing;
        }


        private static Clothing[] initializeShirts()
        {
            Clothing[] shirts = new Clothing[(int)Enum.GetNames(typeof(SHIRTSENUM)).Length];
            
            createClothing(shirts, new Clothing("Wavy Blue Shirt", Properties.Resources.shirt_wavy_blue, 1), (int)TYPESOFCLOTHING.SHIRT, (int)SHIRTSENUM.WEAVY_BLUE);
            createClothing(shirts, new Clothing("Magic Black Shirt", Properties.Resources.shirt_magicGirlTop001, 2), (int)TYPESOFCLOTHING.SHIRT, (int)SHIRTSENUM.MAGIC_BLACK);
            createClothing(shirts, new Clothing("Red T-Shirt", Properties.Resources.shirt_tShirt_red, 3), (int)TYPESOFCLOTHING.SHIRT, (int)SHIRTSENUM.TSHIRT_RED);
           

            return shirts;
        }

        private static Clothing[] initializePants()
        {
            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(PANTSENUM)).Length];
            createClothing(clothing, new Clothing("Blue Skirt", Properties.Resources.pants_skirt_blue, 1), (int)TYPESOFCLOTHING.PANTS, (int)PANTSENUM.SKIRT_BLUE);
            createClothing(clothing, new Clothing("Blue Jeans", Properties.Resources.pants_jeans_blue, 2), (int)TYPESOFCLOTHING.PANTS, (int)PANTSENUM.JEANS_BLUE);

            return clothing;
        }
        private static Clothing[] initializeHair()
        {
            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(HAIR_ENUM)).Length];
            createClothing(clothing, new Clothing("Wavy Purple Hair", Properties.Resources.hair_curly_purple, 1), (int)TYPESOFCLOTHING.HAIR, (int)HAIR_ENUM.CURLY_PURPLE);
            createClothing(clothing, new Clothing("Brown Braids Bun", Properties.Resources.hair_brown_bun, 2), (int)TYPESOFCLOTHING.HAIR, (int)HAIR_ENUM.BRAIDS_BROWN);
            createClothing(clothing, new Clothing("Blond Pixie Cut", Properties.Resources.hair_pixie_blond, 3), (int)TYPESOFCLOTHING.HAIR, (int)HAIR_ENUM.PIXIE_BLOND);
            return clothing;
        }

        private static Clothing[] initializeGlasses()
        {
            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(GLASSES_ENUM)).Length];
            createClothing(clothing, new Clothing("Red and Gold Glasses", Properties.Resources.glasses_gold_and_red, 1), (int)TYPESOFCLOTHING.GLASSES, (int)GLASSES_ENUM.RED_AND_GOLD);
            createClothing(clothing, new Clothing("Sunglasses", Properties.Resources.glasses_sun_black, 2), (int)TYPESOFCLOTHING.GLASSES, (int)GLASSES_ENUM.SUNGLASSES_BLACK);

            return clothing;
        }

        private static Clothing[] initializeShoes()
        {

            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(SHOES_ENUM)).Length];
            createClothing(clothing, "Brown Clogs", Properties.Resources.shoes_clogs_brown,(int)TYPESOFCLOTHING.SHOES, (int)SHOES_ENUM.CLOGS_BROWN);
            return clothing;
        }

        private static Clothing[] initializeSocks()
        {

            Clothing[] clothing = new Clothing[(int)Enum.GetNames(typeof(SOCKS_ENUM)).Length];
            createClothing(clothing, "Pink Socks", Properties.Resources.socks_pink, (int)TYPESOFCLOTHING.SOCKS, (int)SOCKS_ENUM.PINK);
            return clothing;
        }

        //used as an assistant function when initlizing clothing types
        //saves wardrobe location when item is created
        private static void createClothing(Clothing[] tempArray, string name, Bitmap bitmap, int typeOfClothingEnumNumber, int individualItemEnumNumber, int score = 1)
        {
            Clothing clothing = new Clothing(name, bitmap, score);
            
            try
            {
                tempArray[individualItemEnumNumber] = clothing;



            }
            //if there's any mixup in typeOfClothing and individual Clothing type, the length of the array will be wonky
            catch(IndexOutOfRangeException exp)
            {
                System.Diagnostics.Debug.WriteLine("Out of range exception for :"+name+"\n individualItemEnumNumber="+individualItemEnumNumber);
            }
            clothing.Saved_ClothingTypeEnumNumber = typeOfClothingEnumNumber;
            clothing.Saved_ClothingUniqueItemEnumNumer = individualItemEnumNumber;
        }

    
        private static void createClothing(Clothing[] tempArray, Clothing clothing, int typeOfClothingEnumNumber, int individualItemEnumNumber)
        {
            createClothing(tempArray, clothing.Name, clothing.Image,typeOfClothingEnumNumber,individualItemEnumNumber,clothing.Score);

        }





    }

}
