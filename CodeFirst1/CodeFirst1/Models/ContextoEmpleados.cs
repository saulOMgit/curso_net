using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CodeFirst1.Models
{
    public class ContextoEmpleados:DbContext
    {
        /*Conexion*/
        public ContextoEmpleados() : base("CadenaEmpleados") { }
        /*Empleados*/
        public DbSet<Empleado> Empleados { get; set; }

        /*Evitar plurales en Tabla*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }

    
}