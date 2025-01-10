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

            lcdScreen.AddContentItem(new ContentItem("German Shepard.png", "dogs", ContentItemDataSizes.Small, ContentItemTypes.Image));
            holographicScreen.AddContentItem(new ContentItem("3d German Shepard", "dogs", ContentItemDataSizes.Medium, ContentItemTypes.Three_Dimensional_Model));
            interactiveMapScreen.AddContentItem(new ContentItem("map", "maps", ContentItemDataSizes.Large, ContentItemTypes.Interactive_Geographical_Data));

            exhibitConsole.AddDisplayScreen(0, lcdScreen);
            exhibitConsole.AddDisplayScreen(1, holographicScreen);
            exhibitConsole.AddDisplayScreen(2, interactiveMapScreen);
        }

        [TestCase(ContentItemTypes.Image, "German Shepard.png")]
        [TestCase(ContentItemTypes.Three_Dimensional_Model, "3d German Shepard")]
        [TestCase(ContentItemTypes.Interactive_Geographical_Data, "map")]
        public void ListAllDisplayScreensByContentItemType_Test(ContentItemTypes contentItemType, string expectedName)
        {
            var results = exhibitConsole.ListAllDisplayScreensByContentItemType(contentItemType);
            var actualName = results[0].GetContentItems().First().GetTitle();
            Assert.That(expectedName, Is.EqualTo(actualName));
        }
    }
}