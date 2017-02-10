using CRM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace CRM
{
    
    public partial class register : Window
    {
        private int delcombo = -1, del2combo = -1;
        private string del = "", del2 = "";
        private string nickName = "", firstName = "", lastName = "", email = "", address = "", describe = "";

        public register()
        {
            InitializeComponent();
        }

        private void DelCOMBO_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            delcombo = DelCOMBO.SelectedIndex;
            /*
            string dc = DelCOMBO.Text.ToString();
            if (dc == "HOME/BASE")
            {
                delcombo = 0;
            }else if(dc == "CELLPHONE")
            {
                delcombo = 1;
            }*/
        }

        private void Del2COMBO_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            del2combo =  Del2COMBO.SelectedIndex;
            //string dc = Del2COMBO.Text.ToString();
            /*if (dc == "HOME/BASE")
            {
                del2combo = 0;
            }
            else if (dc == "CELLPHONE")
            {
                del2combo = 1;
            }*/
        }

        private void FirstNameET_TextChanged(object sender, TextChangedEventArgs e)
        {
   
        }

        private void LastNameET_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void NicknameET_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void DelET_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Del2ET_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void EmailET_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void addressET_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void describtET_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            firstName = this.FirstNameET.Text;
            lastName = this.LastNameET.Text;
            del = this.DelET.Text;
            
            DataClassesDataContext db = new DataClassesDataContext();
            mytable ot = new mytable();
            ot.first_name = firstName;
            ot.last_name = lastName;
            ot.phone_number = del;
            ot.phone_number_cat = delcombo;
            ot.adress = "null";
            ot.describe = "null";
            ot.email = "null";
            ot.icon = "null";
            ot.nick_name = "null";
            ot.phone_number2 = "null";
            ot.phone_number2_cat = null;
            string str = lastName.Count() + del + firstName.Count();
            ot.id = str;
            ot.displayed = 0;
            db.mytable.InsertOnSubmit(ot);
            db.SubmitChanges();
            MainWindow mw = new MainWindow();
            mw.Activate();
            mw.BeginInit();
            Hide();
            try
            {
               
            }catch(Exception ep)
            {
                Console.WriteLine(ep.ToString());
            }
        }
    }
}
