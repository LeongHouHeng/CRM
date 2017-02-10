using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CRM
{
    
    public partial class MainWindow : Window
    {
        System.Timers.Timer timer = new System.Timers.Timer();

        public MainWindow()
        {
            DataClassesDataContext db = new DataClassesDataContext();
            db.ExecuteCommand("UPDATE mytable SET displayed = 0");

            InitializeComponent();
            timer.Interval = 1000;
            timer.Elapsed += timer_Elapsed;
            timer.Start();
            


        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            //listItem item = new listItem("HouHeng");
            //this.lvTest.Items.Add(item);
            var window = new register();
            window.Show();
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            DataClassesDataContext db = new DataClassesDataContext();
            var id = from mytable in db.GetTable<mytable>() select mytable.id;
            var firstName = from mytable in db.GetTable<mytable>() select mytable.first_name;
            var lastName = from mytable in db.GetTable<mytable>() select mytable.last_name;
            var del = from mytable in db.GetTable<mytable>() select mytable.phone_number;
            var del2 = from mytable in db.GetTable<mytable>() select mytable.phone_number2;
            var dp = from mytable in db.GetTable<mytable>() select mytable.displayed;
            Array fnlist = firstName.ToArray();
            Array idlist = id.ToArray();
            Array lnlist = lastName.ToArray();
            Array dellits = del.ToArray();
            Array dplist = dp.ToArray();
            Array del2list = null;
            if (del2 != null)
            {
                del2list = del2.ToArray();
            }
            Dispatcher.BeginInvoke(new Action(() =>
            {
                if(del2 == null)
                {
                    for (int i = 0; i < lnlist.Length; i++)
                    {
                        if ((int)dplist.GetValue(i) != 1)
                        {
                            listItem item = new listItem(fnlist.GetValue(i).ToString(), lnlist.GetValue(i).ToString(), dellits.GetValue(i).ToString(), fnlist.GetValue(i).ToString().Trim() + "_" + lnlist.GetValue(i).ToString().Trim());
                            this.lvTest.Items.Add(item);
                            db.ExecuteCommand("UPDATE mytable SET displayed = 1 WHERE id = " + idlist.GetValue(i).ToString());

                        }
                    }
                }
                else
                {
                    for (int i = 0; i < dplist.Length; i++)
                    {
                        if ((int)dplist.GetValue(i) != 1)
                        {
                            listItem item = new listItem(fnlist.GetValue(i).ToString(), lnlist.GetValue(i).ToString(), dellits.GetValue(i).ToString(), fnlist.GetValue(i).ToString().Trim() + "_" + lnlist.GetValue(i).ToString().Trim());
                            this.lvTest.Items.Add(item);
                            db.ExecuteCommand("UPDATE mytable SET displayed = 1 WHERE id = " + idlist.GetValue(i).ToString());
                        }
                       
                    }
                }
                
            }));

        }

        private void lvTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Yes?No?", "?", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.OK:
                    string str = "";
                    string fn = "", ln = "";
                    if (lvTest.SelectedItem != null)
                    {
                        listItem select = lvTest.SelectedItem as listItem;
                        str = select.Name;
                        string[] fl = str.Split(new Char[] { '_' });
                        fn = fl[0];
                        ln = fl[1];
                    }
                    this.lvTest.Items.Remove(lvTest.SelectedItem);
                    DataClassesDataContext db = new DataClassesDataContext();
                    db.ExecuteCommand("DELETE FROM mytable WHERE first_name = '" + fn + "' AND last_name = '" + ln + "'");
                    MessageBox.Show("Removed");
                    break;

            }
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            listItem select = lvTest.SelectedItem as listItem;
            string str = select.Name;
            var window = new detail(str);
            window.Show();
        }
    }
}
