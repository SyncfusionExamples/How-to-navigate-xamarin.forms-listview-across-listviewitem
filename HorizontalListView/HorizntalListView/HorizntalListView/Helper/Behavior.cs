using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ListViewSample
{
   public class Behavior :Behavior<ContentPage>
    {
        SfListView ListView; Grid GridView;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            ListView = bindable.FindByName<SfListView>("list");
            GridView = bindable.FindByName<Grid>("GridView");
            ListView.BindingContext = new ContactsViewModel();
            ListView.ItemTapped += ListView_ItemTapped;
            base.OnAttachedTo(bindable);
        }

        private void ListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            GridView.BindingContext = e.ItemData;
        }
    }
}
