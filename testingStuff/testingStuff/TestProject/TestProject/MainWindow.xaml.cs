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
using Microsoft.VisualBasic;
using BusinessObjects;
using DataLayer;
using System.Collections;
/* Daniele Stefani 10/12/2017
 /*
  */

namespace Presentation
{
    /// 
    /// this code execute the entire classes in MainWindow.xaml
    /// 
    public partial class MainWindow : Window
    {
        public string totalAmount = "";
        ArrayList Booking;

        public MainWindow()
        {
            InitializeComponent();
            Booking = new ArrayList();//creates an array list for the booking(to store data)
        }

        String Name;//creates string to store name and surname
        String Surname;
        private void entryDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private string getval;
        private object btnAddBookingOK;

        public string Getval//get set for the price of the booking
        {
            get
            {
                return getval;
            }
            set
            {

            }
        }




        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            //NameTxt.Text = Booking;
            //           Booking Book = new Guest();



        }

        private void btnFind_Click(object sender, RoutedEventArgs e)//find the data required

        {
            DataFacadeSingleton df = DataFacadeSingleton.getInstance();//Get access to te the data layer
                                                                       //      Booking = df.getChalet(Int32.Parse(AddButtonbtn.btn));
            if (Booking != null)
                update();
        }


        private void update()//update the existing booking and outputs on messagebox
        {
            BusinessObjects.Booking booking = new BusinessObjects.Booking();
            booking.Name = NameTxt.Text;
            booking.Surname = SurnameTxt.Text;
            booking.Address = AddressTxt.Text;

            MessageBox.Show(OutputTxt.Text);





            //Output.Text = BusinessObjects.Booking.Bok;
        }

        private void btnAddBookingOK_Click(object sender, RoutedEventArgs e)// this add the details of the booking to the system
        {
            //Add a Student to the class list
            //Note - no validation in this example
            try
            {
                int matric = Int32.Parse(ChaletTxt.Text);
                String name = txtStudentName.Text;

                this.update();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void IDTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void IdTxt_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ChaletTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {

        }

        private void roomTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, TextChangedEventArgs e)
        {

            String getName;
        }

        private void SurnameTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            String getSurname;

        }

        private void dateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //       Customer name = new Guests(Guests);
            //      try
            /* {
                 Customers name = NameTxt.Text;
                 Customers.surname = SurnameTxt.Text;
                 Customers.IDNumber = IdTxt.Text;
             }
             catch
             {
                 exception excep){
                     concolsoe.writeline(excep.message)
              messagebox.shoe(excep.message)
                  }*/

            //Departurebox.SelectDate.Value
            //}



            // }
            //  }

        }
        private void Output_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClearClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}