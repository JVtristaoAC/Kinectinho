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
using System.Windows.Shapes;

namespace Kinectinho.View.Dancas
{
    /// <summary>
    /// Lógica interna para Danca3.xaml
    /// </summary>
    public partial class Danca3 : Window
    {
        public Danca3()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow janela = new MainWindow();
            janela.Show();
            this.Hide();
        }
    }
}
