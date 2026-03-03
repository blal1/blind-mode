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
using UnityEngine.SubsystemsImplementation;

namespace UnityEngine;

public static class SubsystemManager : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_GetSubsystems_Public_Static_Void_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetSubsystems_Public_Static_Void_List_1_T_0, Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddSubsystemSubset_Private_Static_Void_List_1_TBaseTypeInList_List_1_TQueryType_0<TBaseTypeInList, TQueryType>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddSubsystemSubset_Private_Static_Void_List_1_TBaseTypeInList_List_1_TQueryType_0, Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBaseTypeInList>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TQueryType>.NativeClassPtr))
		}))));
	}

	private delegate void ReportSingleSubsystemAnalytics_InjectedDelegate(System.IntPtr id);

	private static readonly System.IntPtr NativeFieldInfoPtr_beforeReloadSubsystems;

	private static readonly System.IntPtr NativeFieldInfoPtr_afterReloadSubsystems;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_IntegratedSubsystems;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_StandaloneSubsystems;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DeprecatedSubsystems;

	private static readonly System.IntPtr NativeFieldInfoPtr_reloadSubsytemsStarted;

	private static readonly System.IntPtr NativeFieldInfoPtr_reloadSubsytemsCompleted;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReloadSubsystemsStarted_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReloadSubsystemsCompleted_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeIntegratedSubsystem_Private_Static_Void_IntPtr_IntegratedSubsystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSubsystems_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StaticConstructScriptingClassMap_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubsystems_Public_Static_Void_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSubsystemSubset_Private_Static_Void_List_1_TBaseTypeInList_List_1_TQueryType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIntegratedSubsystemByPtr_Internal_Static_IntegratedSubsystem_IntPtr_0;

	private static readonly ReportSingleSubsystemAnalytics_InjectedDelegate ReportSingleSubsystemAnalytics_InjectedDelegateField;

	public unsafe static Il2CppSystem.Action beforeReloadSubsystems
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_beforeReloadSubsystems, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_beforeReloadSubsystems, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action afterReloadSubsystems
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_afterReloadSubsystems, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_afterReloadSubsystems, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<IntegratedSubsystem> s_IntegratedSubsystems
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_IntegratedSubsystems, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntegratedSubsystem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_IntegratedSubsystems, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<SubsystemWithProvider> s_StandaloneSubsystems
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_StandaloneSubsystems, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SubsystemWithProvider>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_StandaloneSubsystems, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<Subsystem> s_DeprecatedSubsystems
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DeprecatedSubsystems, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Subsystem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DeprecatedSubsystems, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action reloadSubsytemsStarted
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reloadSubsytemsStarted, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reloadSubsytemsStarted, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action reloadSubsytemsCompleted
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reloadSubsytemsCompleted, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reloadSubsytemsCompleted, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SubsystemManager()
	{
		Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "SubsystemManager");
		NativeFieldInfoPtr_beforeReloadSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "beforeReloadSubsystems");
		NativeFieldInfoPtr_afterReloadSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "afterReloadSubsystems");
		NativeFieldInfoPtr_s_IntegratedSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "s_IntegratedSubsystems");
		NativeFieldInfoPtr_s_StandaloneSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "s_StandaloneSubsystems");
		NativeFieldInfoPtr_s_DeprecatedSubsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "s_DeprecatedSubsystems");
		NativeFieldInfoPtr_reloadSubsytemsStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "reloadSubsytemsStarted");
		NativeFieldInfoPtr_reloadSubsytemsCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, "reloadSubsytemsCompleted");
		NativeMethodInfoPtr_ReloadSubsystemsStarted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_ReloadSubsystemsCompleted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_InitializeIntegratedSubsystem_Private_Static_Void_IntPtr_IntegratedSubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_ClearSubsystems_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_StaticConstructScriptingClassMap_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_GetSubsystems_Public_Static_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_AddSubsystemSubset_Private_Static_Void_List_1_TBaseTypeInList_List_1_TQueryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_GetIntegratedSubsystemByPtr_Internal_Static_IntegratedSubsystem_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemManager>.NativeClassPtr, 100663324);
		ReportSingleSubsystemAnalytics_InjectedDelegateField = IL2CPP.ResolveICall<ReportSingleSubsystemAnalytics_InjectedDelegate>("UnityEngine.SubsystemManager::ReportSingleSubsystemAnalytics_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271736, XrefRangeEnd = 1271747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReloadSubsystemsStarted()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReloadSubsystemsStarted_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271747, XrefRangeEnd = 1271758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReloadSubsystemsCompleted()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReloadSubsystemsCompleted_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271758, XrefRangeEnd = 1271771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeIntegratedSubsystem(System.IntPtr ptr, IntegratedSubsystem subsystem)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subsystem);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeIntegratedSubsystem_Private_Static_Void_IntPtr_IntegratedSubsystem_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271771, XrefRangeEnd = 1271800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearSubsystems()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSubsystems_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271800, XrefRangeEnd = 1271832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StaticConstructScriptingClassMap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StaticConstructScriptingClassMap_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1271844, RefRangeEnd = 1271847, XrefRangeStart = 1271832, XrefRangeEnd = 1271844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSubsystems<T>(List<T> subsystems)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subsystems);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetSubsystems_Public_Static_Void_List_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1271859, RefRangeEnd = 1271862, XrefRangeStart = 1271847, XrefRangeEnd = 1271859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddSubsystemSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyTo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddSubsystemSubset_Private_Static_Void_List_1_TBaseTypeInList_List_1_TQueryType_0<TBaseTypeInList, TQueryType>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1271882, RefRangeEnd = 1271884, XrefRangeStart = 1271862, XrefRangeEnd = 1271882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntegratedSubsystem GetIntegratedSubsystemByPtr(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIntegratedSubsystemByPtr_Internal_Static_IntegratedSubsystem_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IntegratedSubsystem>(intPtr2) : null;
	}

	public SubsystemManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void ReportSingleSubsystemAnalytics(string id)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(id, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(id);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					ReportSingleSubsystemAnalytics_Injected(ref managedSpanWrapper);
					return;
				}
			}
			ReportSingleSubsystemAnalytics_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void GetAllSubsystemDescriptors(List<ISubsystemDescriptor> descriptors)
	{
		SubsystemDescriptorStore.GetAllSubsystemDescriptors(descriptors);
	}

	public static void GetSubsystemDescriptors<T>(List<T> descriptors)
	{
		SubsystemDescriptorStore.GetSubsystemDescriptors(descriptors);
	}

	[SpecialName]
	public static void add_beforeReloadSubsystems(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_beforeReloadSubsystems(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_afterReloadSubsystems(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_afterReloadSubsystems(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void RemoveIntegratedSubsystemByPtr(System.IntPtr ptr)
	{
		for (int i = 0; i < s_IntegratedSubsystems.Count; i++)
		{
			if (!(s_IntegratedSubsystems[i].m_Ptr != ptr))
			{
				s_IntegratedSubsystems[i].m_Ptr = Il2CppSystem.IntPtr.Zero;
				s_IntegratedSubsystems.RemoveAt(i);
				break;
			}
		}
	}

	public static void AddStandaloneSubsystem(SubsystemWithProvider subsystem)
	{
		s_StandaloneSubsystems.Add(subsystem);
	}

	public static bool RemoveStandaloneSubsystem(SubsystemWithProvider subsystem)
	{
		return s_StandaloneSubsystems.Remove(subsystem);
	}

	public unsafe static SubsystemWithProvider FindStandaloneSubsystemByDescriptor(SubsystemDescriptorWithProvider descriptor)
	{
		//IL_0042: Expected O, but got Ref
		//IL_0031: Expected O, but got Ref
		//IL_0016: Expected O, but got Ref
		List<SubsystemWithProvider>.Enumerator enumerator = s_StandaloneSubsystems.GetEnumerator();
		try
		{
			while (((List<SubsystemWithProvider>.Enumerator)(&enumerator)).MoveNext())
			{
				SubsystemWithProvider current = ((List<SubsystemWithProvider>.Enumerator)(&enumerator)).Current;
				if (current.descriptor == descriptor)
				{
					return current;
				}
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)(List<SubsystemWithProvider>.Enumerator)(&enumerator)).Dispose();
		}
		return null;
	}

	public static void GetInstances<T>(List<T> subsystems)
	{
		GetSubsystems(subsystems);
	}

	public static void AddDeprecatedSubsystem(Subsystem subsystem)
	{
		s_DeprecatedSubsystems.Add(subsystem);
	}

	public static bool RemoveDeprecatedSubsystem(Subsystem subsystem)
	{
		return s_DeprecatedSubsystems.Remove(subsystem);
	}

	public static Subsystem FindDeprecatedSubsystemByDescriptor(SubsystemDescriptor descriptor)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_reloadSubsytemsStarted(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_reloadSubsytemsStarted(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_reloadSubsytemsCompleted(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_reloadSubsytemsCompleted(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void ReportSingleSubsystemAnalytics_Injected(ref ManagedSpanWrapper id)
	{
		ReportSingleSubsystemAnalytics_InjectedDelegateField((nint)Unsafe.AsPointer(ref id));
	}
}
