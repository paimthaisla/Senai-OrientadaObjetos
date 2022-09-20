﻿using AplicacaoPoo.Estrutural.Windows.Funcionalidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmPrincipal : Form //classe
    {
        public frmPrincipal()  //construtor //identificar p construtor - campos já pré-definidos.9                                                                                                                                                                                                                                                                                          
        {
            InitializeComponent();
        
        }

        private void btnAbrirFormConversão_Click(object sender, EventArgs e)
        {
            var form = new frmConversãoReal();
            form.Show();
        }

        private void btnAbrirFormPagamento_Click(object sender, EventArgs e)
        {
            var form = new frmPagamento();
            form.Show();
        }

        private void btnAbrirFormConversãoValorReal_MouseHover(object sender, EventArgs e)
        {
           btnAbrirFormConversãoValorReal.BackColor = Color.Black;
        }
    }
}
