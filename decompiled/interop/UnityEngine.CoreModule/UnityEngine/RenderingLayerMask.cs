using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct RenderingLayerMask
{
	private delegate uint Internal_GetDefaultRenderingLayerValueDelegate();

	private delegate int GetLastDefinedRenderingLayerIndexDelegate();

	private delegate int NameToRenderingLayer_InjectedDelegate(System.IntPtr layerName);

	private delegate void GetDefinedRenderingLayerValues_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Bits;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultRenderingLayerMask_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxRenderingLayerSize;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RenderingLayerMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderingLayerMask_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_RenderingLayerMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderingLayerMask_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderingLayerToName_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefinedRenderingLayerCount_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefinedRenderingLayersCombinedMaskValue_Public_Static_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefinedRenderingLayerNames_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderingLayerCount_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderingLayerToName_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0;

	[FieldOffset(0)]
	public uint m_Bits;

	private static readonly Internal_GetDefaultRenderingLayerValueDelegate Internal_GetDefaultRenderingLayerValueDelegateField;

	private static readonly GetLastDefinedRenderingLayerIndexDelegate GetLastDefinedRenderingLayerIndexDelegateField;

	private static readonly NameToRenderingLayer_InjectedDelegate NameToRenderingLayer_InjectedDelegateField;

	private static readonly GetDefinedRenderingLayerValues_InjectedDelegate GetDefinedRenderingLayerValues_InjectedDelegateField;

	public unsafe static RenderingLayerMask _defaultRenderingLayerMask_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out RenderingLayerMask result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__defaultRenderingLayerMask_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__defaultRenderingLayerMask_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static int maxRenderingLayerSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxRenderingLayerSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxRenderingLayerSize, (void*)(&value));
		}
	}

	public static RenderingLayerMask defaultRenderingLayerMask => _defaultRenderingLayerMask_k__BackingField;

	public uint value
	{
		get
		{
			return m_Bits;
		}
		set
		{
			m_Bits = value;
		}
	}

	static RenderingLayerMask()
	{
		Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderingLayerMask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr);
		NativeFieldInfoPtr_m_Bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, "m_Bits");
		NativeFieldInfoPtr__defaultRenderingLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, "<defaultRenderingLayerMask>k__BackingField");
		NativeFieldInfoPtr_maxRenderingLayerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, "maxRenderingLayerSize");
		NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RenderingLayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100666093);
		NativeMethodInfoPtr_op_Implicit_Public_Static_RenderingLayerMask_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100666094);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_RenderingLayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100666095);
		NativeMethodInfoPtr_op_Implicit_Public_Static_RenderingLayerMask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100666096);
		NativeMethodInfoPtr_RenderingLayerToName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100666097);
		NativeMethodInfoPtr_GetDefinedRenderingLayerCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100666098);
		NativeMethodInfoPtr_GetDefinedRenderingLayersCombinedMaskValue_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100666099);
		NativeMethodInfoPtr_GetDefinedRenderingLayerNames_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100666100);
		NativeMethodInfoPtr_GetRenderingLayerCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100666101);
		NativeMethodInfoPtr_RenderingLayerToName_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100666103);
		Internal_GetDefaultRenderingLayerValueDelegateField = IL2CPP.ResolveICall<Internal_GetDefaultRenderingLayerValueDelegate>("UnityEngine.RenderingLayerMask::Internal_GetDefaultRenderingLayerValue");
		GetLastDefinedRenderingLayerIndexDelegateField = IL2CPP.ResolveICall<GetLastDefinedRenderingLayerIndexDelegate>("UnityEngine.RenderingLayerMask::GetLastDefinedRenderingLayerIndex");
		NameToRenderingLayer_InjectedDelegateField = IL2CPP.ResolveICall<NameToRenderingLayer_InjectedDelegate>("UnityEngine.RenderingLayerMask::NameToRenderingLayer_Injected");
		GetDefinedRenderingLayerValues_InjectedDelegateField = IL2CPP.ResolveICall<GetDefinedRenderingLayerValues_InjectedDelegate>("UnityEngine.RenderingLayerMask::GetDefinedRenderingLayerValues_Injected");
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 1185438, RefRangeEnd = 1185489, XrefRangeStart = 1185438, XrefRangeEnd = 1185438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator uint(RenderingLayerMask mask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mask);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RenderingLayerMask_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 1185438, RefRangeEnd = 1185489, XrefRangeStart = 1185438, XrefRangeEnd = 1185489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator RenderingLayerMask(uint intVal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&intVal);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_RenderingLayerMask_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderingLayerMask*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 1185438, RefRangeEnd = 1185489, XrefRangeStart = 1185438, XrefRangeEnd = 1185489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator int(RenderingLayerMask mask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mask);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_RenderingLayerMask_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 1185438, RefRangeEnd = 1185489, XrefRangeStart = 1185438, XrefRangeEnd = 1185489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator RenderingLayerMask(int intVal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&intVal);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_RenderingLayerMask_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderingLayerMask*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1185497, RefRangeEnd = 1185498, XrefRangeStart = 1185489, XrefRangeEnd = 1185497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string RenderingLayerToName(int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&layer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderingLayerToName_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1185500, RefRangeEnd = 1185505, XrefRangeStart = 1185498, XrefRangeEnd = 1185500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDefinedRenderingLayerCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefinedRenderingLayerCount_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185505, XrefRangeEnd = 1185507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetDefinedRenderingLayersCombinedMaskValue()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefinedRenderingLayersCombinedMaskValue_Public_Static_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1185509, RefRangeEnd = 1185510, XrefRangeStart = 1185507, XrefRangeEnd = 1185509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetDefinedRenderingLayerNames()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefinedRenderingLayerNames_Public_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1185512, RefRangeEnd = 1185516, XrefRangeStart = 1185510, XrefRangeEnd = 1185512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRenderingLayerCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderingLayerCount_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185516, XrefRangeEnd = 1185518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderingLayerToName_Injected(int layer, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&layer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderingLayerToName_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static uint Internal_GetDefaultRenderingLayerValue()
	{
		return Internal_GetDefaultRenderingLayerValueDelegateField();
	}

	public unsafe static int NameToRenderingLayer(string layerName)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(layerName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(layerName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return NameToRenderingLayer_Injected(ref managedSpanWrapper);
				}
			}
			return NameToRenderingLayer_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static uint GetMask(Il2CppStringArray renderingLayerNames)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static uint GetMask(params string[] renderingLayerNames)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return GetMask(new Il2CppStringArray(renderingLayerNames));
	}

	public unsafe static uint GetMask(Il2CppSystem.ReadOnlySpan<string> renderingLayerNames)
	{
		//IL_005f: Expected O, but got Ref
		//IL_002d: Expected O, but got Ref
		if (renderingLayerNames == (Il2CppArrayBase<string>)null)
		{
			throw new Il2CppSystem.ArgumentNullException("renderingLayerNames");
		}
		uint num = 0u;
		Il2CppSystem.ReadOnlySpan<string> readOnlySpan = renderingLayerNames;
		for (int i = 0; i < ((Il2CppSystem.ReadOnlySpan<string>)(&readOnlySpan)).Length; i++)
		{
			string layerName = ((Il2CppSystem.ReadOnlySpan<string>)(&readOnlySpan))[i];
			int num2 = NameToRenderingLayer(layerName);
			if (num2 != -1)
			{
				num |= (uint)(1 << num2);
			}
		}
		return num;
	}

	public static int GetLastDefinedRenderingLayerIndex()
	{
		return GetLastDefinedRenderingLayerIndexDelegateField();
	}

	public unsafe static Il2CppStructArray<int> GetDefinedRenderingLayerValues()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<int> result;
		try
		{
			GetDefinedRenderingLayerValues_Injected(out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<int> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<int>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static int NameToRenderingLayer_Injected(ref ManagedSpanWrapper layerName)
	{
		return NameToRenderingLayer_InjectedDelegateField((nint)Unsafe.AsPointer(ref layerName));
	}

	public unsafe static void GetDefinedRenderingLayerValues_Injected(out BlittableArrayWrapper ret)
	{
		GetDefinedRenderingLayerValues_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}
}
