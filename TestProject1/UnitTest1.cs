using InteractiveMuseumExhibit;
using InteractiveMuseumExhibit.ContentItems;
using InteractiveMuseumExhibit.DisplayScreens;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        ExhibitConsole exhibitConsole;

        LCDScreen lcdScreen;
        HolographicScreen holographicScreen;
        InteractiveMapScreen interactiveMapScreen;

        [SetUp]
        public void Setup()
        {
            exhibitConsole = new ExhibitConsole(3);

            lcdScreen = new LCDScreen();
            holographicScreen = new HolographicScreen();
            interactiveMapScreen = new InteractiveMapScreen();

            lcdScreen.AddContentItem(new ContentItem("GermanSheperd.png", "dogs", ContentItemDataSizes.Small, ContentItemTypes.Image));
            holographicScreen.AddContentItem(new ContentItem("3dGermanSheperd", "dogs", ContentItemDataSizes.Medium, ContentItemTypes.Three_Dimensional_Model));
            interactiveMapScreen.AddContentItem(new ContentItem("map", "maps", ContentItemDataSizes.Large, ContentItemTypes.Map));

            exhibitConsole.AddDisplayScreen(0, lcdScreen);
            exhibitConsole.AddDisplayScreen(1, holographicScreen);
            exhibitConsole.AddDisplayScreen(2, interactiveMapScreen);
        }

        [TestCase(ContentItemTypes.Image, "GermanSheperd.png")]
        [TestCase(ContentItemTypes.Three_Dimensional_Model, "3dGermanSheperd")]
        [TestCase(ContentItemTypes.Map, "map")]
        public void ListAllDisplayScreensByContentItemType_Test(ContentItemTypes contentItemType, string expectedTitle)
        {
            var results = exhibitConsole.ListAllDisplayScreensByContentItemType(contentItemType);
            var actualTitle = results[0].GetContentItems().First().GetTitle();
            Assert.That(expectedTitle, Is.EqualTo(actualTitle));
        }

        [TestCase(3, 4)]
        [TestCase(3, -1)]
        [TestCase(10, 11)]
        [TestCase(10, -1)]
        public void ValidateDisplayScreenIndexWithAddMethod_Test(int capacity, int invalidIndex)
        {
            ExhibitConsole exhibitConsole = new ExhibitConsole(capacity);
            LCDScreen lcdScreen = new LCDScreen();
            Assert.Throws<ArgumentOutOfRangeException>(() => exhibitConsole.AddDisplayScreen(invalidIndex, lcdScreen));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(-1)]
        public void ValidateDisplayScreenIndexWithReplaceMethod_Test(int invalidIndex)
        {
            ExhibitConsole exhibitConsole = new ExhibitConsole(1);
            LCDScreen lcdScreen = new LCDScreen();
            Assert.Throws<ArgumentOutOfRangeException>(() => exhibitConsole.ReplaceDisplayScreenByIndex(invalidIndex, lcdScreen));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void FixedNumberOfDisplayScreensValidation_Test(int invalidCapacity)
        {
            Assert.Throws<ArgumentException>(() => new ExhibitConsole(invalidCapacity));
        }
    }
}