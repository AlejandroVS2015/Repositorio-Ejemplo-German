using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class BannerDeslizante : TextBox
    {
        private Timer iTimerTexto;
        private int iCaracterInicial;

        [DefaultValue("")]
        public string TextoCompleto { get; set; }

        public int CaracteresAMostrar { get; set; }

        public BannerDeslizante()
        {
            this.iCaracterInicial = 0;
            this.iTimerTexto = new Timer();
            this.iTimerTexto.Interval = 250;
            this.iTimerTexto.Tick += new EventHandler(timerTexto_Tick);
        }

        void timerTexto_Tick(object sender, EventArgs e)
        {
            if (this.TextoCompleto.Length <= this.CaracteresAMostrar)
            {
                this.Text = this.TextoCompleto;
                this.TextoCompleto = this.CorrerCaracterIzquierda(this.TextoCompleto);
            }
            else
            {
                int limite = this.TextoCompleto.Length - (this.iCaracterInicial + this.CaracteresAMostrar);
                string valor = null;
                if (limite >= 0)
                {
                    valor = this.TextoCompleto.Substring(this.iCaracterInicial, this.CaracteresAMostrar);
                }
                else
                {
                    valor = string.Concat(this.TextoCompleto.Substring(this.iCaracterInicial),
                      this.TextoCompleto.Substring(0, Math.Abs(limite)));
                }
                iCaracterInicial++;
                if (iCaracterInicial == this.TextoCompleto.Length) iCaracterInicial = 0;
                    this.Text = valor;
            }
        }

        private string CorrerCaracterIzquierda(String pTexto)
        {
            string textoNuevo = "";

            for (int i = 0; i < pTexto.Length - 1; i++)
            {
                textoNuevo = textoNuevo + pTexto[i + 1];
            }

            return textoNuevo;
        }

        public void Start()
        {
            this.iTimerTexto.Start();
        }
        public void Stop()
        {
            if (this.iTimerTexto.Enabled == true)
                this.iTimerTexto.Stop();
        }
    }
}