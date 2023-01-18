using Loja_VesteBem.Telas;
using Loja_VesteBem.Telas.Cadastrar_Adiministrador;
using Loja_VesteBem.Telas.Consultar_Fornecedores;
using Loja_VesteBem.Telas.Consultar_Pedidos;
using Loja_VesteBem.Telas.Entrega;
using Loja_VesteBem.Telas.Fornecedores;
using Loja_VesteBem.Telas.Menu;
using Loja_VesteBem.Telas.Menu_ADM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_VesteBem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
