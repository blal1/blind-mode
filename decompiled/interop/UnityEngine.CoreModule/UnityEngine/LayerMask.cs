using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct LayerMask
{
	private delegate void LayerToName_InjectedDelegate(int layer, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Mask;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NameToLayer_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0;

	[FieldOffset(0)]
	public int m_Mask;

	private static readonly LayerToName_InjectedDelegate LayerToName_InjectedDelegateField;

	public unsafe int value
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_value_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Mask = value;
		}
	}

	static LayerMask()
	{
		Il2CppClassPointerStore<LayerMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LayerMask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerMask>.NativeClassPtr);
		NativeFieldInfoPtr_m_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, "m_Mask");
		NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100666384);
		NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100666385);
		NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100666386);
		NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100666387);
		NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100666388);
		NativeMethodInfoPtr_NameToLayer_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100666389);
		LayerToName_InjectedDelegateField = IL2CPP.ResolveICall<LayerToName_InjectedDelegate>("UnityEngine.LayerMask::LayerToName_Injected");
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 1185438, RefRangeEnd = 1185489, XrefRangeStart = 1185438, XrefRangeEnd = 1185489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator int(LayerMask mask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mask);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 1185438, RefRangeEnd = 1185489, XrefRangeStart = 1185438, XrefRangeEnd = 1185489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator LayerMask(int intVal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&intVal);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(LayerMask*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1202933, RefRangeEnd = 1202934, XrefRangeStart = 1202921, XrefRangeEnd = 1202933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NameToLayer(string layerName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(layerName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1202936, RefRangeEnd = 1202938, XrefRangeStart = 1202934, XrefRangeEnd = 1202936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMask([Optional] Il2CppStringArray layerNames)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		if (layerNames == null)
		{
			layerNames = new Il2CppStringArray(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layerNames);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202938, XrefRangeEnd = 1202940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NameToLayer_Injected(ref ManagedSpanWrapper layerName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref layerName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NameToLayer_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public static int GetMask(params string[] layerNames)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return GetMask(new Il2CppStringArray(layerNames));
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static string LayerToName(int layer)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			LayerToName_Injected(layer, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static void LayerToName_Injected(int layer, out ManagedSpanWrapper ret)
	{
		LayerToName_InjectedDelegateField(layer, (nint)Unsafe.AsPointer(ref ret));
	}
}
