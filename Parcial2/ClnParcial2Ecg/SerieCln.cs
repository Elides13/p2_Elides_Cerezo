using CadParcial2Ecg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnParcial2Ecg
{
    public class ClnSerie
    {
        public static int insertar(Serie serie)
        {
            using (var context = new Parcial2EcgEntities())
            {
                context.Serie.Add(serie);
                context.SaveChanges();
                return serie.id;
            }
        }

        public static int actualizar(Serie serie)
        {
            using (var context = new Parcial2EcgEntities())
            {
                var existente = context.Serie.Find(serie.id);
                if (existente != null)
                {
                    existente.titulo = serie.titulo;
                    existente.sinopsis = serie.sinopsis;
                    existente.director = serie.director;
                    existente.episodios = serie.episodios;
                    existente.fechaEstreno = serie.fechaEstreno;
                    existente.estado = serie.estado;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new Parcial2EcgEntities())
            {
                var serie = context.Serie.Find(id);
                if (serie != null)
                {
                    serie.estado = -1;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static Serie obtenerUno(int id)
        {
            using (var context = new Parcial2EcgEntities())
            {
                return context.Serie.Find(id);
            }
        }

        public static List<Serie> listar()
        {
            using (var context = new Parcial2EcgEntities())
            {
                return context.Serie.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paSerieListar_Result> listarPa(string parametro)
        {
            using (var context = new Parcial2EcgEntities())
            {
                return context.paSerieListar(parametro).ToList();
            }
        }

    }
}
