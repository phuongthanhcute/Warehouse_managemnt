﻿using QuanlyKhooooo.ViewModel;
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

namespace QuanlyKhooooo.UserControlThanh
{
    /// <summary>
    /// Interaction logic for Header.xaml
    /// </summary>
    public partial class Header : UserControl
    {
        public HeaderViewModel ViewModel { get; set; }
        public Header() 
        {
            InitializeComponent();
            this.DataContext = ViewModel = new HeaderViewModel();
        }
    }
}
