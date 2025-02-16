﻿using Kinectinho.Model;
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

namespace Kinectinho.View
{
    /// <summary>
    /// Lógica interna para TelaPontos.xaml
    /// </summary>
    public partial class TelaPontos : Window
    {
        public TelaPontos()
        {
            InitializeComponent();
            lbl_Pontos.Content = Pontuacao.Pontos.ToString();
        }
        private void Minimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;


        }
        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            Pontuacao.Pontos = 0;
            this.Close();
        }

        private void btnRepetir_Click(object sender, RoutedEventArgs e)
        {
            switch (Pontuacao.Danca)
            {
                case 1:
                    Dancas.Danca1 janela = new Dancas.Danca1();
                    janela.Show();
                    this.Close();
                    break;
                case 2:
                    Dancas.Danca2 janela2 = new Dancas.Danca2();
                    janela2.Show();
                    this.Close();
                    break;
                case 3:
                    Dancas.Danca3 janela3 = new Dancas.Danca3();
                    janela3.Show();
                    this.Close();
                    break;

                case 4:
                    Dancas.Danca4 janela4 = new Dancas.Danca4();
                    janela4.Show();
                    this.Close();
                    break;

              
            }
            
            Pontuacao.Pontos = 0;
           
        }

        private void btnEscolha_Click(object sender, RoutedEventArgs e)
        {
            Pontuacao.Pontos = 0;
            TelaMenu janela = new TelaMenu();
            janela.Show();
            this.Close();
        }
    }
}
