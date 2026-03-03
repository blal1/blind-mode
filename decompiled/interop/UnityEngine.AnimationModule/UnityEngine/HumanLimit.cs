using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct HumanLimit
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Min;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Max;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Center;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AxisLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseDefaultValues;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useDefaultValues_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useDefaultValues_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_min_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_max_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_axisLength_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_axisLength_Public_set_Void_Single_0;

	[FieldOffset(0)]
	public Vector3 m_Min;

	[FieldOffset(12)]
	public Vector3 m_Max;

	[FieldOffset(24)]
	public Vector3 m_Center;

	[FieldOffset(36)]
	public float m_AxisLength;

	[FieldOffset(40)]
	public int m_UseDefaultValues;

	public unsafe bool useDefaultValues
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useDefaultValues_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useDefaultValues_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 min
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1154376, RefRangeEnd = 1154380, XrefRangeStart = 1154376, XrefRangeEnd = 1154380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_min_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1000096, RefRangeEnd = 1000102, XrefRangeStart = 1000096, XrefRangeEnd = 1000102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 max
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1157010, RefRangeEnd = 1157013, XrefRangeStart = 1157010, XrefRangeEnd = 1157010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_max_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 center
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_center_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float axisLength
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1157013, RefRangeEnd = 1157023, XrefRangeStart = 1157013, XrefRangeEnd = 1157013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_axisLength_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_axisLength_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static HumanLimit()
	{
		Il2CppClassPointerStore<HumanLimit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanLimit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr);
		NativeFieldInfoPtr_m_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Min");
		NativeFieldInfoPtr_m_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Max");
		NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_Center");
		NativeFieldInfoPtr_m_AxisLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_AxisLength");
		NativeFieldInfoPtr_m_UseDefaultValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, "m_UseDefaultValues");
		NativeMethodInfoPtr_get_useDefaultValues_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, 100664085);
		NativeMethodInfoPtr_set_useDefaultValues_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, 100664086);
		NativeMethodInfoPtr_get_min_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, 100664087);
		NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, 100664088);
		NativeMethodInfoPtr_get_max_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, 100664089);
		NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, 100664090);
		NativeMethodInfoPtr_get_center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, 100664091);
		NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, 100664092);
		NativeMethodInfoPtr_get_axisLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, 100664093);
		NativeMethodInfoPtr_set_axisLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, 100664094);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HumanLimit>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
