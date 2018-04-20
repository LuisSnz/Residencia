using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoResidencias.Clases
{
    class Variables
    { 
        //String de conexion a la base de datos
        public static string scon = ("Data Source=.;Initial Catalog=ActivoJcas;User ID=JMAS;Password=qwerty");
        //familias
        public static string IDFamilia;
        public static string DescripcionFamilia;
        //marcas
        public static string IDMarcas;
        public static string DescripcionMarcas;
        //areas
        public static string IdAreas;
        public static string DescripcionAreas;
        //Articulos

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
        //Vehiculos

        //Bienes Dados de Baja
        public static string IdBienesB;
        public static string BienesBMotivoBaja;
        public static string BienesBObservacion;
        public static string BienesBValor;

        public static string CHArticuloContrato;
        public static string CHInventariable;
        public static string ConsultaBuscar;
        public static string lbOrdenCompra;
        public static string lbFactura;
        public static string tbArticulo;
        public static string tbObservacion;
        public static string tbResguardoA;
        public static string tbDepartamentoA;
        public static string MotivoBaja;
        public static string Usuario="x";
        public static string Familia;
    }
}
