namespace Shop.UIForms.Infrastructure
{
    using Shop.UIForms.ViewModels;

    public class Intancelocator
    {
        public MainViewModel Main { get; set; }

        public Intancelocator()

        {
            this.Main = new MainViewModel();
        }


    }
}
