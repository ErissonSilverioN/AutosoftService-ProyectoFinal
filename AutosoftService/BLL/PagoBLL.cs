﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutosoftService.Model;
using AutosoftService.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AutosoftService.BLL
{
    public class PagoBLL
    {

        public static bool Guardar(Pagos pagos)
        {
            if (!Existe(pagos.PagoId))
                return Insertar(pagos);
            else
                return Modificar(pagos);
        }


        private static bool Insertar(Pagos pagos)
        {
            bool paso = false;
            Contexto db = new Contexto();


            try
            {
                if (db.pagos.Add(pagos) != null)
                {
                    db.clientes.Find(pagos.ClienteId).Deuda -= pagos.Monto;
                    paso = db.SaveChanges() > 0;

                }
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



        public static bool Modificar(Pagos pagos)
        {
            bool paso = false;
            Contexto db = new Contexto();


            try
            {
                Pagos pagosTemp = db.pagos.Find(pagos.PagoId);
                Clientes clientes = ClienteBLL.Buscar(pagosTemp.ClienteId);

                clientes.Deuda += pagosTemp.Monto;
                db.Entry(clientes).State = EntityState.Modified;

                paso = db.SaveChanges() > 0;

                if (paso)
                {
                    db = new Contexto();
                    db.clientes.Find(pagos.ClienteId).Deuda -= pagos.Monto;
                    db.Entry(pagos).State = EntityState.Modified;
                    paso = db.SaveChanges() > 0;
                }
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
            bool paso = false;
            Contexto db = new Contexto();
            Pagos pagos = new Pagos();

            try
            {
                pagos = db.pagos.Find(id);
                db.clientes.Find(pagos.ClienteId).Deuda += pagos.Monto;

                db.Entry(pagos).State = EntityState.Deleted;
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


        public static Pagos Buscar(int id)
        {

            Contexto db = new Contexto();
            Pagos pagos = new Pagos();

            try
            {
                pagos = db.pagos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }


            return pagos;
        }


        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();


            try
            {

                encontrado = db.pagos.Any(p => p.PagoId == id);


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


        public static List<Pagos> GetList(Expression<Func<Pagos, bool>> expression)
        {


            List<Pagos> lista = new List<Pagos>();
            Contexto db = new Contexto();


            try
            {
                lista = db.pagos.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                db.Dispose();

            }

            return lista;
        }



    }
}
