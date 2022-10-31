using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	// Token: 0x020002BD RID: 701
	[StructLayout(LayoutKind.Sequential)]
	internal class CustomEventData : IDisposable
	{
		// Token: 0x06002DA7 RID: 11687 RVA: 0x00041DA8 File Offset: 0x0003FFA8
		private CustomEventData()
		{
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00041DB4 File Offset: 0x0003FFB4
		public CustomEventData(string name)
		{
			this.InternalCreate(name);
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00041DC4 File Offset: 0x0003FFC4
		~CustomEventData()
		{
			this.InternalDestroy();
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00041DF4 File Offset: 0x0003FFF4
		public void Dispose()
		{
			this.InternalDestroy();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00041E04 File Offset: 0x00040004
		public bool Add(string key, string value)
		{
			return this.AddString(key, value);
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x00041E24 File Offset: 0x00040024
		public bool Add(string key, bool value)
		{
			return this.AddBool(key, value);
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00041E44 File Offset: 0x00040044
		public bool Add(string key, char value)
		{
			return this.AddChar(key, value);
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x00041E64 File Offset: 0x00040064
		public bool Add(string key, byte value)
		{
			return this.AddByte(key, value);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00041E84 File Offset: 0x00040084
		public bool Add(string key, sbyte value)
		{
			return this.AddSByte(key, value);
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00041EA4 File Offset: 0x000400A4
		public bool Add(string key, short value)
		{
			return this.AddInt16(key, value);
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00041EC4 File Offset: 0x000400C4
		public bool Add(string key, ushort value)
		{
			return this.AddUInt16(key, value);
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00041EE4 File Offset: 0x000400E4
		public bool Add(string key, int value)
		{
			return this.AddInt32(key, value);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00041F04 File Offset: 0x00040104
		public bool Add(string key, uint value)
		{
			return this.AddUInt32(key, value);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x00041F24 File Offset: 0x00040124
		public bool Add(string key, long value)
		{
			return this.AddInt64(key, value);
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x00041F44 File Offset: 0x00040144
		public bool Add(string key, ulong value)
		{
			return this.AddUInt64(key, value);
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x00041F64 File Offset: 0x00040164
		public bool Add(string key, float value)
		{
			return this.AddDouble(key, (double)Convert.ToDecimal(value));
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00041F8C File Offset: 0x0004018C
		public bool Add(string key, double value)
		{
			return this.AddDouble(key, value);
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00041FAC File Offset: 0x000401AC
		public bool Add(string key, decimal value)
		{
			return this.AddDouble(key, (double)Convert.ToDecimal(value));
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x00041FD4 File Offset: 0x000401D4
		public bool Add(IDictionary<string, object> eventData)
		{
			foreach (KeyValuePair<string, object> keyValuePair in eventData)
			{
				string key = keyValuePair.Key;
				object value = keyValuePair.Value;
				if (value == null)
				{
					this.Add(key, "null");
				}
				else
				{
					Type type = value.GetType();
					if (type == typeof(string))
					{
						this.Add(key, (string)value);
					}
					else if (type == typeof(char))
					{
						this.Add(key, (char)value);
					}
					else if (type == typeof(sbyte))
					{
						this.Add(key, (sbyte)value);
					}
					else if (type == typeof(byte))
					{
						this.Add(key, (byte)value);
					}
					else if (type == typeof(short))
					{
						this.Add(key, (short)value);
					}
					else if (type == typeof(ushort))
					{
						this.Add(key, (ushort)value);
					}
					else if (type == typeof(int))
					{
						this.Add(key, (int)value);
					}
					else if (type == typeof(uint))
					{
						this.Add(keyValuePair.Key, (uint)value);
					}
					else if (type == typeof(long))
					{
						this.Add(key, (long)value);
					}
					else if (type == typeof(ulong))
					{
						this.Add(key, (ulong)value);
					}
					else if (type == typeof(bool))
					{
						this.Add(key, (bool)value);
					}
					else if (type == typeof(float))
					{
						this.Add(key, (float)value);
					}
					else if (type == typeof(double))
					{
						this.Add(key, (double)value);
					}
					else if (type == typeof(decimal))
					{
						this.Add(key, (decimal)value);
					}
					else
					{
						if (!type.IsValueType)
						{
							throw new ArgumentException(string.Format("Invalid type: {0} passed", type));
						}
						this.Add(key, value.ToString());
					}
				}
			}
			return true;
		}

		// Token: 0x06002DBA RID: 11706
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void InternalCreate(string name);

		// Token: 0x06002DBB RID: 11707
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InternalDestroy();

		// Token: 0x06002DBC RID: 11708
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddString(string key, string value);

		// Token: 0x06002DBD RID: 11709
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddBool(string key, bool value);

		// Token: 0x06002DBE RID: 11710
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddChar(string key, char value);

		// Token: 0x06002DBF RID: 11711
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddByte(string key, byte value);

		// Token: 0x06002DC0 RID: 11712
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddSByte(string key, sbyte value);

		// Token: 0x06002DC1 RID: 11713
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddInt16(string key, short value);

		// Token: 0x06002DC2 RID: 11714
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddUInt16(string key, ushort value);

		// Token: 0x06002DC3 RID: 11715
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddInt32(string key, int value);

		// Token: 0x06002DC4 RID: 11716
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddUInt32(string key, uint value);

		// Token: 0x06002DC5 RID: 11717
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddInt64(string key, long value);

		// Token: 0x06002DC6 RID: 11718
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddUInt64(string key, ulong value);

		// Token: 0x06002DC7 RID: 11719
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool AddDouble(string key, double value);

		// Token: 0x04000931 RID: 2353
		[NonSerialized]
		internal IntPtr m_Ptr;
	}
}
