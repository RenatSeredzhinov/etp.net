// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelDataLoad
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class InfillRealtimeData : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"InfillRealtimeData\",\"namespace\":\"Energistics.Etp.v12.Pro" +
				"tocol.ChannelDataLoad\",\"fields\":[{\"name\":\"data\",\"type\":{\"type\":\"array\",\"items\":{" +
				"\"type\":\"record\",\"name\":\"DataPoint\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Ch" +
				"annelData\",\"fields\":[{\"name\":\"channelId\",\"type\":\"long\"},{\"name\":\"indexes\",\"type\"" +
				":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"IndexValue\",\"namespace\":\"Energ" +
				"istics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"double\",\"long" +
				"\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"depends\":[]}}},{\"nam" +
				"e\":\"value\",\"type\":{\"type\":\"record\",\"name\":\"DataValue\",\"namespace\":\"Energistics.E" +
				"tp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"double\",\"float\",\"int\"" +
				",\"long\",\"string\",{\"type\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"Energistic" +
				"s.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"" +
				"double\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"depends\":[]" +
				"},\"boolean\",\"bytes\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.DataValue\",\"dep" +
				"ends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\"\r\n]}},{\"name\":\"valueAttr" +
				"ibutes\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"DataAttribute\",\"" +
				"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"attributeId\",\"type" +
				"\":\"int\"},{\"name\":\"attributeValue\",\"type\":\"DataValue\"}],\"fullName\":\"Energistics.E" +
				"tp.v12.Datatypes.DataAttribute\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Da" +
				"taValue\"\r\n]}}}]}}}],\"messageType\":\"5\",\"protocol\":\"23\",\"senderRole\":\"producer\",\"p" +
				"rotocolRoles\":\"producer,consumer\"}");
		private IList<Energistics.Etp.v12.Datatypes.ChannelData.DataPoint> _data;
		public virtual Schema Schema
		{
			get
			{
				return InfillRealtimeData._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ChannelData.DataPoint> Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._data;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._data = (IList<Energistics.Etp.v12.Datatypes.ChannelData.DataPoint>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
