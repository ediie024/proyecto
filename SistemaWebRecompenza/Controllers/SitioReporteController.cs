using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaWebRecompenza.BD;
using SistemaWebRecompenza.Models;

namespace SistemaWebRecompenza.Controllers
{
    [Authorize]
    
    public class SitioReporteController : Controller
    {
        private readonly ProyectoContext _context;

        public SitioReporteController(ProyectoContext _context)
        {
            this._context = _context;
        }

        // GET
        public IActionResult Index(String busqueda="")
        {
            Usuario user = LoggedUser();
            var query = _context.Objetos.AsQueryable();
            if (!String.IsNullOrEmpty(busqueda))
            {
                query = query.Where(o => o.Nombre.Contains(busqueda));
            }
            var querylista = query.ToList();
            var IdOBjetos = querylista.Select(o => o.Id).ToList();
            Dictionary<int,Objeto> diccionarioDeObjetos= new Dictionary<int, Objeto>();
            foreach (var Item in querylista)
            {
                diccionarioDeObjetos.Add(Item.Id,Item);
            }

            var reportess = _context.Reportes.ToList().Select(o => o.Id).Intersect(IdOBjetos).ToList();

            var reporteLista = _context.Reportes.ToList();
            Dictionary<int,Reporte> diccionarioReportes= new Dictionary<int, Reporte>();
            foreach (var Item in reporteLista)
            {
                diccionarioReportes.Add(Item.Id,Item);
            }
            var Categoria = _context.Categorias.ToList();
            Dictionary<int,Categoria> diccionarioCategoria= new Dictionary<int, Categoria>();
            foreach (var item in Categoria)
            {
                diccionarioCategoria.Add(item.Id,item);
            }

            var espacio = "  ";
            
            var DetalleObjetoCategoria = _context.DetalleObjetoCategorias.ToList();
            ViewBag.DiccionarioCategoria = diccionarioCategoria;
            ViewBag.DiccionarioObjetos = diccionarioDeObjetos;
            ViewBag.DiccionarioReporte = diccionarioReportes;
            ViewBag.IdReportes = reportess;
            ViewBag.Objetos = querylista;
            ViewBag.DetalleObjetoCategoria = DetalleObjetoCategoria;
            ViewBag.Espacio = espacio;
            
            
            
            return View();
        }

        public IActionResult CrearReporte()
        {
            ViewBag.Tipo = _context.Categorias.ToList();
            return View();
        }

        public IActionResult CrearReporteA()
        {
            
            return RedirectToAction("Index");
        }
        
        
        private Usuario LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = _context.Usuarios.Where(o => o.Username == claim.Value).FirstOrDefault();
            return user;
        }
    }
}