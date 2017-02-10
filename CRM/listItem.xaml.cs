using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRM
{
    /// <summary>
    /// listItem.xaml 的互動邏輯
    /// </summary>
    public partial class listItem : ListViewItem
    {
        
        public listItem()
        {
            InitializeComponent();
        }

        public listItem(string FirstName, string LastName, string userDel, string funcname)
        {
            InitializeComponent();
            lbName.Content = "Name: " + FirstName + " " + LastName;
            del.Content = "Del: " + userDel;
            this.Name = funcname;
        }
        public listItem(string FirstName, string LastName, string userDel, string userDel2, string funcname)
        {
            InitializeComponent();
            lbName.Content = "Name: " + FirstName + " " + LastName;
            del.Content = "Del: " + userDel;
            del2.Content = "Del2: " + userDel2;
            this.Name = funcname;

            
        }
    }
}
 