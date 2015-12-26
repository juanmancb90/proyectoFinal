﻿/*
 * Nombre de la Clase: VendedoresBL
 * Descripcion: Toma objetos de tipo SQLVendedores creado desde la capa Data_Access_Layer y lo pasa a la capa User_Interface
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> List<Vendedores> ObtenerVendedores(string cs)
 * >> bool AutenticarVendedores(string nombreUsuario, string contrasenia)
 */

using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class VendedoresBL
    {
        /* 
         * Metodo
         * Descripcion: Retornar un listado de vendedores
         * Entrada: string
         * Salida: List<Vendedores>
         */
        public List<Vendedores> ObtenerVendedores(string cs)
        {
            VendedoresDAL contexto = new VendedoresDAL(cs);
            List<Vendedores> vendedores = contexto.ObtenerVendedor();
            return (vendedores);
        }

        /* 
         * Metodo
         * Descripcion: Autenticar a un vendedor
         * Entrada: string, string
         * Salida: bool
         */
        public bool AutenticarVendedores(string nombreUsuario, string contrasenia)
        {
            VendedoresDAL contexto = new VendedoresDAL();
            bool autenticacion = contexto.AutenticarVendedor(nombreUsuario, contrasenia);
            return (autenticacion);
        }
    }
}
