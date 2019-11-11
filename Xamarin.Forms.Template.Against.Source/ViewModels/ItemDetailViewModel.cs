using System;

using Xamarin.Forms.Template.Against.Source.Models;

namespace Xamarin.Forms.Template.Against.Source.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
