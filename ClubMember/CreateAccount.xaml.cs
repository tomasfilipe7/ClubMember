﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace ClubMember
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Page
    {

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            string memberID = textBox3.Text;
            string email = textBox4.Text;
            string password = textBox5.Password;
            string movie = textBox6.Text;

            string daysLeft = "90";
            string memberType = "Standard";

            if (fname == "" || lname == "" || memberID == "" || email  == "" || password == "" || movie == "")
            {
                ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getCreateAccount(), "Inputs cannot be left in blank");
                window.HorizontalAlignment = HorizontalAlignment.Center;
                window.VerticalAlignment = VerticalAlignment.Center;
                window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                window.ShowDialog();
            }
       
            else
            {
                string[] allLines = System.IO.File.ReadAllLines("users.txt");
                string[] content;
                Boolean found = false;

                foreach (string l in allLines){
                    content = l.Split(",");

                    if(memberID == content[0])
                    {
                        ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getCreateAccount(), "Member already exists!");
                        window.HorizontalAlignment = HorizontalAlignment.Center;
                        window.VerticalAlignment = VerticalAlignment.Center;
                        window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                        window.ShowDialog();
                        found = true;
                    }
                }

                if (found == false)
                {
                    string line = memberID + "," + password + "," + daysLeft + "," + memberType + "," + fname + "," + lname + "," + email + "," + movie;

                    using (StreamWriter writer = new StreamWriter("users.txt", true))
                    {
                        writer.WriteLine(line);
                    }

                    ConfirmPayment window = new ConfirmPayment(this, PageManager.pagemanager.getLogin(), memberID + " account was\nsuccessfully created!" );
                    window.HorizontalAlignment = HorizontalAlignment.Center;
                    window.VerticalAlignment = VerticalAlignment.Center;
                    window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    window.ShowDialog();

                }
                
            }
            
        }

        // button to go back
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(PageManager.pagemanager.getLogin());
        }
    }
}
