﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dominio;
using Excepciones;

namespace UI
{
    public abstract partial class VAbstractCampania : Form
    {
        protected ControladorDominio iControladorDominio;
        /// <summary>
        /// Variable que contendrá los títulos del listBoxImagenes. De estos items, se señalizarán con un * aquellos que ya estén guardados en 
        /// previamente (para una Campaña a modificar), y con el path aquellas imagenes recientemente agregadas
        /// </summary>
        protected List<String> iListaCampanias;
        protected int iIndice, iCount;

        public VAbstractCampania()
        {
            InitializeComponent();
        }

        public VAbstractCampania(ref ControladorDominio pControlador) :this()
        {
            this.iControladorDominio = pControlador;
            this.pictureBoxCampania.SizeMode = PictureBoxSizeMode.Zoom;
            this.iIndice = this.iCount = 0;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Interval = 1000;
            this.iListaCampanias = new List<string>();
        }

        protected abstract void timer1_Tick(object sender, EventArgs e);

        /// <summary>
        /// Evento que se activa cuando se da click al botón de agregar imágenes al this.listBoxImagenes
        /// </summary>
        protected abstract void buttonAgregar_Click(object sender, EventArgs e);

        /// <summary>
        /// Evento que se activa al guardar los cambios
        /// </summary>
        protected abstract void buttonGuardar_Click(object sender, EventArgs e);

        /// <summary>
        /// Evento que se activa cuando cambia el item seleccionado en el this.listBoxImagenes
        /// </summary>
        protected abstract void listBoxImagenes_SelectedIndexChanged(object sender, EventArgs e);

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonArriba, para cambiar el orden de las imágenes
        /// </summary>
        protected virtual void buttonArriba_Click(object sender, EventArgs e)
        {
            object item = listBoxImagenes.SelectedItem;
            if (listBoxImagenes.SelectedIndex > 0)
            {
                string curItem = item.ToString();
                listBoxImagenes.Items[listBoxImagenes.SelectedIndex] = listBoxImagenes.Items[listBoxImagenes.SelectedIndex - 1];
                listBoxImagenes.Items[listBoxImagenes.SelectedIndex - 1] = curItem;
                listBoxImagenes.SelectedItem = item;
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonAbajo, para cambiar el orden de las imágenes
        /// </summary>
        protected virtual void buttonAbajo_Click(object sender, EventArgs e)
        {
            object item = listBoxImagenes.SelectedItem;
            if (listBoxImagenes.SelectedIndex < listBoxImagenes.Items.Count - 1)
            {
                string curItem = item.ToString();
                listBoxImagenes.Items[listBoxImagenes.SelectedIndex] = listBoxImagenes.Items[listBoxImagenes.SelectedIndex + 1];
                listBoxImagenes.Items[listBoxImagenes.SelectedIndex + 1] = curItem;
                listBoxImagenes.SelectedItem = item;
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón buttonBorrarImagenes
        /// </summary>
        protected virtual void buttonBorrar_Click(object sender, EventArgs e)
        {
            this.listBoxImagenes.Items.Remove(this.listBoxImagenes.SelectedItem);
            //Aclaración: Si no se encuentra el SelectedItem en el listBoxImagenes, éste permanece sin cambios y no tira ninguna excepción

            //Luego de borrado el item correspondiente, de quedar elementos en el this.listBoxImagenes,selecciona el primer elemento:
            try
            {
                this.listBoxImagenes.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException) // if (this.listBoxImagenes.Items.Count == 0)
            {
                this.pictureBoxCampania.Load(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "/icono/NoImage.png");
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón buttonVistaPrevia, que emula cómo se verían las imágenes de la campania
        /// </summary>
        protected virtual void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
            //EXCEPCION!: que los segundos del intervalo sean mayores a 5 y menores a 30 (por ejemplo)

            if (listBoxImagenes.Items.Count > 0)
            {
                if (!timer1.Enabled)
                {
                    this.buttonVistaPrevia.Text="Detener";
                    this.buttonVistaPrevia.Refresh();
                    this.iListaCampanias.Clear();
                    foreach (var item in this.listBoxImagenes.Items)
                    {
                        this.iListaCampanias.Add(item.ToString());
                    }
                    if (textBoxSegundos.Text != "")
                        timer1.Interval = Convert.ToInt32(this.textBoxSegundos.Text) * 1000;
                    listBoxImagenes.Enabled = false;
                    timer1.Start();
                }
                else
                {
                    this.buttonVistaPrevia.Text = "Vista previa";
                    this.buttonVistaPrevia.Refresh();
                    timer1.Stop();
                    listBoxImagenes.Enabled = true;
                }
            }

        }

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonCancelar, y sale de la ventana sin guardar los cambios
        /// </summary>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.iControladorDominio.CancelarCambios();
            this.Close();
        }

        /// <summary>
        /// Compara para esa pFecha del rango horario del pCampaña, y devuelve qué horarios de esa pFecha 
        /// no están ocupados por ese pCampaña
        /// </summary>
        /// <returns>Devuelve uno o dos intervalos horarios que representan los horarios de esa pFecha 
        /// no están ocupados por ese pCampaña</returns>
        private List<IntervaloHorario> CalcularIntervalosLibres(Campania pCampania, DateTime pFecha)
        {
            List<IntervaloHorario> intervalosLibres = new List<IntervaloHorario>();
            if (pCampania.FechaFin.CompareTo(pFecha) >= 0)
            {
                IntervaloHorario unIntervalo = new IntervaloHorario() { Inicio = new TimeSpan(0), Fin = new TimeSpan(23, 59, 59) };
                if (pCampania.HoraInicio == new TimeSpan(0, 0, 0))
                {
                    if (pCampania.HoraFin == new TimeSpan(23, 59, 59))
                    {
                        unIntervalo = null;
                        intervalosLibres = null;
                    }

                    else
                        unIntervalo.Inicio = pCampania.HoraFin.Add(new TimeSpan(0, 0, 1));
                }
                else
                {
                    unIntervalo.Fin = pCampania.HoraInicio.Subtract(new TimeSpan(0, 0, 1));
                    intervalosLibres.Add(new IntervaloHorario() { Inicio = pCampania.HoraFin.Add(new TimeSpan(0, 0, 1)), Fin = new TimeSpan(23, 59, 59) });
                }
                if (unIntervalo != null)
                    intervalosLibres.Add(unIntervalo);
            }
            return intervalosLibres;
        }

        /// <summary>
        /// Calcula de los intervalos libres en común entre los de la fecha1 (pIntervalos1) y los de la fecha2 (pIntervalos2)
        /// </summary>
        /// <param name="pIntervalos1">intervalos libres de la primera fecha</param>
        /// <param name="pIntervalos2">intervalos libres de la segunda fecha</param>
        /// <returns>Devuelve la lista de intervalos libres en común</returns>
        private List<IntervaloHorario> ObtenerIntervalosEnComun(List<IntervaloHorario> pIntervalos1, List<IntervaloHorario> pIntervalos2)
        {
            List<IntervaloHorario> intervalosDisponibles = new List<IntervaloHorario>();
            foreach (var valor in pIntervalos1)
            {
                foreach (var valor2 in pIntervalos2)
                {
                    if (valor.Inicio.CompareTo(valor2.Inicio) >= 0 && valor.Inicio.CompareTo(valor2.Fin) < 0)
                    {
                        //El inicio del intervalo resultante es siempre el inicio del 1er intervalo 
                        if (valor.Fin.CompareTo(valor2.Fin) <= 0)
                            intervalosDisponibles.Add(valor);
                        else
                            intervalosDisponibles.Add(new IntervaloHorario { Inicio = valor.Inicio, Fin = valor2.Fin });
                    }
                    else if (valor.Fin.CompareTo(valor2.Inicio) > 0 && valor2.Fin.CompareTo(valor.Inicio) > 0)
                    {
                        //El inicio del intervalo resultante es siempre el inicio del 2do intervalo 
                        if (valor.Fin.CompareTo(valor2.Fin) >= 0)
                            intervalosDisponibles.Add(valor2);
                        else
                            intervalosDisponibles.Add(new IntervaloHorario { Inicio = valor2.Inicio, Fin = valor.Fin });
                    }
                }
            }
            return intervalosDisponibles;
        }

        /// <summary>
        /// Muestra en el this.dataGridViewHorariosDisponibles los intervalos disponibles para el rango de fechas
        /// definido por los this.dateTimePickerInicio y this.dateTimePickerFin
        /// </summary>
        private void IntervalosLibresParaUnPeriodo()
        {
            try
            {
                Dictionary<DateTime, List<IntervaloHorario>> horariosLibres = new Dictionary<DateTime, List<IntervaloHorario>>();
                DateTime diaInicio = dateTimePickerInicio.Value.Date;
                DateTime diaFin = dateTimePickerFin.Value.Date;

                List<Campania> lista = this.iControladorDominio.BuscarCampaniaPorAtributo(x => x.FechaFin.CompareTo(diaInicio) >= 0 && x.FechaInicio.CompareTo(diaFin) <= 0);
                List<DateTime> dias = new List<DateTime>();

                for (DateTime i = diaInicio; i <= diaFin; i = i.AddDays(1.0))
                {
                    List<IntervaloHorario> nuevosIntervalos = new List<IntervaloHorario>();
                    List<Campania> campaniasDia = this.iControladorDominio.BuscarCampaniaPorAtributo(x => x.FechaFin.CompareTo(i) >= 0 && x.FechaInicio.CompareTo(i) <= 0);
                    if (campaniasDia.Count == 1)
                    {
                        if (CalcularIntervalosLibres(campaniasDia[0], i) != null)
                            nuevosIntervalos.AddRange(CalcularIntervalosLibres(campaniasDia[0], i));
                    }
                    else if (campaniasDia.Count == 0)
                        nuevosIntervalos.Add(new IntervaloHorario { Inicio = new TimeSpan(0, 0, 0), Fin = new TimeSpan(23, 59, 59) });
                    else
                    {
                        List<IntervaloHorario> intervalosDelDia = new List<IntervaloHorario>();
                        foreach (Campania unCampania in campaniasDia)
                        {
                            intervalosDelDia.AddRange(CalcularIntervalosLibres(unCampania, i));
                        }
                        for (int j = 0; j < intervalosDelDia.Count - 1; j++)
                        {
                            for (int k = j + 1; k < intervalosDelDia.Count; k++)
                            {
                                if (intervalosDelDia[j].Inicio.CompareTo(intervalosDelDia[k].Inicio) <= 0 &&
                                    intervalosDelDia[j].Fin.CompareTo(intervalosDelDia[k].Inicio) >= 0)
                                {
                                    nuevosIntervalos.Add(new IntervaloHorario() { Inicio = intervalosDelDia[k].Inicio, Fin = intervalosDelDia[j].Fin });
                                }
                                else if (intervalosDelDia[k].Inicio.CompareTo(intervalosDelDia[j].Inicio) <= 0 &&
                                    intervalosDelDia[k].Fin.CompareTo(intervalosDelDia[j].Inicio) >= 0)
                                {
                                    nuevosIntervalos.Add(new IntervaloHorario() { Inicio = intervalosDelDia[j].Inicio, Fin = intervalosDelDia[k].Fin });
                                }
                            }
                        }
                    }
                    horariosLibres.Add(i, nuevosIntervalos);
                }
                DateTime diaSiguiente = diaInicio.AddDays(1.0);
                List<IntervaloHorario> nuevoHorariosLibres = horariosLibres[diaInicio];
                while (diaSiguiente.CompareTo(diaFin) <= 0)
                {
                    nuevoHorariosLibres = ObtenerIntervalosEnComun(nuevoHorariosLibres, horariosLibres[diaSiguiente]);
                    diaSiguiente = diaSiguiente.AddDays(1.0);
                }
                dataGridViewHorariosDisponibles.DataSource = null;

                List<IntervaloHorario> intervalosSinSeg = new List<IntervaloHorario>();
                foreach (var item in nuevoHorariosLibres)
                {
                    intervalosSinSeg.Add(new IntervaloHorario { Inicio = item.Inicio.Subtract(new TimeSpan(0, 0, item.Inicio.Seconds)), Fin = item.Fin.Subtract(new TimeSpan(0, 0, item.Fin.Seconds)) });
                }
                dataGridViewHorariosDisponibles.DataSource = intervalosSinSeg.OrderBy(x => x.Inicio).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la sugerencia de intervalos libres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se activa al abrirse por primera vez esta ventana.
        /// </summary>
        private void VAbstractCampania_Load(object sender, EventArgs e)
        {
            IntervalosLibresParaUnPeriodo();
        }

        /// <summary>
        /// Evento que se activa al cambiar el valor del día del this.dateTimePickerInicio
        /// </summary>
        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            //Controles para que la Fecha de Fin sea siempre Mayor a la de Inicio
            try
            {
                if (this.dateTimePickerInicio.Value > this.dateTimePickerFin.Value)
                {
                    throw new ExcepcionFechaFinMayorAFechaInicio("");
                }
            }
            catch (ExcepcionFechaFinMayorAFechaInicio)
            {
                this.dateTimePickerFin.Value = this.dateTimePickerInicio.Value;
            }
            finally
            {
                IntervalosLibresParaUnPeriodo();
            }
        }

        /// <summary>
        /// Evento que se activa al cambiar el valor del día del this.dateTimePickerFin
        /// </summary>
        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            //Controles para que la Fecha de Fin sea siempre Menor a la de Inicio
            try
            {
                if (this.dateTimePickerInicio.Value > this.dateTimePickerFin.Value)
                {
                    throw new ExcepcionFechaFinMenorAFechaInicio("");
                }
            }
            catch (ExcepcionFechaFinMenorAFechaInicio)
            {
                this.dateTimePickerInicio.Value = this.dateTimePickerFin.Value;
            }
            finally
            {
                IntervalosLibresParaUnPeriodo();
            }
        }

        /// <summary>
        /// Evento que se activa cuando se está cerrando el formulario.
        /// Aquí nos aseguramos de actualizar los items de DataGridViewCampania de la ventana contenedora principal (VCampania)
        /// </summary>
        private void VAbstractCampania_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((VCampania)this.MdiParent).CargarDataGridViewCampania(this.iControladorDominio.ObtenerTodasLasCampanias());
        }

        /// <summary>
        /// Función auxiliar que controla que todos los textBoxs estén completados, lanzando una excepción si no fuese así
        /// </summary>
        protected void ValidarTodoCompleto()
        {
            foreach (Control oControls in this.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio. 
                {
                    throw new ExcepcionCampoSinCompletar("Debe completar todos los campos");
                }
            }
        }
    }
}
