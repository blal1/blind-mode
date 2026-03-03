using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct LinearColor
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_red;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_green;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_blue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_intensity;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_red_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_red_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_green_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_green_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blue_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Black_Public_Static_LinearColor_0;

	[FieldOffset(0)]
	public float m_red;

	[FieldOffset(4)]
	public float m_green;

	[FieldOffset(8)]
	public float m_blue;

	[FieldOffset(12)]
	public float m_intensity;

	public unsafe float red
	{
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 1167165, RefRangeEnd = 1167244, XrefRangeStart = 1167165, XrefRangeEnd = 1167244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_red_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1240730, RefRangeEnd = 1240741, XrefRangeStart = 1240730, XrefRangeEnd = 1240730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_red_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float green
	{
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 1153785, RefRangeEnd = 1153875, XrefRangeStart = 1153785, XrefRangeEnd = 1153875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_green_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1240741, RefRangeEnd = 1240752, XrefRangeStart = 1240741, XrefRangeEnd = 1240741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_green_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float blue
	{
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1161205, RefRangeEnd = 1161251, XrefRangeStart = 1161205, XrefRangeEnd = 1161251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blue_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1240752, RefRangeEnd = 1240763, XrefRangeStart = 1240752, XrefRangeEnd = 1240752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public float intensity
	{
		get
		{
			return m_intensity;
		}
		set
		{
			if (value < 0f)
			{
				throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Concat("Intensity (", value.ToString(), ") must be positive."));
			}
			m_intensity = value;
		}
	}

	static LinearColor()
	{
		Il2CppClassPointerStore<LinearColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LinearColor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinearColor>.NativeClassPtr);
		NativeFieldInfoPtr_m_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_red");
		NativeFieldInfoPtr_m_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_green");
		NativeFieldInfoPtr_m_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_blue");
		NativeFieldInfoPtr_m_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, "m_intensity");
		NativeMethodInfoPtr_get_red_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668892);
		NativeMethodInfoPtr_set_red_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668893);
		NativeMethodInfoPtr_get_green_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668894);
		NativeMethodInfoPtr_set_green_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668895);
		NativeMethodInfoPtr_get_blue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668896);
		NativeMethodInfoPtr_set_blue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668897);
		NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668898);
		NativeMethodInfoPtr_Black_Public_Static_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, 100668899);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1240777, RefRangeEnd = 1240788, XrefRangeStart = 1240763, XrefRangeEnd = 1240777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LinearColor Convert(Color color, float intensity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &intensity;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Convert_Public_Static_LinearColor_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LinearColor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static LinearColor Black()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Black_Public_Static_LinearColor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LinearColor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LinearColor>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
