using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RasterState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_defaultValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OffsetUnits;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OffsetFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Conservative;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding1;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding2;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public CullMode m_CullingMode;

	[FieldOffset(4)]
	public int m_OffsetUnits;

	[FieldOffset(8)]
	public float m_OffsetFactor;

	[FieldOffset(12)]
	public byte m_DepthClip;

	[FieldOffset(13)]
	public byte m_Conservative;

	[FieldOffset(14)]
	public byte m_Padding1;

	[FieldOffset(15)]
	public byte m_Padding2;

	public unsafe static RasterState defaultValue
	{
		get
		{
			Unsafe.SkipInit(out RasterState result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultValue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultValue, (void*)(&value));
		}
	}

	public CullMode cullingMode
	{
		get
		{
			return m_CullingMode;
		}
		set
		{
			m_CullingMode = value;
		}
	}

	public bool depthClip
	{
		get
		{
			return Il2CppSystem.Convert.ToBoolean(m_DepthClip);
		}
		set
		{
			m_DepthClip = Il2CppSystem.Convert.ToByte(value);
		}
	}

	public bool conservative
	{
		get
		{
			return Il2CppSystem.Convert.ToBoolean(m_Conservative);
		}
		set
		{
			m_Conservative = Il2CppSystem.Convert.ToByte(value);
		}
	}

	public int offsetUnits
	{
		get
		{
			return m_OffsetUnits;
		}
		set
		{
			m_OffsetUnits = value;
		}
	}

	public float offsetFactor
	{
		get
		{
			return m_OffsetFactor;
		}
		set
		{
			m_OffsetFactor = value;
		}
	}

	static RasterState()
	{
		Il2CppClassPointerStore<RasterState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RasterState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RasterState>.NativeClassPtr);
		NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "defaultValue");
		NativeFieldInfoPtr_m_CullingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_CullingMode");
		NativeFieldInfoPtr_m_OffsetUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_OffsetUnits");
		NativeFieldInfoPtr_m_OffsetFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_OffsetFactor");
		NativeFieldInfoPtr_m_DepthClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_DepthClip");
		NativeFieldInfoPtr_m_Conservative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_Conservative");
		NativeFieldInfoPtr_m_Padding1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_Padding1");
		NativeFieldInfoPtr_m_Padding2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_Padding2");
		NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100668526);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100668527);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100668528);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100668529);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238360, RefRangeEnd = 1238361, XrefRangeStart = 1238355, XrefRangeEnd = 1238360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RasterState(CullMode cullingMode = CullMode.Back, int offsetUnits = 0, float offsetFactor = 0f, bool depthClip = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&cullingMode);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetUnits;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetFactor;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthClip;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238361, XrefRangeEnd = 1238362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(RasterState other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238362, XrefRangeEnd = 1238368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238368, XrefRangeEnd = 1238371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RasterState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(RasterState left, RasterState right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(RasterState left, RasterState right)
	{
		return !left.Equals(right);
	}
}
