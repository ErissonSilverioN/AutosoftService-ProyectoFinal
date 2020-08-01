﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutosoftService.Model;
using AutosoftService.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using AutosoftService.BLL;

namespace AutosoftService.BLL
{
    public class EntradaArtBLL
    {

        public static bool Guardar(EntradasArticulos entradasArticulos)
        {
            if (!Existe(entradasArticulos.EntradasArtId))
                return Insertar(entradasArticulos);
            else
                return Modificar(entradasArticulos);
        }


        public static bool Insertar(EntradasArticulos entradasArticulos)
        {
            bool paso = false;
            Contexto db = new Contexto();

           

            try
            {
                if (db.entradaArt.Add(entradasArticulos) != null)
                {
                    Articulos articulos = ArticuloBLL.Buscar(entradasArticulos.ArticuloId);

                    articulos.Existencia += entradasArticulos.Cantidad;

                    ArticuloBLL.Modificar(articulos);

                    db.SaveChanges();
                    paso = true;


                }

                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return paso;

        }

        public static bool Modificar(EntradasArticulos entradasArticulos)
        {
            bool paso = false;
            Contexto db = new Contexto();


            try
            {
                var articulos = ArticuloBLL.Buscar(entradasArticulos.ArticuloId);
                var anterior = Buscar(entradasArticulos.EntradasArtId);

                articulos.Existencia -= anterior.Cantidad;
                db.entradaArt.Add(entradasArticulos);

                articulos.Existencia += entradasArticulos.Cantidad;
                ArticuloBLL.Modificar(articulos);

                db.Entry(entradasArticulos).State = EntityState.Modified;

                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                db.Dispose();

            }
            return paso;


        }


        public static bool Eliminar(int id)
        {

            bool paso = true;
            Contexto db = new Contexto();
            EntradasArticulos entradasArticulos = new EntradasArticulos();


            try
            {
                entradasArticulos = db.entradaArt.Find(id);
                db.articulos.Find(entradasArticulos.ArticuloId).Existencia -= entradasArticulos.Cantidad;

                db.entradaArt.Remove(entradasArticulos);
                // contexto.Entry(inscripcion).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }


        public static EntradasArticulos Buscar(int id)
        {

            Contexto db = new Contexto();
            EntradasArticulos entradasArticulos = new EntradasArticulos();
           

            try
            {

                entradasArticulos = db.entradaArt.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return entradasArticulos;
        }



        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();


            try
            {

                encontrado = db.entradaArt.Any(p => p.EntradasArtId == id);


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return encontrado;

        }





        public static List<EntradasArticulos> GetList(Expression<Func<EntradasArticulos, bool>> expression)
        {
            List<EntradasArticulos> Lista = new List<EntradasArticulos>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.entradaArt.Where(expression).ToList();
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;

        }

    }
}
