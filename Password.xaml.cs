﻿using System;
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

namespace ZhekaKotsur
{
    public partial class Password : Window
    {
        public Password()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordBox.Text;

            if (login == "test1" && password == "111")
            {
                MessageBox.Show("Успешный вход как test1");
                string user = "test1";
                MainWindow mainWindow = new MainWindow(user);
                mainWindow.Show();
                this.Close();
            }
            else if (login == "test2" && password == "222")
            {
                MessageBox.Show("Успешный вход как test2");
                string user = "test2";
                MainWindow mainWindow = new MainWindow(user);
                mainWindow.Show();
                this.Close();
            }
            else if (login == "test3" && password == "333")
            {
                MessageBox.Show("Успешный вход как test3");
                string user = "test3";
                MainWindow mainWindow = new MainWindow(user);
                mainWindow.Show();
                this.Close();
            }
            else if (login == "Admin" && password == "Admin")
            {
                MessageBox.Show("Успешный вход как Admin");
                string user = "Admin";
                MainWindow mainWindow = new MainWindow(user);

                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}

