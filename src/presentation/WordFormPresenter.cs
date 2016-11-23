using Resources;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;

namespace Presenter
{
    public class WordFormPresenter
    {

        # region Constructors

        public WordFormPresenter()
        {
            PluralizationService = PluralizationService.CreateService(CultureInfo.CurrentCulture);
        }

        # endregion

        # region Properties

        private PluralizationService PluralizationService { get; set; }

        # endregion

        # region Public Methods

        public string Transform(string word)
        {
            if (PluralizationService.IsSingular(word))
            {
                return string.Format(WordForm.PluralForm, PluralizationService.Pluralize(word));
            }
            else
            {
                return string.Format(WordForm.SingularForm, PluralizationService.Singularize(word));
            }
        }

        # endregion

    }
}
