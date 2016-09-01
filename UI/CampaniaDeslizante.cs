using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using System.IO;

namespace UI
{
    public class CampaniaDeslizante : PictureBox
    {
        private Timer iTimerImagenes;

        public Campania Campania { get; set; }
        private int iIndice, iCount;
        private List<Imagen> iListaOrdenada;
        //public string Intervalo { get; set; }

        public CampaniaDeslizante()
        {
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VAbstractCampania));
            //this.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            //this.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iTimerImagenes = new Timer();
            this.iTimerImagenes.Tick += new EventHandler(timerImagen_Tick);

            this.iIndice = this.iCount = 0;
            this.iListaOrdenada = new List<Imagen>();
        }

        public void timerImagen_Tick(object sender, EventArgs e)
        {
            if (this.iCount < 1)
            {
                this.iCount++;
            }
            else
            {
                this.iIndice++;
                if (this.iIndice <= this.iListaOrdenada.Count - 1)
                {
                    this.Image = this.ByteToImage(this.iListaOrdenada[this.iIndice].Bytes);
                    this.iCount = 0;
                }
                else
                    this.iIndice = -1;
            }
        }

        public Bitmap ByteToImage(byte[] pBytes)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] data = pBytes;
            mStream.Write(data, 0, Convert.ToInt32(data.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;

        }

        public void Start()
        {
            if (this.Campania.DuracionImagen * 1000>0)
                this.iTimerImagenes.Interval = this.Campania.DuracionImagen * 1000;
            else
                this.iTimerImagenes.Interval = 1000;
            this.iListaOrdenada=this.Campania.Imagenes.OrderBy(x => x.Orden).ToList();
            //this.iTimerImagenes.Interval = Convert.ToInt16(Intervalo);
            this.iTimerImagenes.Start();
        }
        public void Stop()
        {
            if(this.iTimerImagenes.Enabled)
                this.iTimerImagenes.Stop();
        }

        //public void SetCampania(Campania pCampania)
        //{
        //    this.iCampania = pCampania;
        //}

    }
}