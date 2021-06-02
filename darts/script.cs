using UnityEngine; //You'll probably need this...

namespace Mod
{
    public class Mod
    {
        public static void Main()
        {
            //This method is the entry point.
            CategoryBuilder.Create("colordarts", "common colors on darts", ModAPI.LoadSprite("category.png"));
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), //item to derive from
                    NameOverride = "red dart -colordarts", //new item name with a suffix to assure it is globally unique
                    DescriptionOverride = "a red dart.", //new item description
                    CategoryOverride = ModAPI.FindCategory("colordarts"), //new item category
                    ThumbnailOverride = ModAPI.LoadSprite("Sprites/dart1.png"), //new item thumbnail (relative path)
                    AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/dart1.png"); //get the SpriteRenderer and replace its sprite with a custom one
                    }
                }
                );
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), //item to derive from
                NameOverride = "blue dart -colordarts", //new item name with a suffix to assure it is globally unique
                DescriptionOverride = "a blue dart.", //new item description
                CategoryOverride = ModAPI.FindCategory("colordarts"), //new item category
                ThumbnailOverride = ModAPI.LoadSprite("Sprites/dart2.png"), //new item thumbnail (relative path)
                AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/dart2.png"); //get the SpriteRenderer and replace its sprite with a custom one
                }
            }
            );
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), //item to derive from
                NameOverride = "green dart -colordarts", //new item name with a suffix to assure it is globally unique
                DescriptionOverride = "a green dart.", //new item description
                CategoryOverride = ModAPI.FindCategory("colordarts"), //new item category
                ThumbnailOverride = ModAPI.LoadSprite("Sprites/dart3.png"), //new item thumbnail (relative path)
                AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/dart3.png"); //get the SpriteRenderer and replace its sprite with a custom one
                }
            }
            );
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), //item to derive from
                NameOverride = "purple dart -colordarts", //new item name with a suffix to assure it is globally unique
                DescriptionOverride = "a purple dart.", //new item description
                CategoryOverride = ModAPI.FindCategory("colordarts"), //new item category
                ThumbnailOverride = ModAPI.LoadSprite("Sprites/dart4.png"), //new item thumbnail (relative path)
                AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/dart4.png"); //get the SpriteRenderer and replace its sprite with a custom one
                }
            }
            );
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), //item to derive from
                NameOverride = "orange dart -colordarts", //new item name with a suffix to assure it is globally unique
                DescriptionOverride = "a orange dart.", //new item description
                CategoryOverride = ModAPI.FindCategory("colordarts"), //new item category
                ThumbnailOverride = ModAPI.LoadSprite("Sprites/dart5.png"), //new item thumbnail (relative path)
                AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/dart5.png"); //get the SpriteRenderer and replace its sprite with a custom one
                }
            }
            );
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), //item to derive from
                NameOverride = "gray dart -colordarts", //new item name with a suffix to assure it is globally unique
                DescriptionOverride = "a grey dart.", //new item description
                CategoryOverride = ModAPI.FindCategory("colordarts"), //new item category
                ThumbnailOverride = ModAPI.LoadSprite("Sprites/dart6.png"), //new item thumbnail (relative path)
                AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/dart6.png"); //get the SpriteRenderer and replace its sprite with a custom one
                }
            }
            );
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), //item to derive from
                NameOverride = "brown dart -colordarts", //new item name with a suffix to assure it is globally unique
                DescriptionOverride = "a brown dart.", //new item description
                CategoryOverride = ModAPI.FindCategory("colordarts"), //new item category
                ThumbnailOverride = ModAPI.LoadSprite("Sprites/dart7.png"), //new item thumbnail (relative path)
                AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/dart7.png"); //get the SpriteRenderer and replace its sprite with a custom one
                }
            }
            );
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), //item to derive from
                NameOverride = "dark blue dart -colordarts", //new item name with a suffix to assure it is globally unique
                DescriptionOverride = "a dark blue dart.", //new item description
                CategoryOverride = ModAPI.FindCategory("colordarts"), //new item category
                ThumbnailOverride = ModAPI.LoadSprite("Sprites/dart8.png"), //new item thumbnail (relative path)
                AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/dart8.png"); //get the SpriteRenderer and replace its sprite with a custom one
                }
            }
            );
            ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Crossbow Bolt"), //item to derive from
                NameOverride = "black dart -colordarts", //new item name with a suffix to assure it is globally unique
                DescriptionOverride = "a black dart.", //new item description
                CategoryOverride = ModAPI.FindCategory("colordarts"), //new item category
                ThumbnailOverride = ModAPI.LoadSprite("Sprites/dart9.png"), //new item thumbnail (relative path)
                AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/dart9.png"); //get the SpriteRenderer and replace its sprite with a custom one
                }
            }
        );
        ModAPI.Register(
    new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"), //item to derive from
        NameOverride = "target -colordarts", //new item name with a suffix to assure it is globally unique
        DescriptionOverride = "please don't throw darts at me.", //new item description
        CategoryOverride = ModAPI.FindCategory("colordarts"), //new item category
        ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/target-thumb.png"), //new item thumbnail (relative path)
        AfterSpawn = (Instance) => //all code in the AfterSpawn delegate will be executed when the item is spawned
        {
            //load textures for each layer (see Human textures folder in this repository)
            var skin = ModAPI.LoadTexture("Sprites/target/target-skin.png");
            var flesh = ModAPI.LoadTexture("Sprites/target/target-flesh.png");
            var bone = ModAPI.LoadTexture("Sprites/target/target-bone.png");

            //get person
            var person = Instance.GetComponent<PersonBehaviour>();

            //use the helper function to set each texture
            //parameters are as follows:
            //  skin texture, flesh texture, bone texture, sprite scale
            //you can pass "null" to fall back to the original texture
            person.SetBodyTextures(skin, flesh, bone, 1);

            //change procedural damage colours if they interfere with your texture (rgb 0-255)
            person.SetBruiseColor(86, 62, 130); //main bruise colour. purple-ish by default
            person.SetSecondBruiseColor(154, 0, 7); //second bruise colour. red by default
            person.SetThirdBruiseColor(207, 206, 120); // third bruise colour. light yellow by default
            person.SetRottenColour(202, 199, 104); // rotten/zombie colour. light yellow/green by default
            person.SetBloodColour(108, 0, 4); // blood colour. dark red by default. note that this does not change decal nor particle effect colours. it only affects the procedural blood color which may or may not be rendered
        }
    }
);
        }
    }
}
