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
using System.Windows.Shapes;

namespace CRM
{
    /// <summary>
    /// detail.xaml 的互動邏輯
    /// </summary>
    public partial class detail : Window
    {
        public detail(string funcname)
        {
            InitializeComponent();
            DataClassesDataContext db = new DataClassesDataContext();
            string fn = "", ln = "";
            string[] fl = funcname.Split(new Char[] { '_' });
            fn = fl[0];
            ln = fl[1];
            fname.Text = fn;
            lname.Text = ln;
            var nickname = from mytable in db.GetTable<mytable>() where mytable.first_name == fn && mytable.last_name == ln select mytable.nick_name;
            Array nn = nickname.ToArray();
            if (nn.GetValue(0) != null)
                nname.Text = nn.GetValue(0).ToString();
            else
                nname.Text = "null";


            var delt = from mytable in db.GetTable<mytable>() where mytable.first_name == fn && mytable.last_name == ln select mytable.phone_number;
            Array dd = delt.ToArray();
            if (dd.GetValue(0) != null)
                del.Text = dd.GetValue(0).ToString();
            else
                del.Text = "null";

            var delt2 = from mytable in db.GetTable<mytable>() where mytable.first_name == fn && mytable.last_name == ln select mytable.phone_number2;
            Array dd2 = delt2.ToArray();
            if (dd2.GetValue(0) != null)
                del2.Text = dd2.GetValue(0).ToString();
            else
                del2.Text = "null";

            var emailt = from mytable in db.GetTable<mytable>() where mytable.first_name == fn && mytable.last_name == ln select mytable.email;
            Array ee = emailt.ToArray();
            if (ee.GetValue(0) != null)
                email.Text = ee.GetValue(0).ToString();
            else
                email.Text = "null";
            var addresst = from mytable in db.GetTable<mytable>() where mytable.first_name == fn && mytable.last_name == ln select mytable.adress;
            Array aa = addresst.ToArray();
            if (aa.GetValue(0) != null)
                address.Text = aa.GetValue(0).ToString();
            else
                address.Text = "null";
            var describet = from mytable in db.GetTable<mytable>() where mytable.first_name == fn && mytable.last_name == ln select mytable.describe;
            Array dds = describet.ToArray();
            if (dds.GetValue(0) != null)
                describe.Text = dds.GetValue(0).ToString();
            else
                describe.Text = "null";
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void nname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void del_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void del2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void address_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void describe_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
