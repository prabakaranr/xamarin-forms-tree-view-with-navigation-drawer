using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GettingStartedBound
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TreeView_SelectionChanged(object sender, Syncfusion.XForms.TreeView.ItemSelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count > 0)
            {
                var item = e.AddedItems[0] as FileManager;

                if(item.SubFiles == null || item.SubFiles.Count == 0)
                {
                    this.IsPresented = false;
                    Text.Text = item.ItemName;
                }
            }
        }
    }
}
