using NUnit.Framework;
using Presenter;
using Resources;

namespace PresenterTest
{
    [TestFixture]
    public class WordFormPresenterTest
    {

        private WordFormPresenter Presenter;

        [SetUp]
        public void SetUp()
        {
            Presenter = new WordFormPresenter();
        }

        # region Blue Sky Tests

        [Test]
        public void TestBlueSky_Transform_ToPlural()
        {
            // setup
            string singular = "datum";

            // exercise
            string plural = Presenter.Transform(singular);

            // pre-conditions
            Assert.AreEqual(string.Format(WordForm.PluralForm, "data"), plural);
        }

        [Test]
        public void TestBlueSky_Transform_ToSingular()
        {
            // setup
            string plural = "criteria";

            // exercise
            string singular = Presenter.Transform(plural);

            // pre-conditions
            Assert.AreEqual(string.Format(WordForm.SingularForm, "criterion"), singular);
        }

        # endregion

    }
}
