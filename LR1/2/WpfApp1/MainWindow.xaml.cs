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
using ЛабТП1.Kontroler;
using ЛабТП1.Model;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        order oformlenie = new order();
        menu todayMenu;
        int Mode;
        public MainWindow()
        {
            todayMenu = new menu();

            InitializeComponent();

            MenuView.ItemsSource = todayMenu.MyMenu;
            OrderList.ItemsSource = oformlenie.C;
            AllOrders.ItemsSource = oformlenie.D;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MenuView.SelectedItem == null)
            {
                MessageBox.Show("Выберите блюдо из меню");
            }
            else
                try
                {
                    bool v = oformlenie.ChoseItem((interfacefood)MenuView.SelectedItem, Convert.ToInt32(Kolvo.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Введите количество с помощью цифр");
                }
            OrderList.Items.Refresh();
        }

        private void EndOrder_Click(object sender, RoutedEventArgs e)
        {
            if (OrderList.Items.Count == 0)
            {
                MessageBox.Show("Выберите блюдо из меню");
            }
            else
                try
                {
                    oformlenie.FinishOrder();
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите блюдо из меню");
                }
            AllOrders.Items.Refresh();
        }

        private void ClearOrderClick(object sender, RoutedEventArgs e)
        {
            if (OrderList.Items.Count == 0)
            {
                MessageBox.Show("Выберите блюдо из меню");
            }
            else
                try
                {
                    OrderList.ItemsSource = oformlenie.C;
                }
                catch
                {
                    MessageBox.Show("Выберите блюдо из меню");
                }
        }


        private void MenuView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NextList(object sender, RoutedEventArgs e)
        {
            MenuView.ItemsSource = todayMenu.MyMenu;
            switch (Mode)
            {
                case 0:
                    {
                        Mode = 1;
                        todayMenu = new menu(Mode);
                        MenuView.ItemsSource = todayMenu.MyMenu;
                        break;
                    }

                case 1:
                    {
                        Mode = 2;
                        todayMenu = new menu(Mode);
                        MenuView.ItemsSource = todayMenu.MyMenu;
                        break;
                    }
                case 2:
                    {
                        Mode = 3;
                        todayMenu = new menu(Mode);
                        MenuView.ItemsSource = todayMenu.MyMenu;
                        break;
                    }
                case 3:
                    {
                        Mode = 4;
                        todayMenu = new menu(Mode);
                        MenuView.ItemsSource = todayMenu.MyMenu;
                        break;
                    }
                case 4:
                    {
                        Mode = 0;
                        todayMenu = new menu(Mode);
                        MenuView.ItemsSource = todayMenu.MyMenu;
                        break;
                    }
            }
        }

        private void OldOrderView_Click(object sender, RoutedEventArgs e)
        {
                if (AllOrders.SelectedItem == null)
                {
                    MessageBox.Show("Выберите заказ из списка");
                }
                else
                    try
                    {
                        OrderList.ItemsSource = ((total)AllOrders.SelectedItem).orderlist;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Выберите заказ из списка");
                    }
            }

        private void AllOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }