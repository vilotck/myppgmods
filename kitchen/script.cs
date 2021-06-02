using UnityEngine;namespace Mod{public class Mod{public static void Main(){ModAPI.Register(new Modification(){OriginalItem = ModAPI.FindSpawnable("Metal Cube"),NameOverride = "tea ",DescriptionOverride = "could also be any brown liquid",CategoryOverride = ModAPI.FindCategory("Misc."),ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/tea--thumb.png"),AfterSpawn = (Instance) =>{Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/tea-.png");Instance.FixColliders();}});ModAPI.Register(new Modification(){OriginalItem = ModAPI.FindSpawnable("Knife"),NameOverride = "kitchen knife",DescriptionOverride = "scary boy",CategoryOverride = ModAPI.FindCategory("Melee"),ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/kitchen-knife-thumb.png"),AfterSpawn = (Instance) =>{Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/kitchen-knife.png");Instance.FixColliders();}});ModAPI.Register(new Modification(){OriginalItem = ModAPI.FindSpawnable("Knife"),NameOverride = "small knife",DescriptionOverride = "a sorta small but complimentary boy",CategoryOverride = ModAPI.FindCategory("Melee"),ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/small-knife-thumb.png"),AfterSpawn = (Instance) =>{Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/small-knife.png");Instance.FixColliders();}});ModAPI.Register(new Modification(){OriginalItem = ModAPI.FindSpawnable("Metal Cube"),NameOverride = "bacon",DescriptionOverride = "mmm yum mm myes m yum",CategoryOverride = ModAPI.FindCategory("Misc."),ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/bacon-thumb.png"),AfterSpawn = (Instance) =>{Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/bacon.png");Instance.FixColliders();}});ModAPI.Register(new Modification(){OriginalItem = ModAPI.FindSpawnable("Metal Cube"),NameOverride = "egg",DescriptionOverride = "you have it with bacon",CategoryOverride = ModAPI.FindCategory("Misc."),ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/egg-thumb.png"),AfterSpawn = (Instance) =>{Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/egg.png");Instance.FixColliders();}});ModAPI.Register(new Modification(){OriginalItem = ModAPI.FindSpawnable("Metal Cube"),NameOverride = "toaster",DescriptionOverride = "mmm toast",CategoryOverride = ModAPI.FindCategory("Misc."),ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/toaster-thumb.png"),AfterSpawn = (Instance) =>{Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/toaster.png");Instance.FixColliders();}});ModAPI.Register(new Modification(){OriginalItem = ModAPI.FindSpawnable("Metal Cube"),NameOverride = "breadslice",DescriptionOverride = "put with other ingredients",CategoryOverride = ModAPI.FindCategory("Misc."),ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/breadslice-thumb.png"),AfterSpawn = (Instance) =>{Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/breadslice.png");Instance.FixColliders();}});ModAPI.Register(new Modification(){OriginalItem = ModAPI.FindSpawnable("Metal Cube"),NameOverride = "lettuceslice",DescriptionOverride = "put with the breadslice",CategoryOverride = ModAPI.FindCategory("Misc."),ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/lettuceslice-thumb.png"),AfterSpawn = (Instance) =>{Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/lettuceslice.png");Instance.FixColliders();}});ModAPI.Register(new Modification(){OriginalItem = ModAPI.FindSpawnable("Metal Cube"),NameOverride = "meatslice",DescriptionOverride = "mmm meat for bread",CategoryOverride = ModAPI.FindCategory("Misc."),ThumbnailOverride = ModAPI.LoadSprite("Thumbnails/meatslice-thumb.png"),AfterSpawn = (Instance) =>{Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Sprites/meatslice.png");Instance.FixColliders();}});}}}