using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networkDeviceApp.Klasy
{
    public static class ListView_helper
    {
        public static void helper(ListView listView)
        {
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HideSelection = false;
            listView.Columns.Clear();
            listView.Columns.Add("Typ", 100);
            listView.Columns.Add("Nazwa", 150);
            listView.Columns.Add("IP", 120);
            listView.Columns.Add("Lokalizacja", 150);
        }
    }
}
