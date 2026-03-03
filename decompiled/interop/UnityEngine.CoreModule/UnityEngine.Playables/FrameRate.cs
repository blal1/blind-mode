using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct FrameRate
{
	private static readonly System.IntPtr NativeFieldInfoPtr_k_24Fps;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_23_976Fps;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_25Fps;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_30Fps;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_29_97Fps;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_50Fps;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_60Fps;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_59_94Fps;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Rate;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dropFrame_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rate_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameRate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FrameRate_FrameRate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoubleToFrameRate_Internal_Static_FrameRate_Double_0;

	[FieldOffset(0)]
	public int m_Rate;

	public unsafe static FrameRate k_24Fps
	{
		get
		{
			Unsafe.SkipInit(out FrameRate result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_24Fps, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_24Fps, (void*)(&value));
		}
	}

	public unsafe static FrameRate k_23_976Fps
	{
		get
		{
			Unsafe.SkipInit(out FrameRate result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_23_976Fps, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_23_976Fps, (void*)(&value));
		}
	}

	public unsafe static FrameRate k_25Fps
	{
		get
		{
			Unsafe.SkipInit(out FrameRate result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_25Fps, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_25Fps, (void*)(&value));
		}
	}

	public unsafe static FrameRate k_30Fps
	{
		get
		{
			Unsafe.SkipInit(out FrameRate result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_30Fps, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_30Fps, (void*)(&value));
		}
	}

	public unsafe static FrameRate k_29_97Fps
	{
		get
		{
			Unsafe.SkipInit(out FrameRate result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_29_97Fps, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_29_97Fps, (void*)(&value));
		}
	}

	public unsafe static FrameRate k_50Fps
	{
		get
		{
			Unsafe.SkipInit(out FrameRate result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_50Fps, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_50Fps, (void*)(&value));
		}
	}

	public unsafe static FrameRate k_60Fps
	{
		get
		{
			Unsafe.SkipInit(out FrameRate result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_60Fps, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_60Fps, (void*)(&value));
		}
	}

	public unsafe static FrameRate k_59_94Fps
	{
		get
		{
			Unsafe.SkipInit(out FrameRate result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_59_94Fps, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_59_94Fps, (void*)(&value));
		}
	}

	public unsafe bool dropFrame
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765814, RefRangeEnd = 765815, XrefRangeStart = 765814, XrefRangeEnd = 765815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dropFrame_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double rate
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229536, RefRangeEnd = 1229538, XrefRangeStart = 1229533, XrefRangeEnd = 1229536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rate_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static FrameRate()
	{
		Il2CppClassPointerStore<FrameRate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "FrameRate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameRate>.NativeClassPtr);
		NativeFieldInfoPtr_k_24Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_24Fps");
		NativeFieldInfoPtr_k_23_976Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_23_976Fps");
		NativeFieldInfoPtr_k_25Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_25Fps");
		NativeFieldInfoPtr_k_30Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_30Fps");
		NativeFieldInfoPtr_k_29_97Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_29_97Fps");
		NativeFieldInfoPtr_k_50Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_50Fps");
		NativeFieldInfoPtr_k_60Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_60Fps");
		NativeFieldInfoPtr_k_59_94Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "k_59_94Fps");
		NativeFieldInfoPtr_m_Rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, "m_Rate");
		NativeMethodInfoPtr_get_dropFrame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667377);
		NativeMethodInfoPtr_get_rate_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667378);
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667379);
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667380);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667381);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667382);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FrameRate_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667383);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667384);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667385);
		NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667386);
		NativeMethodInfoPtr_DoubleToFrameRate_Internal_Static_FrameRate_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100667387);
	}

	[CallerCount(0)]
	public unsafe FrameRate(uint frameRate = 0u, bool drop = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&frameRate);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &drop;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1159749, RefRangeEnd = 1159750, XrefRangeStart = 1159749, XrefRangeEnd = 1159750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1177403, RefRangeEnd = 1177406, XrefRangeStart = 1177403, XrefRangeEnd = 1177406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(FrameRate other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameRate_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229538, XrefRangeEnd = 1229543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1229546, RefRangeEnd = 1229554, XrefRangeStart = 1229543, XrefRangeEnd = 1229546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(FrameRate a, FrameRate b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(FrameRate**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FrameRate_FrameRate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(256)]
	[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229554, XrefRangeEnd = 1229567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1229594, RefRangeEnd = 1229595, XrefRangeStart = 1229567, XrefRangeEnd = 1229594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1229609, RefRangeEnd = 1229610, XrefRangeStart = 1229595, XrefRangeEnd = 1229609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FrameRate DoubleToFrameRate(double framerate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&framerate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoubleToFrameRate_Internal_Static_FrameRate_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FrameRate*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator !=(FrameRate a, FrameRate b)
	{
		return !a.Equals(b);
	}

	public static bool operator <(FrameRate a, FrameRate b)
	{
		return a.rate < b.rate;
	}

	public static bool operator <=(FrameRate a, FrameRate b)
	{
		return a.rate <= b.rate;
	}

	public static bool operator >(FrameRate a, FrameRate b)
	{
		return a.rate > b.rate;
	}

	public static bool operator >=(FrameRate a, FrameRate b)
	{
		return a.rate <= b.rate;
	}

	public string ToString(string format)
	{
		return ToString(format, null);
	}

	public static int FrameRateToInt(FrameRate framerate)
	{
		return framerate.m_Rate;
	}
}
