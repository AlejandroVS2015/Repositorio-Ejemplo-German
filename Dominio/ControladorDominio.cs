using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Excepciones;


namespace Dominio
{
    public class ControladorDominio
    {
        private IRepositorio<Banner> iRepositorioBanner;
        private IRepositorio<Campania> iRepositorioCampania;
        private IRepositorio<FuenteRss> iRepositorioFuenteRss;


        #region Generales

        public ControladorDominio(IRepositorio<Banner> pRepositorioBanner, IRepositorio<Campania> pRepositorioCampania, 
            IRepositorio<FuenteRss> pRepositorioFuenteRss)
        {
            this.iRepositorioBanner = pRepositorioBanner;
            this.iRepositorioCampania = pRepositorioCampania;
            this.iRepositorioFuenteRss = pRepositorioFuenteRss;
        }

        public void GuardarCambios()
        {
            this.iRepositorioFuenteRss.UnitOfWork.Commit();
            this.iRepositorioBanner.UnitOfWork.Commit();
            this.iRepositorioCampania.UnitOfWork.Commit();
        }

        public void CancelarCambios()
        {
            try
            {
                this.iRepositorioBanner.UnitOfWork.Rollback();
                this.iRepositorioCampania.UnitOfWork.Rollback();
                this.iRepositorioFuenteRss.UnitOfWork.Rollback();
            }
            catch (ExcepcionAlCargarPantalla) { }
        }
        #endregion

        #region Banner
        public void AgregarBanner(Banner pBanner)
        {
            this.iRepositorioBanner.Agregar(pBanner);
        }

        public void ModificarBanner(Banner pBanner)
        {
            this.iRepositorioBanner.Modificar(pBanner);
        }

        public void BorrarBanner(Banner pBanner)
        {
            this.iRepositorioBanner.Borrar(pBanner);
        }

        public void BorrarBanner(int pCodigo)
        {
            this.iRepositorioBanner.Borrar(pCodigo);
        }

        public Banner BuscarBannerPorId(int pId)
        {
            try {return this.iRepositorioBanner.ObtenerPorId(pId); }
            catch(ExcepcionAlCargarPantalla ex) { throw new ExcepcionErrorEnLaBusqueda("No se ha podido realizar la búsqueda del banner",ex); }
        }

        public List<Banner> BuscarBannerPorAtributo(Expression<Func<Banner, bool>> filter = null)
        {
            try { return this.iRepositorioBanner.ObtenerPorAtributo(filter).ToList(); }
            catch (ExcepcionAlCargarPantalla ex) { throw new ExcepcionErrorEnLaBusqueda("No se ha podido realizar la búsqueda", ex); }
        }

        public List<Banner> ObtenerTodosLosBanners()
        {
            try { return this.iRepositorioBanner.ObtenerTodos().ToList(); }
            catch (ExcepcionAlCargarPantalla ex) { throw new ExcepcionErrorEnLaBusqueda("No se han podido obtener todos los banners correspondientes",ex); }
        }
        #endregion

        #region Campania

        public void AgregarCampania(Campania pCampania)
        {
            this.iRepositorioCampania.Agregar(pCampania);
        }

        public void ModificarCampania(Campania pCampania)
        {
            this.iRepositorioCampania.Modificar(pCampania);
        }

        public void BorrarCampania(Campania pCampania)
        {
            this.iRepositorioCampania.Borrar(pCampania);
        }

        public void BorrarCampania(int pCodigo)
        {
            this.iRepositorioCampania.Borrar(pCodigo);
        }

        public List<Campania> ObtenerTodasLasCampanias()
        {
            try { return iRepositorioCampania.ObtenerTodos().ToList(); }
            catch (ExcepcionAlCargarPantalla ex) { throw new ExcepcionErrorEnLaBusqueda("No se han podido obtener obtener todas las campañas correspondientes",ex); }
        }

        public Campania BuscarCampaniaPorId(int pId)
        {
            try { return this.iRepositorioCampania.ObtenerPorId(pId); }
            catch (ExcepcionAlCargarPantalla ex) { throw new ExcepcionErrorEnLaBusqueda("No se ha podido realizar la búsqueda de la campaña",ex); }
        }

        public List<Campania> BuscarCampaniaPorAtributo(Expression<Func<Campania, bool>> filter = null)
        {
            try { return this.iRepositorioCampania.ObtenerPorAtributo(filter).ToList(); }
            catch (ExcepcionAlCargarPantalla ex) { throw new ExcepcionErrorEnLaBusqueda("No se ha podido realizar la búsqueda",ex); }
        }
        #endregion

        #region FuenteRss
        public void AgregarFuente(FuenteRss pFuente)
        {
            this.iRepositorioFuenteRss.Agregar(pFuente);
        }

        public void ModificarFuente(FuenteRss pFuente)
        {
            this.iRepositorioFuenteRss.Modificar(pFuente);
        }

        public void BorrarFuente(int pCodigo)
        {
            this.iRepositorioFuenteRss.Borrar(pCodigo);
        }

        public FuenteRss BuscarFuenteRssPorId(int pId)
        {
            try { return this.iRepositorioFuenteRss.ObtenerPorId(pId); }
            catch (ExcepcionAlCargarPantalla ex) { throw new ExcepcionErrorEnLaBusqueda("No se ha podido realizar la búsqueda de la fuente rss",ex); }
        }

        public List<FuenteRss> BuscarFuenteRssPorAtributo(Expression<Func<FuenteRss, bool>> filter = null)
        {
            try { return this.iRepositorioFuenteRss.ObtenerPorAtributo(filter).ToList(); }
            catch (ExcepcionAlCargarPantalla ex) { throw new ExcepcionErrorEnLaBusqueda("No se ha podido realizar la búsqueda",ex); }
        }

        public List<FuenteRss> ObtenerTodasLasFuentes()
        {
            try { return iRepositorioFuenteRss.ObtenerTodos().ToList(); }
            catch (ExcepcionAlCargarPantalla ex) { throw new ExcepcionErrorEnLaBusqueda("No se han podido obtener obtener todas las fuentes rss correspondientes",ex); }
        }
        #endregion


    }
}
