using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine.SubsystemsImplementation;

public static class SubsystemDescriptorStore : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0<TDescriptor, TBaseTypeInList>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0, Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDescriptor>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBaseTypeInList>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_IntegratedDescriptors;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_StandaloneDescriptors;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DeprecatedDescriptors;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeManagedDescriptor_Internal_Static_Void_IntPtr_IntegratedSubsystemDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearManagedDescriptors_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDeprecatedDescriptor_Internal_Static_Void_SubsystemDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	public unsafe static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_IntegratedDescriptors, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntegratedSubsystemDescriptor>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_IntegratedDescriptors, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_StandaloneDescriptors, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SubsystemDescriptorWithProvider>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_StandaloneDescriptors, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<SubsystemDescriptor> s_DeprecatedDescriptors
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DeprecatedDescriptors, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SubsystemDescriptor>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DeprecatedDescriptors, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SubsystemDescriptorStore()
	{
		Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine.SubsystemsImplementation", "SubsystemDescriptorStore");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr);
		NativeFieldInfoPtr_s_IntegratedDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, "s_IntegratedDescriptors");
		NativeFieldInfoPtr_s_StandaloneDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, "s_StandaloneDescriptors");
		NativeFieldInfoPtr_s_DeprecatedDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, "s_DeprecatedDescriptors");
		NativeMethodInfoPtr_InitializeManagedDescriptor_Internal_Static_Void_IntPtr_IntegratedSubsystemDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_ClearManagedDescriptors_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_RegisterDeprecatedDescriptor_Internal_Static_Void_SubsystemDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptorStore>.NativeClassPtr, 100663331);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271884, XrefRangeEnd = 1271894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeManagedDescriptor(System.IntPtr ptr, IntegratedSubsystemDescriptor desc)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeManagedDescriptor_Internal_Static_Void_IntPtr_IntegratedSubsystemDescriptor_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271894, XrefRangeEnd = 1271917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearManagedDescriptors()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearManagedDescriptors_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271917, XrefRangeEnd = 1271934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReportSingleSubsystemAnalytics(string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1271958, RefRangeEnd = 1271960, XrefRangeStart = 1271934, XrefRangeEnd = 1271958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) where TDescriptor : TBaseTypeInList
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref TDescriptor reference;
		if (!typeof(TDescriptor).IsValueType)
		{
			object obj = descriptor;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref descriptor;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)storeInList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_RegisterDescriptor_Internal_Static_Void_TDescriptor_List_1_TBaseTypeInList_0<TDescriptor, TBaseTypeInList>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271960, XrefRangeEnd = 1271967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)descriptor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterDeprecatedDescriptor_Internal_Static_Void_SubsystemDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271967, XrefRangeEnd = 1271969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReportSingleSubsystemAnalytics_Injected(ref ManagedSpanWrapper id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReportSingleSubsystemAnalytics_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SubsystemDescriptorStore(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void RegisterDescriptor(SubsystemDescriptorWithProvider descriptor)
	{
		descriptor.ThrowIfInvalid();
		RegisterDescriptor(descriptor, s_StandaloneDescriptors);
	}

	public static void GetAllSubsystemDescriptors(List<ISubsystemDescriptor> descriptors)
	{
		descriptors.Clear();
		int num = s_IntegratedDescriptors.Count + s_StandaloneDescriptors.Count + s_DeprecatedDescriptors.Count;
		if (descriptors.Capacity < num)
		{
			descriptors.Capacity = num;
		}
		AddDescriptorSubset(s_IntegratedDescriptors, descriptors);
		AddDescriptorSubset(s_StandaloneDescriptors, descriptors);
		AddDescriptorSubset(s_DeprecatedDescriptors, descriptors);
	}

	public unsafe static void AddDescriptorSubset<TBaseTypeInList>(List<TBaseTypeInList> copyFrom, List<ISubsystemDescriptor> copyTo)
	{
		//IL_0038: Expected O, but got Ref
		//IL_0027: Expected O, but got Ref
		//IL_0012: Expected O, but got Ref
		List<TBaseTypeInList>.Enumerator enumerator = copyFrom.GetEnumerator();
		try
		{
			while (((List<TBaseTypeInList>.Enumerator)(&enumerator)).MoveNext())
			{
				TBaseTypeInList current = ((List<TBaseTypeInList>.Enumerator)(&enumerator)).Current;
				copyTo.Add((ISubsystemDescriptor)(object)current);
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)(List<TBaseTypeInList>.Enumerator)(&enumerator)).Dispose();
		}
	}

	public static void GetSubsystemDescriptors<T>(List<T> descriptors)
	{
		descriptors.Clear();
		AddDescriptorSubset(s_IntegratedDescriptors, descriptors);
		AddDescriptorSubset(s_StandaloneDescriptors, descriptors);
		AddDescriptorSubset(s_DeprecatedDescriptors, descriptors);
	}

	public unsafe static void AddDescriptorSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo)
	{
		//IL_005b: Expected O, but got Ref
		//IL_004a: Expected O, but got Ref
		//IL_0012: Expected O, but got Ref
		List<TBaseTypeInList>.Enumerator enumerator = copyFrom.GetEnumerator();
		try
		{
			while (((List<TBaseTypeInList>.Enumerator)(&enumerator)).MoveNext())
			{
				TBaseTypeInList current = ((List<TBaseTypeInList>.Enumerator)(&enumerator)).Current;
				if (((Il2CppObjectBase)(object)current).TryCast<TQueryType>() != null)
				{
					TQueryType item = ((Il2CppObjectBase)((Il2CppObjectBase)(object)current).TryCast<TQueryType>()).Cast<TQueryType>();
					if (true)
					{
						copyTo.Add(item);
					}
				}
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)(List<TBaseTypeInList>.Enumerator)(&enumerator)).Dispose();
		}
	}
}
