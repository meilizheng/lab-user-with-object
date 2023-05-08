using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Xml.Linq;
//Meili Zheng;
//lab-user with object;
//5/8/2023;

namespace lab_user_with_object
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }
        
        public void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            string name = txtname.Text;   //diclarie varible;
            string brand = txtBrand.Text;
            bool watchMovie = cbWatchMovie.IsChecked == true;
            bool playgame = cbPlayGame.IsChecked == true;
            bool call = cb_call.IsChecked == true;
            bool text = cbtext.IsChecked == true;
            string model = txtModel.Text;
            string result = $"name {name}  brand {brand} model {model}";

            Smartphone phone = new Smartphone (brand, model, name);  //created a new instance;
            {
                lbdisplay.Items.Add(phone);  //add information to listbox;
                if (watchMovie || playgame)  //if the phone can watch movie or playgame display phone information and mark smart phone;
                {
                    string fuction = "smart phone";
                    lbdisplay.Items.Add(fuction);
                }
                else  //else display phone information and mark not smart phone;
                {
                    string fuction = " Not smart phone";
                    lbdisplay.Items.Add(fuction);
                }
            }   
        }

        private void btnClear_Click(object sender, RoutedEventArgs e) //clear list box;
        {
            lbdisplay.Items.Clear();
        }

        //I chose this project from our priveous lab. use phone as a project name, added two child class. let them inheritance from the parent(phone) class. also I created a xaml, let the user input the phone information, depending 
        //what information that user entered to display the result;
    }
}
