using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProyectoResidencias
{
    public partial class CONF_IMPRESORA : Form
    {
        public CONF_IMPRESORA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(Application.StartupPath, "ImpresoraEtiquetas.txt");
            string texto = ConImpresora.Text;
            using (StreamWriter writer = new StreamWriter(ruta, false, Encoding.UTF8))
            {
                
                writer.Write(texto);
            }
            MessageBox.Show("Impresora configurada correctamente");
            this.Close();
        }

        private void CONF_IMPRESORA_Load(object sender, EventArgs e)
        {
            String line;
            try
            {
                string ruta = Path.Combine(Application.StartupPath, "ImpresoraEtiquetas.txt");
                StreamReader sr = new StreamReader(ruta);

                while ((line = sr.ReadLine()) != null)
                {
                    ConImpresora.Text = line;
                    sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
        }
    }
}
