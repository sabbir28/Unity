using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000051 RID: 81
	public sealed class MaterialPropertyBlock
	{
		// Token: 0x060005E6 RID: 1510 RVA: 0x00007A5C File Offset: 0x00005C5C
		public MaterialPropertyBlock()
		{
			this.InitBlock();
		}

		// Token: 0x060005E7 RID: 1511
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void InitBlock();

		// Token: 0x060005E8 RID: 1512
		[ThreadAndSerializationSafe]
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void DestroyBlock();

		// Token: 0x060005E9 RID: 1513 RVA: 0x00007A6C File Offset: 0x00005C6C
		~MaterialPropertyBlock()
		{
			this.DestroyBlock();
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060005EA RID: 1514
		public extern bool isEmpty { [GeneratedByOldBindingsGenerator] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060005EB RID: 1515
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Clear();

		// Token: 0x060005EC RID: 1516
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatImpl(int nameID, float value);

		// Token: 0x060005ED RID: 1517 RVA: 0x00007A9C File Offset: 0x00005C9C
		private void SetVectorImpl(int nameID, Vector4 value)
		{
			MaterialPropertyBlock.INTERNAL_CALL_SetVectorImpl(this, nameID, ref value);
		}

		// Token: 0x060005EE RID: 1518
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetVectorImpl(MaterialPropertyBlock self, int nameID, ref Vector4 value);

		// Token: 0x060005EF RID: 1519 RVA: 0x00007AA8 File Offset: 0x00005CA8
		private void SetMatrixImpl(int nameID, Matrix4x4 value)
		{
			MaterialPropertyBlock.INTERNAL_CALL_SetMatrixImpl(this, nameID, ref value);
		}

		// Token: 0x060005F0 RID: 1520
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetMatrixImpl(MaterialPropertyBlock self, int nameID, ref Matrix4x4 value);

		// Token: 0x060005F1 RID: 1521
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetTextureImpl(int nameID, Texture value);

		// Token: 0x060005F2 RID: 1522
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetBufferImpl(int nameID, ComputeBuffer value);

		// Token: 0x060005F3 RID: 1523 RVA: 0x00007AB4 File Offset: 0x00005CB4
		private void SetColorImpl(int nameID, Color value)
		{
			MaterialPropertyBlock.INTERNAL_CALL_SetColorImpl(this, nameID, ref value);
		}

		// Token: 0x060005F4 RID: 1524
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetColorImpl(MaterialPropertyBlock self, int nameID, ref Color value);

		// Token: 0x060005F5 RID: 1525
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Array ExtractArrayFromList(object list);

		// Token: 0x060005F6 RID: 1526
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetFloatArrayImpl(int nameID, float[] values);

		// Token: 0x060005F7 RID: 1527
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetVectorArrayImpl(int nameID, Vector4[] values);

		// Token: 0x060005F8 RID: 1528
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void SetMatrixArrayImpl(int nameID, Matrix4x4[] values);

		// Token: 0x060005F9 RID: 1529
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern float GetFloatImpl(int nameID);

		// Token: 0x060005FA RID: 1530 RVA: 0x00007AC0 File Offset: 0x00005CC0
		private Vector4 GetVectorImpl(int nameID)
		{
			Vector4 result;
			MaterialPropertyBlock.INTERNAL_CALL_GetVectorImpl(this, nameID, out result);
			return result;
		}

		// Token: 0x060005FB RID: 1531
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetVectorImpl(MaterialPropertyBlock self, int nameID, out Vector4 value);

		// Token: 0x060005FC RID: 1532 RVA: 0x00007AE0 File Offset: 0x00005CE0
		private Matrix4x4 GetMatrixImpl(int nameID)
		{
			Matrix4x4 result;
			MaterialPropertyBlock.INTERNAL_CALL_GetMatrixImpl(this, nameID, out result);
			return result;
		}

		// Token: 0x060005FD RID: 1533
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_GetMatrixImpl(MaterialPropertyBlock self, int nameID, out Matrix4x4 value);

		// Token: 0x060005FE RID: 1534
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern float[] GetFloatArrayImpl(int nameID);

		// Token: 0x060005FF RID: 1535
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Vector4[] GetVectorArrayImpl(int nameID);

		// Token: 0x06000600 RID: 1536
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Matrix4x4[] GetMatrixArrayImpl(int nameID);

		// Token: 0x06000601 RID: 1537
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetFloatArrayImplList(int nameID, object list);

		// Token: 0x06000602 RID: 1538
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetVectorArrayImplList(int nameID, object list);

		// Token: 0x06000603 RID: 1539
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetMatrixArrayImplList(int nameID, object list);

		// Token: 0x06000604 RID: 1540
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern Texture GetTextureImpl(int nameID);

		// Token: 0x06000605 RID: 1541 RVA: 0x00007B00 File Offset: 0x00005D00
		public void SetFloat(string name, float value)
		{
			this.SetFloat(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00007B10 File Offset: 0x00005D10
		public void SetFloat(int nameID, float value)
		{
			this.SetFloatImpl(nameID, value);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00007B1C File Offset: 0x00005D1C
		public void SetVector(string name, Vector4 value)
		{
			this.SetVector(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00007B2C File Offset: 0x00005D2C
		public void SetVector(int nameID, Vector4 value)
		{
			this.SetVectorImpl(nameID, value);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00007B38 File Offset: 0x00005D38
		public void SetColor(string name, Color value)
		{
			this.SetColor(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00007B48 File Offset: 0x00005D48
		public void SetColor(int nameID, Color value)
		{
			this.SetColorImpl(nameID, value);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00007B54 File Offset: 0x00005D54
		public void SetMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrix(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00007B64 File Offset: 0x00005D64
		public void SetMatrix(int nameID, Matrix4x4 value)
		{
			this.SetMatrixImpl(nameID, value);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00007B70 File Offset: 0x00005D70
		public void SetBuffer(string name, ComputeBuffer value)
		{
			this.SetBuffer(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00007B80 File Offset: 0x00005D80
		public void SetBuffer(int nameID, ComputeBuffer value)
		{
			this.SetBufferImpl(nameID, value);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00007B8C File Offset: 0x00005D8C
		public void SetTexture(string name, Texture value)
		{
			this.SetTexture(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00007B9C File Offset: 0x00005D9C
		public void SetTexture(int nameID, Texture value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.SetTextureImpl(nameID, value);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00007BC0 File Offset: 0x00005DC0
		public void SetFloatArray(string name, List<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00007BD0 File Offset: 0x00005DD0
		public void SetFloatArray(int nameID, List<float> values)
		{
			this.SetFloatArray(nameID, (float[])MaterialPropertyBlock.ExtractArrayFromList(values));
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00007BE8 File Offset: 0x00005DE8
		public void SetFloatArray(string name, float[] values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00007BF8 File Offset: 0x00005DF8
		public void SetFloatArray(int nameID, float[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetFloatArrayImpl(nameID, values);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00007C28 File Offset: 0x00005E28
		public void SetVectorArray(string name, List<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00007C38 File Offset: 0x00005E38
		public void SetVectorArray(int nameID, List<Vector4> values)
		{
			this.SetVectorArray(nameID, (Vector4[])MaterialPropertyBlock.ExtractArrayFromList(values));
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00007C50 File Offset: 0x00005E50
		public void SetVectorArray(string name, Vector4[] values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00007C60 File Offset: 0x00005E60
		public void SetVectorArray(int nameID, Vector4[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetVectorArrayImpl(nameID, values);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00007C90 File Offset: 0x00005E90
		public void SetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00007CA0 File Offset: 0x00005EA0
		public void SetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			this.SetMatrixArray(nameID, (Matrix4x4[])MaterialPropertyBlock.ExtractArrayFromList(values));
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00007CB8 File Offset: 0x00005EB8
		public void SetMatrixArray(string name, Matrix4x4[] values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00007CC8 File Offset: 0x00005EC8
		public void SetMatrixArray(int nameID, Matrix4x4[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				throw new ArgumentException("Zero-sized array is not allowed.");
			}
			this.SetMatrixArrayImpl(nameID, values);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00007CF8 File Offset: 0x00005EF8
		public float GetFloat(string name)
		{
			return this.GetFloat(Shader.PropertyToID(name));
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00007D1C File Offset: 0x00005F1C
		public float GetFloat(int nameID)
		{
			return this.GetFloatImpl(nameID);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00007D38 File Offset: 0x00005F38
		public Vector4 GetVector(string name)
		{
			return this.GetVector(Shader.PropertyToID(name));
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00007D5C File Offset: 0x00005F5C
		public Vector4 GetVector(int nameID)
		{
			return this.GetVectorImpl(nameID);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00007D78 File Offset: 0x00005F78
		public Matrix4x4 GetMatrix(string name)
		{
			return this.GetMatrix(Shader.PropertyToID(name));
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00007D9C File Offset: 0x00005F9C
		public Matrix4x4 GetMatrix(int nameID)
		{
			return this.GetMatrixImpl(nameID);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00007DB8 File Offset: 0x00005FB8
		public void GetFloatArray(string name, List<float> values)
		{
			this.GetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00007DC8 File Offset: 0x00005FC8
		public void GetFloatArray(int nameID, List<float> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			this.GetFloatArrayImplList(nameID, values);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00007DE4 File Offset: 0x00005FE4
		public float[] GetFloatArray(string name)
		{
			return this.GetFloatArray(Shader.PropertyToID(name));
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00007E08 File Offset: 0x00006008
		public float[] GetFloatArray(int nameID)
		{
			return this.GetFloatArrayImpl(nameID);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00007E24 File Offset: 0x00006024
		public void GetVectorArray(string name, List<Vector4> values)
		{
			this.GetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00007E34 File Offset: 0x00006034
		public void GetVectorArray(int nameID, List<Vector4> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			this.GetVectorArrayImplList(nameID, values);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00007E50 File Offset: 0x00006050
		public Vector4[] GetVectorArray(string name)
		{
			return this.GetVectorArray(Shader.PropertyToID(name));
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00007E74 File Offset: 0x00006074
		public Vector4[] GetVectorArray(int nameID)
		{
			return this.GetVectorArrayImpl(nameID);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00007E90 File Offset: 0x00006090
		public void GetMatrixArray(string name, List<Matrix4x4> values)
		{
			this.GetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00007EA0 File Offset: 0x000060A0
		public void GetMatrixArray(int nameID, List<Matrix4x4> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			this.GetMatrixArrayImplList(nameID, values);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00007EBC File Offset: 0x000060BC
		public Matrix4x4[] GetMatrixArray(string name)
		{
			return this.GetMatrixArray(Shader.PropertyToID(name));
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00007EE0 File Offset: 0x000060E0
		public Matrix4x4[] GetMatrixArray(int nameID)
		{
			return this.GetMatrixArrayImpl(nameID);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00007EFC File Offset: 0x000060FC
		public Texture GetTexture(string name)
		{
			return this.GetTexture(Shader.PropertyToID(name));
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00007F20 File Offset: 0x00006120
		public Texture GetTexture(int nameID)
		{
			return this.GetTextureImpl(nameID);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00007F3C File Offset: 0x0000613C
		[Obsolete("Use SetFloat instead (UnityUpgradable) -> SetFloat(*)", false)]
		public void AddFloat(string name, float value)
		{
			this.SetFloat(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00007F4C File Offset: 0x0000614C
		[Obsolete("Use SetFloat instead (UnityUpgradable) -> SetFloat(*)", false)]
		public void AddFloat(int nameID, float value)
		{
			this.SetFloat(nameID, value);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00007F58 File Offset: 0x00006158
		[Obsolete("Use SetVector instead (UnityUpgradable) -> SetVector(*)", false)]
		public void AddVector(string name, Vector4 value)
		{
			this.SetVector(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00007F68 File Offset: 0x00006168
		[Obsolete("Use SetVector instead (UnityUpgradable) -> SetVector(*)", false)]
		public void AddVector(int nameID, Vector4 value)
		{
			this.SetVector(nameID, value);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00007F74 File Offset: 0x00006174
		[Obsolete("Use SetColor instead (UnityUpgradable) -> SetColor(*)", false)]
		public void AddColor(string name, Color value)
		{
			this.SetColor(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00007F84 File Offset: 0x00006184
		[Obsolete("Use SetColor instead (UnityUpgradable) -> SetColor(*)", false)]
		public void AddColor(int nameID, Color value)
		{
			this.SetColor(nameID, value);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00007F90 File Offset: 0x00006190
		[Obsolete("Use SetMatrix instead (UnityUpgradable) -> SetMatrix(*)", false)]
		public void AddMatrix(string name, Matrix4x4 value)
		{
			this.SetMatrix(Shader.PropertyToID(name), value);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00007FA0 File Offset: 0x000061A0
		[Obsolete("Use SetMatrix instead (UnityUpgradable) -> SetMatrix(*)", false)]
		public void AddMatrix(int nameID, Matrix4x4 value)
		{
			this.SetMatrix(nameID, value);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00007FAC File Offset: 0x000061AC
		[Obsolete("Use SetTexture instead (UnityUpgradable) -> SetTexture(*)", false)]
		public void AddTexture(string name, Texture value)
		{
			this.SetTexture(Shader.PropertyToID(name), value);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00007FBC File Offset: 0x000061BC
		[Obsolete("Use SetTexture instead (UnityUpgradable) -> SetTexture(*)", false)]
		public void AddTexture(int nameID, Texture value)
		{
			this.SetTexture(nameID, value);
		}

		// Token: 0x0400006B RID: 107
		internal IntPtr m_Ptr;
	}
}
