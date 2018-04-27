﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoResidencias.Clases
{
    class Variables
    { 
        //String de conexion a la base de datos
        public static string scon = ("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");
        //Variable de busqueda de grid
        public static string ConsultaBuscar;
        //familias
        public static string IDFamilia;
        public static string DescripcionFamilia;
        //marcas
        public static string IDMarcas;
        public static string DescripcionMarcas;
        //areas
        public static string IdAreas;
        public static string DescripcionAreas;
        //Departamentos
        public static string IdDeptos;
        public static string DescripcionDeptos;
        public static string DireccionDeptos;
        public static string SubDeptos;
        //Empleados
        public static string IdEmpleados;
        public static string EmpleadosBaja;
        public static string EmpleadosBloqueado;
        public static string EmpleadosPliegos;
        public static string EmpleadosNoPliegos;
        public static string EmpleadosJefe;
        public static string EmpleadosNombre;
        public static string EmpleadosDepto;
        public static string EmpleadosLicencia;
        public static string EmpleadosFecha;
        public static string EmpleadosNombreP;
        public static string EmpleadosNumJefe;
        //proveedores
        public static string IdProveedores;
        //SubDireccion
        public static string IdSubD;
        public static string DescripcionSubD;
        //Bienes Dados de Baja
        public static string IdBienesB;
        public static string BienesBMotivoBaja;
        public static string BienesBObservacion;
        public static string BienesBValor;
        public static string MotivoBaja;
        //CatArticulos
        public static string IdArticulo;
        public static string ArticuloDescripcion;
        public static string ArticuloContrato;
        public static string ArticuloInventariable;
        public static string ArticuloFamilia;
        public static string ArticuloMedida;
        public static string ArticuloTipo;
        //Bienes
        public static string IdBienes;
        public static string BienesEtiqueta;
        public static string BienesOrdenCompra;
        public static string BienesFactura;
        public static string BienesTotal;
        public static string BienesFamilia;
        public static string BienesDescripcionArticulo;
        public static string BienesEmpleado;
        public static string BienesDepartamento;
        public static string BienesConsumible;
        public static string BienesObservacion;
        //BienesSF
        public static string IdBienesSF;
        public static string BienesSFEtiqueta;
        public static string BienesSFOrdenCompra;
        public static string BienesSFTotal;
        public static string BienesSFFamilia;
        public static string BienesSFDescripcionArticulo;
        public static string BienesSFEmpleado;
        public static string BienesSFDepartamento;
        public static string BienesSFConsumible;
        public static string BienesSFObservacion;
        //Imrimir Etiquetas
        public static string IEtiqueta;
        public static string IArticulo;
        //Login
        public static string Usuario="x";
        
    }
}
