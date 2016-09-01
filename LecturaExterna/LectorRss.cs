using System;
using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    /// <summary>
    /// Implementación de base del lector de RSS.
    /// </summary>
    public abstract class LectorRss : ILector
    {

        public IEnumerable<ItemRss> Read(String pUrl)
        {
            if (String.IsNullOrWhiteSpace(pUrl))
            {
                throw new ArgumentException("pUrl");
            }

            return this.Read(new Uri(pUrl));
        }

        public abstract IEnumerable<ItemRss> Read(Uri pUrl);
    }
}
