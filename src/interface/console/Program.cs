using Presenter;
using System;

namespace ConsoleApp
{
    public class Program
    {

        # region Properties

        private static WordFormPresenter Presenter { get; set; }

        # endregion

        # region Public Entry Point

        public static void Main(string[] args)
        {
            // guard clause
            if (args.Length == 0)
            {
                Console.WriteLine("Must provide word(s)");
                return;
            }

            Presenter = new WordFormPresenter();

            foreach (string singular in args)
            {
                Console.WriteLine("{0}", Presenter.Transform(singular));
            }
        }

        # endregion

    }
}
