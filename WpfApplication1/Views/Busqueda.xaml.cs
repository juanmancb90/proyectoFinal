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
using WpfApplication1.Modelo;

namespace WpfApplication1.Views
{
    /// <summary>
    /// Interaction logic for Busqueda.xaml
    /// </summary>
    public partial class Busqueda : UserControl
    {
        public Busqueda()
        {
            InitializeComponent();
            Empresa empresa = new Empresa { Barrio = "El viejo Barrrio", Descripcion = "Abarrotes Bastidas", Direccion = "UNIVALLE", NombreContacto = "Jaime Bastidas", Telefono = "3355705" };
            this.DataContext = empresa;
        }
    }
}
