using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020003CA RID: 970
	[UsedByNativeCode]
	public struct Rect
	{
		// Token: 0x0600328D RID: 12941 RVA: 0x0004DC74 File Offset: 0x0004BE74
		public Rect(float x, float y, float width, float height)
		{
			this.m_XMin = x;
			this.m_YMin = y;
			this.m_Width = width;
			this.m_Height = height;
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x0004DC94 File Offset: 0x0004BE94
		public Rect(Vector2 position, Vector2 size)
		{
			this.m_XMin = position.x;
			this.m_YMin = position.y;
			this.m_Width = size.x;
			this.m_Height = size.y;
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x0004DCCC File Offset: 0x0004BECC
		public Rect(Rect source)
		{
			this.m_XMin = source.m_XMin;
			this.m_YMin = source.m_YMin;
			this.m_Width = source.m_Width;
			this.m_Height = source.m_Height;
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x0004DD04 File Offset: 0x0004BF04
		public static Rect zero
		{
			get
			{
				return new Rect(0f, 0f, 0f, 0f);
			}
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x0004DD34 File Offset: 0x0004BF34
		public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
		{
			return new Rect(xmin, ymin, xmax - xmin, ymax - ymin);
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x0004DD58 File Offset: 0x0004BF58
		public void Set(float x, float y, float width, float height)
		{
			this.m_XMin = x;
			this.m_YMin = y;
			this.m_Width = width;
			this.m_Height = height;
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06003293 RID: 12947 RVA: 0x0004DD78 File Offset: 0x0004BF78
		// (set) Token: 0x06003294 RID: 12948 RVA: 0x0004DD94 File Offset: 0x0004BF94
		public float x
		{
			get
			{
				return this.m_XMin;
			}
			set
			{
				this.m_XMin = value;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x0004DDA0 File Offset: 0x0004BFA0
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x0004DDBC File Offset: 0x0004BFBC
		public float y
		{
			get
			{
				return this.m_YMin;
			}
			set
			{
				this.m_YMin = value;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06003297 RID: 12951 RVA: 0x0004DDC8 File Offset: 0x0004BFC8
		// (set) Token: 0x06003298 RID: 12952 RVA: 0x0004DDF0 File Offset: 0x0004BFF0
		public Vector2 position
		{
			get
			{
				return new Vector2(this.m_XMin, this.m_YMin);
			}
			set
			{
				this.m_XMin = value.x;
				this.m_YMin = value.y;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06003299 RID: 12953 RVA: 0x0004DE10 File Offset: 0x0004C010
		// (set) Token: 0x0600329A RID: 12954 RVA: 0x0004DE50 File Offset: 0x0004C050
		public Vector2 center
		{
			get
			{
				return new Vector2(this.x + this.m_Width / 2f, this.y + this.m_Height / 2f);
			}
			set
			{
				this.m_XMin = value.x - this.m_Width / 2f;
				this.m_YMin = value.y - this.m_Height / 2f;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x0600329B RID: 12955 RVA: 0x0004DE88 File Offset: 0x0004C088
		// (set) Token: 0x0600329C RID: 12956 RVA: 0x0004DEB0 File Offset: 0x0004C0B0
		public Vector2 min
		{
			get
			{
				return new Vector2(this.xMin, this.yMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x0004DED0 File Offset: 0x0004C0D0
		// (set) Token: 0x0600329E RID: 12958 RVA: 0x0004DEF8 File Offset: 0x0004C0F8
		public Vector2 max
		{
			get
			{
				return new Vector2(this.xMax, this.yMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x0600329F RID: 12959 RVA: 0x0004DF18 File Offset: 0x0004C118
		// (set) Token: 0x060032A0 RID: 12960 RVA: 0x0004DF34 File Offset: 0x0004C134
		public float width
		{
			get
			{
				return this.m_Width;
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060032A1 RID: 12961 RVA: 0x0004DF40 File Offset: 0x0004C140
		// (set) Token: 0x060032A2 RID: 12962 RVA: 0x0004DF5C File Offset: 0x0004C15C
		public float height
		{
			get
			{
				return this.m_Height;
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060032A3 RID: 12963 RVA: 0x0004DF68 File Offset: 0x0004C168
		// (set) Token: 0x060032A4 RID: 12964 RVA: 0x0004DF90 File Offset: 0x0004C190
		public Vector2 size
		{
			get
			{
				return new Vector2(this.m_Width, this.m_Height);
			}
			set
			{
				this.m_Width = value.x;
				this.m_Height = value.y;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060032A5 RID: 12965 RVA: 0x0004DFB0 File Offset: 0x0004C1B0
		// (set) Token: 0x060032A6 RID: 12966 RVA: 0x0004DFCC File Offset: 0x0004C1CC
		public float xMin
		{
			get
			{
				return this.m_XMin;
			}
			set
			{
				float xMax = this.xMax;
				this.m_XMin = value;
				this.m_Width = xMax - this.m_XMin;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060032A7 RID: 12967 RVA: 0x0004DFF8 File Offset: 0x0004C1F8
		// (set) Token: 0x060032A8 RID: 12968 RVA: 0x0004E014 File Offset: 0x0004C214
		public float yMin
		{
			get
			{
				return this.m_YMin;
			}
			set
			{
				float yMax = this.yMax;
				this.m_YMin = value;
				this.m_Height = yMax - this.m_YMin;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060032A9 RID: 12969 RVA: 0x0004E040 File Offset: 0x0004C240
		// (set) Token: 0x060032AA RID: 12970 RVA: 0x0004E064 File Offset: 0x0004C264
		public float xMax
		{
			get
			{
				return this.m_Width + this.m_XMin;
			}
			set
			{
				this.m_Width = value - this.m_XMin;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x0004E078 File Offset: 0x0004C278
		// (set) Token: 0x060032AC RID: 12972 RVA: 0x0004E09C File Offset: 0x0004C29C
		public float yMax
		{
			get
			{
				return this.m_Height + this.m_YMin;
			}
			set
			{
				this.m_Height = value - this.m_YMin;
			}
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x0004E0B0 File Offset: 0x0004C2B0
		public bool Contains(Vector2 point)
		{
			return point.x >= this.xMin && point.x < this.xMax && point.y >= this.yMin && point.y < this.yMax;
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x0004E110 File Offset: 0x0004C310
		public bool Contains(Vector3 point)
		{
			return point.x >= this.xMin && point.x < this.xMax && point.y >= this.yMin && point.y < this.yMax;
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x0004E170 File Offset: 0x0004C370
		public bool Contains(Vector3 point, bool allowInverse)
		{
			bool result;
			if (!allowInverse)
			{
				result = this.Contains(point);
			}
			else
			{
				bool flag = false;
				if ((this.width < 0f && point.x <= this.xMin && point.x > this.xMax) || (this.width >= 0f && point.x >= this.xMin && point.x < this.xMax))
				{
					flag = true;
				}
				result = (flag && ((this.height < 0f && point.y <= this.yMin && point.y > this.yMax) || (this.height >= 0f && point.y >= this.yMin && point.y < this.yMax)));
			}
			return result;
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x0004E27C File Offset: 0x0004C47C
		private static Rect OrderMinMax(Rect rect)
		{
			if (rect.xMin > rect.xMax)
			{
				float xMin = rect.xMin;
				rect.xMin = rect.xMax;
				rect.xMax = xMin;
			}
			if (rect.yMin > rect.yMax)
			{
				float yMin = rect.yMin;
				rect.yMin = rect.yMax;
				rect.yMax = yMin;
			}
			return rect;
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x0004E2F8 File Offset: 0x0004C4F8
		public bool Overlaps(Rect other)
		{
			return other.xMax > this.xMin && other.xMin < this.xMax && other.yMax > this.yMin && other.yMin < this.yMax;
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x0004E358 File Offset: 0x0004C558
		public bool Overlaps(Rect other, bool allowInverse)
		{
			Rect rect = this;
			if (allowInverse)
			{
				rect = Rect.OrderMinMax(rect);
				other = Rect.OrderMinMax(other);
			}
			return rect.Overlaps(other);
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x0004E394 File Offset: 0x0004C594
		public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates)
		{
			return new Vector2(Mathf.Lerp(rectangle.x, rectangle.xMax, normalizedRectCoordinates.x), Mathf.Lerp(rectangle.y, rectangle.yMax, normalizedRectCoordinates.y));
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x0004E3E4 File Offset: 0x0004C5E4
		public static Vector2 PointToNormalized(Rect rectangle, Vector2 point)
		{
			return new Vector2(Mathf.InverseLerp(rectangle.x, rectangle.xMax, point.x), Mathf.InverseLerp(rectangle.y, rectangle.yMax, point.y));
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x0004E434 File Offset: 0x0004C634
		public static bool operator !=(Rect lhs, Rect rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x0004E454 File Offset: 0x0004C654
		public static bool operator ==(Rect lhs, Rect rhs)
		{
			return lhs.x == rhs.x && lhs.y == rhs.y && lhs.width == rhs.width && lhs.height == rhs.height;
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x0004E4B8 File Offset: 0x0004C6B8
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ this.width.GetHashCode() << 2 ^ this.y.GetHashCode() >> 2 ^ this.height.GetHashCode() >> 1;
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x0004E528 File Offset: 0x0004C728
		public override bool Equals(object other)
		{
			bool result;
			if (!(other is Rect))
			{
				result = false;
			}
			else
			{
				Rect rect = (Rect)other;
				result = (this.x.Equals(rect.x) && this.y.Equals(rect.y) && this.width.Equals(rect.width) && this.height.Equals(rect.height));
			}
			return result;
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x0004E5C0 File Offset: 0x0004C7C0
		public override string ToString()
		{
			return UnityString.Format("(x:{0:F2}, y:{1:F2}, width:{2:F2}, height:{3:F2})", new object[]
			{
				this.x,
				this.y,
				this.width,
				this.height
			});
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x0004E620 File Offset: 0x0004C820
		public string ToString(string format)
		{
			return UnityString.Format("(x:{0}, y:{1}, width:{2}, height:{3})", new object[]
			{
				this.x.ToString(format),
				this.y.ToString(format),
				this.width.ToString(format),
				this.height.ToString(format)
			});
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060032BB RID: 12987 RVA: 0x0004E690 File Offset: 0x0004C890
		[Obsolete("use xMin")]
		public float left
		{
			get
			{
				return this.m_XMin;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x0004E6AC File Offset: 0x0004C8AC
		[Obsolete("use xMax")]
		public float right
		{
			get
			{
				return this.m_XMin + this.m_Width;
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060032BD RID: 12989 RVA: 0x0004E6D0 File Offset: 0x0004C8D0
		[Obsolete("use yMin")]
		public float top
		{
			get
			{
				return this.m_YMin;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x0004E6EC File Offset: 0x0004C8EC
		[Obsolete("use yMax")]
		public float bottom
		{
			get
			{
				return this.m_YMin + this.m_Height;
			}
		}

		// Token: 0x04000E98 RID: 3736
		private float m_XMin;

		// Token: 0x04000E99 RID: 3737
		private float m_YMin;

		// Token: 0x04000E9A RID: 3738
		private float m_Width;

		// Token: 0x04000E9B RID: 3739
		private float m_Height;
	}
}
