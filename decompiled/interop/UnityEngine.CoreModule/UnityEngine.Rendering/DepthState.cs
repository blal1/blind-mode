using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct DepthState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_WriteEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CompareFunction;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_DepthState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_compareFunction_Public_get_CompareFunction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public byte m_WriteEnabled;

	[FieldOffset(1)]
	public sbyte m_CompareFunction;

	public unsafe static DepthState defaultValue
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238218, XrefRangeEnd = 1238222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultValue_Public_Static_get_DepthState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DepthState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe CompareFunction compareFunction
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238228, RefRangeEnd = 1238229, XrefRangeStart = 1238228, XrefRangeEnd = 1238228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_compareFunction_Public_get_CompareFunction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CompareFunction*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_CompareFunction = (sbyte)value;
		}
	}

	public bool writeEnabled
	{
		get
		{
			return Il2CppSystem.Convert.ToBoolean(m_WriteEnabled);
		}
		set
		{
			m_WriteEnabled = Il2CppSystem.Convert.ToByte(value);
		}
	}

	static DepthState()
	{
		Il2CppClassPointerStore<DepthState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "DepthState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthState>.NativeClassPtr);
		NativeFieldInfoPtr_m_WriteEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthState>.NativeClassPtr, "m_WriteEnabled");
		NativeFieldInfoPtr_m_CompareFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthState>.NativeClassPtr, "m_CompareFunction");
		NativeMethodInfoPtr_get_defaultValue_Public_Static_get_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668488);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668489);
		NativeMethodInfoPtr_get_compareFunction_Public_get_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668490);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668491);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668492);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100668493);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1238226, RefRangeEnd = 1238228, XrefRangeStart = 1238222, XrefRangeEnd = 1238226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DepthState(bool writeEnabled = true, CompareFunction compareFunction = CompareFunction.Less)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&writeEnabled);
		*(CompareFunction**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &compareFunction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(DepthState other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238229, XrefRangeEnd = 1238232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238232, XrefRangeEnd = 1238234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepthState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(DepthState left, DepthState right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(DepthState left, DepthState right)
	{
		return !left.Equals(right);
	}
}
