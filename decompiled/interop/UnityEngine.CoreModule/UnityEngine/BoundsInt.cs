using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct BoundsInt
{
	public struct PositionEnumerator
	{
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Size;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public Vector3Int m_Position;

	[FieldOffset(12)]
	public Vector3Int m_Size;

	public unsafe Vector3Int position
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1154376, RefRangeEnd = 1154380, XrefRangeStart = 1154376, XrefRangeEnd = 1154380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1000096, RefRangeEnd = 1000102, XrefRangeStart = 1000096, XrefRangeEnd = 1000102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3Int size
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1157010, RefRangeEnd = 1157013, XrefRangeStart = 1157010, XrefRangeEnd = 1157013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public int x
	{
		get
		{
			return m_Position.x;
		}
		set
		{
			m_Position.x = value;
		}
	}

	public int y
	{
		get
		{
			return m_Position.y;
		}
		set
		{
			m_Position.y = value;
		}
	}

	public int z
	{
		get
		{
			return m_Position.z;
		}
		set
		{
			m_Position.z = value;
		}
	}

	public Vector3 center => new Vector3((float)x + (float)m_Size.x / 2f, (float)y + (float)m_Size.y / 2f, (float)z + (float)m_Size.z / 2f);

	public Vector3Int min
	{
		get
		{
			return new Vector3Int(xMin, yMin, zMin);
		}
		set
		{
			xMin = value.x;
			yMin = value.y;
			zMin = value.z;
		}
	}

	public Vector3Int max
	{
		get
		{
			return new Vector3Int(xMax, yMax, zMax);
		}
		set
		{
			xMax = value.x;
			yMax = value.y;
			zMax = value.z;
		}
	}

	public int xMin
	{
		get
		{
			return Il2CppSystem.Math.Min(m_Position.x, m_Position.x + m_Size.x);
		}
		set
		{
			int num = xMax;
			m_Position.x = value;
			m_Size.x = num - m_Position.x;
		}
	}

	public int yMin
	{
		get
		{
			return Il2CppSystem.Math.Min(m_Position.y, m_Position.y + m_Size.y);
		}
		set
		{
			int num = yMax;
			m_Position.y = value;
			m_Size.y = num - m_Position.y;
		}
	}

	public int zMin
	{
		get
		{
			return Il2CppSystem.Math.Min(m_Position.z, m_Position.z + m_Size.z);
		}
		set
		{
			int num = zMax;
			m_Position.z = value;
			m_Size.z = num - m_Position.z;
		}
	}

	public int xMax
	{
		get
		{
			return Il2CppSystem.Math.Max(m_Position.x, m_Position.x + m_Size.x);
		}
		set
		{
			m_Size.x = value - m_Position.x;
		}
	}

	public int yMax
	{
		get
		{
			return Il2CppSystem.Math.Max(m_Position.y, m_Position.y + m_Size.y);
		}
		set
		{
			m_Size.y = value - m_Position.y;
		}
	}

	public int zMax
	{
		get
		{
			return Il2CppSystem.Math.Max(m_Position.z, m_Position.z + m_Size.z);
		}
		set
		{
			m_Size.z = value - m_Position.z;
		}
	}

	public PositionEnumerator allPositionsWithin => new PositionEnumerator(min, max);

	static BoundsInt()
	{
		Il2CppClassPointerStore<BoundsInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BoundsInt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr);
		NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, "m_Position");
		NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, "m_Size");
		NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664147);
		NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664148);
		NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664149);
		NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664150);
		NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664151);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664152);
		NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664153);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664154);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664155);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664156);
	}

	[CallerCount(0)]
	public unsafe BoundsInt(Vector3Int position, Vector3Int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(Vector3Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171244, XrefRangeEnd = 1171245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171245, XrefRangeEnd = 1171267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171267, XrefRangeEnd = 1171270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(BoundsInt other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1171270, XrefRangeEnd = 1171272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void SetMinMax(Vector3Int minPosition, Vector3Int maxPosition)
	{
		min = minPosition;
		max = maxPosition;
	}

	public void ClampToBounds(BoundsInt bounds)
	{
		position = new Vector3Int(Il2CppSystem.Math.Max(Il2CppSystem.Math.Min(bounds.xMax, position.x), bounds.xMin), Il2CppSystem.Math.Max(Il2CppSystem.Math.Min(bounds.yMax, position.y), bounds.yMin), Il2CppSystem.Math.Max(Il2CppSystem.Math.Min(bounds.zMax, position.z), bounds.zMin));
		size = new Vector3Int(Il2CppSystem.Math.Min(bounds.xMax - position.x, size.x), Il2CppSystem.Math.Min(bounds.yMax - position.y, size.y), Il2CppSystem.Math.Min(bounds.zMax - position.z, size.z));
	}

	public bool Contains(Vector3Int position)
	{
		return position.x >= xMin && position.y >= yMin && position.z >= zMin && position.x < xMax && position.y < yMax && position.z < zMax;
	}

	public string ToString(string format)
	{
		return ToString(format, null);
	}

	public static bool operator ==(BoundsInt lhs, BoundsInt rhs)
	{
		return lhs.m_Position == rhs.m_Position && lhs.m_Size == rhs.m_Size;
	}

	public static bool operator !=(BoundsInt lhs, BoundsInt rhs)
	{
		return !(lhs == rhs);
	}
}
