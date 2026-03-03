using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct SortingLayer
{
	private delegate bool IsValidDelegate(int id);

	private delegate void GetSortingLayerIDsInternal_InjectedDelegate([Out] System.IntPtr ret);

	private delegate int GetLayerValueFromName_InjectedDelegate(System.IntPtr name);

	private delegate int NameToID_InjectedDelegate(System.IntPtr name);

	private delegate void IDToName_InjectedDelegate(int id, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0;

	[FieldOffset(0)]
	public int m_Id;

	private static readonly IsValidDelegate IsValidDelegateField;

	private static readonly GetSortingLayerIDsInternal_InjectedDelegate GetSortingLayerIDsInternal_InjectedDelegateField;

	private static readonly GetLayerValueFromName_InjectedDelegate GetLayerValueFromName_InjectedDelegateField;

	private static readonly NameToID_InjectedDelegate NameToID_InjectedDelegateField;

	private static readonly IDToName_InjectedDelegate IDToName_InjectedDelegateField;

	public int id => m_Id;

	public string name => IDToName(m_Id);

	public int value => GetLayerValueFromID(m_Id);

	public static Il2CppStructArray<SortingLayer> layers
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static SortingLayer()
	{
		Il2CppClassPointerStore<SortingLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SortingLayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr);
		NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, "m_Id");
		NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, 100663748);
		IsValidDelegateField = IL2CPP.ResolveICall<IsValidDelegate>("UnityEngine.SortingLayer::IsValid");
		GetSortingLayerIDsInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetSortingLayerIDsInternal_InjectedDelegate>("UnityEngine.SortingLayer::GetSortingLayerIDsInternal_Injected");
		GetLayerValueFromName_InjectedDelegateField = IL2CPP.ResolveICall<GetLayerValueFromName_InjectedDelegate>("UnityEngine.SortingLayer::GetLayerValueFromName_Injected");
		NameToID_InjectedDelegateField = IL2CPP.ResolveICall<NameToID_InjectedDelegate>("UnityEngine.SortingLayer::NameToID_Injected");
		IDToName_InjectedDelegateField = IL2CPP.ResolveICall<IDToName_InjectedDelegate>("UnityEngine.SortingLayer::IDToName_Injected");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1167124, RefRangeEnd = 1167126, XrefRangeStart = 1167122, XrefRangeEnd = 1167124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLayerValueFromID(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLayerValueFromID_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingLayer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public unsafe static Il2CppStructArray<int> GetSortingLayerIDsInternal()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<int> result;
		try
		{
			GetSortingLayerIDsInternal_Injected(out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<int> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<int>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static int GetLayerValueFromName(string name)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetLayerValueFromName_Injected(ref managedSpanWrapper);
				}
			}
			return GetLayerValueFromName_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static int NameToID(string name)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return NameToID_Injected(ref managedSpanWrapper);
				}
			}
			return NameToID_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static string IDToName(int id)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			IDToName_Injected(id, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static bool IsValid(int id)
	{
		return IsValidDelegateField(id);
	}

	public unsafe static void GetSortingLayerIDsInternal_Injected(out BlittableArrayWrapper ret)
	{
		GetSortingLayerIDsInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int GetLayerValueFromName_Injected(ref ManagedSpanWrapper name)
	{
		return GetLayerValueFromName_InjectedDelegateField((nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static int NameToID_Injected(ref ManagedSpanWrapper name)
	{
		return NameToID_InjectedDelegateField((nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static void IDToName_Injected(int id, out ManagedSpanWrapper ret)
	{
		IDToName_InjectedDelegateField(id, (nint)Unsafe.AsPointer(ref ret));
	}
}
