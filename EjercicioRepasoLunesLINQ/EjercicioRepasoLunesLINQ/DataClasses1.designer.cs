﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EjercicioRepasoLunesLINQ
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RepasoLunes")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::EjercicioRepasoLunesLINQ.Properties.Settings.Default.RepasoLunesConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscarIDCuenta")]
		public ISingleResult<buscarIDCuentaResult> buscarIDCuenta([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDCuenta", DbType="VarChar(5)")] string iDCuenta)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDCuenta);
			return ((ISingleResult<buscarIDCuentaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EliminarCliente")]
		public int EliminarCliente([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDCliente", DbType="VarChar(5)")] string iDCliente)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDCliente);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insertarcliente")]
		public int insertarcliente([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(5)")] string idcliente, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string apellido, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string nombre)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idcliente, apellido, nombre);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Modificarcliente")]
		public int Modificarcliente([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(5)")] string idcliente, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string apellido, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string nombre)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idcliente, apellido, nombre);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListarClientes")]
		public ISingleResult<ListarClientesResult> ListarClientes()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ListarClientesResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscarApellido")]
		public ISingleResult<buscarApellidoResult> buscarApellido([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Apellido", DbType="VarChar(30)")] string apellido)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), apellido);
			return ((ISingleResult<buscarApellidoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscarIDCliente")]
		public ISingleResult<buscarIDClienteResult> buscarIDCliente([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDCliente", DbType="VarChar(5)")] string iDCliente)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDCliente);
			return ((ISingleResult<buscarIDClienteResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.buscarNombre")]
		public ISingleResult<buscarNombreResult> buscarNombre([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(30)")] string nombre)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre);
			return ((ISingleResult<buscarNombreResult>)(result.ReturnValue));
		}
	}
	
	public partial class buscarIDCuentaResult
	{
		
		private string _IDCLIENTE;
		
		private string _IDCUENTA;
		
		private System.Nullable<double> _SALDO;
		
		private string _DIVISA;
		
		public buscarIDCuentaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCLIENTE", DbType="VarChar(5)")]
		public string IDCLIENTE
		{
			get
			{
				return this._IDCLIENTE;
			}
			set
			{
				if ((this._IDCLIENTE != value))
				{
					this._IDCLIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCUENTA", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string IDCUENTA
		{
			get
			{
				return this._IDCUENTA;
			}
			set
			{
				if ((this._IDCUENTA != value))
				{
					this._IDCUENTA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALDO", DbType="Float")]
		public System.Nullable<double> SALDO
		{
			get
			{
				return this._SALDO;
			}
			set
			{
				if ((this._SALDO != value))
				{
					this._SALDO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIVISA", DbType="VarChar(20)")]
		public string DIVISA
		{
			get
			{
				return this._DIVISA;
			}
			set
			{
				if ((this._DIVISA != value))
				{
					this._DIVISA = value;
				}
			}
		}
	}
	
	public partial class ListarClientesResult
	{
		
		private string _IDCLIENTE;
		
		private string _APELLIDOS;
		
		private string _NOMBRE;
		
		public ListarClientesResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCLIENTE", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string IDCLIENTE
		{
			get
			{
				return this._IDCLIENTE;
			}
			set
			{
				if ((this._IDCLIENTE != value))
				{
					this._IDCLIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDOS", DbType="VarChar(30)")]
		public string APELLIDOS
		{
			get
			{
				return this._APELLIDOS;
			}
			set
			{
				if ((this._APELLIDOS != value))
				{
					this._APELLIDOS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="VarChar(30)")]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this._NOMBRE = value;
				}
			}
		}
	}
	
	public partial class buscarApellidoResult
	{
		
		private string _IDCLIENTE;
		
		private string _APELLIDOS;
		
		private string _NOMBRE;
		
		public buscarApellidoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCLIENTE", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string IDCLIENTE
		{
			get
			{
				return this._IDCLIENTE;
			}
			set
			{
				if ((this._IDCLIENTE != value))
				{
					this._IDCLIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDOS", DbType="VarChar(30)")]
		public string APELLIDOS
		{
			get
			{
				return this._APELLIDOS;
			}
			set
			{
				if ((this._APELLIDOS != value))
				{
					this._APELLIDOS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="VarChar(30)")]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this._NOMBRE = value;
				}
			}
		}
	}
	
	public partial class buscarIDClienteResult
	{
		
		private string _IDCLIENTE;
		
		private string _APELLIDOS;
		
		private string _NOMBRE;
		
		public buscarIDClienteResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCLIENTE", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string IDCLIENTE
		{
			get
			{
				return this._IDCLIENTE;
			}
			set
			{
				if ((this._IDCLIENTE != value))
				{
					this._IDCLIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDOS", DbType="VarChar(30)")]
		public string APELLIDOS
		{
			get
			{
				return this._APELLIDOS;
			}
			set
			{
				if ((this._APELLIDOS != value))
				{
					this._APELLIDOS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="VarChar(30)")]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this._NOMBRE = value;
				}
			}
		}
	}
	
	public partial class buscarNombreResult
	{
		
		private string _IDCLIENTE;
		
		private string _APELLIDOS;
		
		private string _NOMBRE;
		
		public buscarNombreResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCLIENTE", DbType="VarChar(5) NOT NULL", CanBeNull=false)]
		public string IDCLIENTE
		{
			get
			{
				return this._IDCLIENTE;
			}
			set
			{
				if ((this._IDCLIENTE != value))
				{
					this._IDCLIENTE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDOS", DbType="VarChar(30)")]
		public string APELLIDOS
		{
			get
			{
				return this._APELLIDOS;
			}
			set
			{
				if ((this._APELLIDOS != value))
				{
					this._APELLIDOS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="VarChar(30)")]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this._NOMBRE = value;
				}
			}
		}
	}
}
#pragma warning restore 1591