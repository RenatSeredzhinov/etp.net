// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Datatypes
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ArrayOfBoolean : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"ArrayOfBoolean\",\"namespace\":\"Energistics.Datatypes\",\"fie" +
				"lds\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}],\"fullName\":\"E" +
				"nergistics.Datatypes.ArrayOfBoolean\",\"depends\":[]}");
		private IList<System.Boolean> _values;
		public virtual Schema Schema
		{
			get
			{
				return ArrayOfBoolean._SCHEMA;
			}
		}
		public IList<System.Boolean> Values
		{
			get
			{
				return this._values;
			}
			set
			{
				this._values = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._values;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._values = (IList<System.Boolean>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}