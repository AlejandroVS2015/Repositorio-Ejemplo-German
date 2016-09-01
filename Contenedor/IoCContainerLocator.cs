using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using System.Windows;
using Persistencia;
using Excepciones;

namespace Contenedor
{
    /// <summary>
    /// Acceso al contenedor de IoC (Contenedor de Inversión de Control).
    /// </summary>
    public static class IoCContainerLocator
    {

        /// <summary>
        /// Instancia lazy del contenedor de IoC.
        /// </summary>
        private static readonly Lazy<IUnityContainer> cInstance = new Lazy<IUnityContainer>(() =>
        {
            IUnityContainer mUnityContainer = new UnityContainer();

            try
            {
                mUnityContainer.RegisterType<IEntityFrameworkUnitOfWork, ProyectoUnitOfWork>(new ContainerControlledLifetimeManager());

                mUnityContainer.RegisterType<IRepositorio<Campania>, Repositorio<Campania>>(new InjectionConstructor
                    (typeof(IEntityFrameworkUnitOfWork)));


                mUnityContainer.RegisterType<IRepositorio<Banner>, Repositorio<Banner>>(new InjectionConstructor
                    (typeof(IEntityFrameworkUnitOfWork)));

                mUnityContainer.RegisterType<IRepositorio<FuenteRss>, Repositorio<FuenteRss>>(new InjectionConstructor
                    (typeof(IEntityFrameworkUnitOfWork)));
            }

            catch (Exception ex)
            {
                throw new ExcepcionGeneral("Error en la inicialización del contenedor",ex);
            }

            return mUnityContainer;
        });

        public static IUnityContainer Container
        {
            get { return cInstance.Value; }
        }
    }
}
