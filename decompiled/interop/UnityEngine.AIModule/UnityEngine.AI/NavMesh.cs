using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.AI;

public static class NavMesh : Il2CppSystem.Object
{
	public sealed class OnNavMeshPreUpdate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		static OnNavMeshPreUpdate()
		{
			Il2CppClassPointerStore<OnNavMeshPreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavMesh>.NativeClassPtr, "OnNavMeshPreUpdate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnNavMeshPreUpdate>.NativeClassPtr, 100663299);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnNavMeshPreUpdate>.NativeClassPtr, 100663300);
		}

		[CallerCount(4109)]
		[CachedScanResults(RefRangeStart = 27728, RefRangeEnd = 31837, XrefRangeStart = 27728, XrefRangeEnd = 31837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnNavMeshPreUpdate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnNavMeshPreUpdate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OnNavMeshPreUpdate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnNavMeshPreUpdate(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<OnNavMeshPreUpdate>((System.Delegate)P_0);
		}

		public static OnNavMeshPreUpdate operator +(OnNavMeshPreUpdate P_0, OnNavMeshPreUpdate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnNavMeshPreUpdate>();
		}

		public static OnNavMeshPreUpdate operator -(OnNavMeshPreUpdate P_0, OnNavMeshPreUpdate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnNavMeshPreUpdate>();
			}
			return (OnNavMeshPreUpdate)obj;
		}
	}

	private delegate void SetLayerCostDelegate(int layer, float cost);

	private delegate float GetLayerCostDelegate(int layer);

	private delegate void SetAreaCostDelegate(int areaIndex, float cost);

	private delegate float GetAreaCostDelegate(int areaIndex);

	private delegate System.IntPtr GetAreaNamesDelegate();

	private delegate float get_avoidancePredictionTimeDelegate();

	private delegate void set_avoidancePredictionTimeDelegate(float value);

	private delegate int get_pathfindingIterationsPerFrameDelegate();

	private delegate void set_pathfindingIterationsPerFrameDelegate(int value);

	private delegate bool IsValidNavMeshDataHandleDelegate(int handle);

	private delegate bool IsValidLinkHandleDelegate(int handle);

	private delegate bool InternalSetOwnerDelegate(int dataID, int ownerID);

	private delegate bool InternalSetLinkOwnerDelegate(int linkID, int ownerID);

	private delegate void RemoveNavMeshDataInternalDelegate(int handle);

	private delegate void RemoveLinkInternalDelegate(int handle);

	private delegate bool IsOffMeshConnectionOccupiedDelegate(int handle);

	private delegate bool IsOffMeshConnectionActiveDelegate(int linkHandle);

	private delegate void SetOffMeshConnectionActiveDelegate(int linkHandle, bool activated);

	private delegate void RemoveSettingsDelegate(int agentTypeID);

	private delegate int GetSettingsCountDelegate();

	private delegate void RemoveAllNavMeshDataDelegate();

	private delegate bool CalculatePathInternal_InjectedDelegate([In] System.IntPtr sourcePosition, [In] System.IntPtr targetPosition, int areaMask, System.IntPtr path);

	private delegate int GetNavMeshLayerFromName_InjectedDelegate(System.IntPtr layerName);

	private delegate int GetAreaFromName_InjectedDelegate(System.IntPtr areaName);

	private delegate System.IntPtr InternalGetOwner_InjectedDelegate(int dataID);

	private delegate System.IntPtr InternalGetLinkOwner_InjectedDelegate(int linkID);

	private delegate int AddNavMeshDataInternal_InjectedDelegate(System.IntPtr navMeshData);

	private delegate int AddNavMeshDataTransformedInternal_InjectedDelegate(System.IntPtr navMeshData, [In] System.IntPtr position, [In] System.IntPtr rotation);

	private delegate bool CalculatePathFilterInternal_InjectedDelegate([In] System.IntPtr sourcePosition, [In] System.IntPtr targetPosition, System.IntPtr path, int type, int mask, System.IntPtr costs);

	private delegate void GetSettingsNameFromID_InjectedDelegate(int agentTypeID, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_onPreUpdate;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearPreUpdateListeners_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CallOnNavMeshPreUpdate_Private_Static_Void_0;

	public const int AllAreas = -1;

	private static readonly SetLayerCostDelegate SetLayerCostDelegateField;

	private static readonly GetLayerCostDelegate GetLayerCostDelegateField;

	private static readonly SetAreaCostDelegate SetAreaCostDelegateField;

	private static readonly GetAreaCostDelegate GetAreaCostDelegateField;

	private static readonly GetAreaNamesDelegate GetAreaNamesDelegateField;

	private static readonly get_avoidancePredictionTimeDelegate get_avoidancePredictionTimeDelegateField;

	private static readonly set_avoidancePredictionTimeDelegate set_avoidancePredictionTimeDelegateField;

	private static readonly get_pathfindingIterationsPerFrameDelegate get_pathfindingIterationsPerFrameDelegateField;

	private static readonly set_pathfindingIterationsPerFrameDelegate set_pathfindingIterationsPerFrameDelegateField;

	private static readonly IsValidNavMeshDataHandleDelegate IsValidNavMeshDataHandleDelegateField;

	private static readonly IsValidLinkHandleDelegate IsValidLinkHandleDelegateField;

	private static readonly InternalSetOwnerDelegate InternalSetOwnerDelegateField;

	private static readonly InternalSetLinkOwnerDelegate InternalSetLinkOwnerDelegateField;

	private static readonly RemoveNavMeshDataInternalDelegate RemoveNavMeshDataInternalDelegateField;

	private static readonly RemoveLinkInternalDelegate RemoveLinkInternalDelegateField;

	private static readonly IsOffMeshConnectionOccupiedDelegate IsOffMeshConnectionOccupiedDelegateField;

	private static readonly IsOffMeshConnectionActiveDelegate IsOffMeshConnectionActiveDelegateField;

	private static readonly SetOffMeshConnectionActiveDelegate SetOffMeshConnectionActiveDelegateField;

	private static readonly RemoveSettingsDelegate RemoveSettingsDelegateField;

	private static readonly GetSettingsCountDelegate GetSettingsCountDelegateField;

	private static readonly RemoveAllNavMeshDataDelegate RemoveAllNavMeshDataDelegateField;

	private static readonly CalculatePathInternal_InjectedDelegate CalculatePathInternal_InjectedDelegateField;

	private static readonly GetNavMeshLayerFromName_InjectedDelegate GetNavMeshLayerFromName_InjectedDelegateField;

	private static readonly GetAreaFromName_InjectedDelegate GetAreaFromName_InjectedDelegateField;

	private static readonly InternalGetOwner_InjectedDelegate InternalGetOwner_InjectedDelegateField;

	private static readonly InternalGetLinkOwner_InjectedDelegate InternalGetLinkOwner_InjectedDelegateField;

	private static readonly AddNavMeshDataInternal_InjectedDelegate AddNavMeshDataInternal_InjectedDelegateField;

	private static readonly AddNavMeshDataTransformedInternal_InjectedDelegate AddNavMeshDataTransformedInternal_InjectedDelegateField;

	private static readonly CalculatePathFilterInternal_InjectedDelegate CalculatePathFilterInternal_InjectedDelegateField;

	private static readonly GetSettingsNameFromID_InjectedDelegate GetSettingsNameFromID_InjectedDelegateField;

	public unsafe static OnNavMeshPreUpdate onPreUpdate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onPreUpdate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnNavMeshPreUpdate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onPreUpdate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public static float avoidancePredictionTime
	{
		get
		{
			return get_avoidancePredictionTimeDelegateField();
		}
		set
		{
			set_avoidancePredictionTimeDelegateField(value);
		}
	}

	public static int pathfindingIterationsPerFrame
	{
		get
		{
			return get_pathfindingIterationsPerFrameDelegateField();
		}
		set
		{
			set_pathfindingIterationsPerFrameDelegateField(value);
		}
	}

	static NavMesh()
	{
		Il2CppClassPointerStore<NavMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AIModule.dll", "UnityEngine.AI", "NavMesh");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavMesh>.NativeClassPtr);
		NativeFieldInfoPtr_onPreUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMesh>.NativeClassPtr, "onPreUpdate");
		NativeMethodInfoPtr_ClearPreUpdateListeners_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMesh>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_Internal_CallOnNavMeshPreUpdate_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMesh>.NativeClassPtr, 100663298);
		SetLayerCostDelegateField = IL2CPP.ResolveICall<SetLayerCostDelegate>("UnityEngine.AI.NavMesh::SetLayerCost");
		GetLayerCostDelegateField = IL2CPP.ResolveICall<GetLayerCostDelegate>("UnityEngine.AI.NavMesh::GetLayerCost");
		SetAreaCostDelegateField = IL2CPP.ResolveICall<SetAreaCostDelegate>("UnityEngine.AI.NavMesh::SetAreaCost");
		GetAreaCostDelegateField = IL2CPP.ResolveICall<GetAreaCostDelegate>("UnityEngine.AI.NavMesh::GetAreaCost");
		GetAreaNamesDelegateField = IL2CPP.ResolveICall<GetAreaNamesDelegate>("UnityEngine.AI.NavMesh::GetAreaNames");
		get_avoidancePredictionTimeDelegateField = IL2CPP.ResolveICall<get_avoidancePredictionTimeDelegate>("UnityEngine.AI.NavMesh::get_avoidancePredictionTime");
		set_avoidancePredictionTimeDelegateField = IL2CPP.ResolveICall<set_avoidancePredictionTimeDelegate>("UnityEngine.AI.NavMesh::set_avoidancePredictionTime");
		get_pathfindingIterationsPerFrameDelegateField = IL2CPP.ResolveICall<get_pathfindingIterationsPerFrameDelegate>("UnityEngine.AI.NavMesh::get_pathfindingIterationsPerFrame");
		set_pathfindingIterationsPerFrameDelegateField = IL2CPP.ResolveICall<set_pathfindingIterationsPerFrameDelegate>("UnityEngine.AI.NavMesh::set_pathfindingIterationsPerFrame");
		IsValidNavMeshDataHandleDelegateField = IL2CPP.ResolveICall<IsValidNavMeshDataHandleDelegate>("UnityEngine.AI.NavMesh::IsValidNavMeshDataHandle");
		IsValidLinkHandleDelegateField = IL2CPP.ResolveICall<IsValidLinkHandleDelegate>("UnityEngine.AI.NavMesh::IsValidLinkHandle");
		InternalSetOwnerDelegateField = IL2CPP.ResolveICall<InternalSetOwnerDelegate>("UnityEngine.AI.NavMesh::InternalSetOwner");
		InternalSetLinkOwnerDelegateField = IL2CPP.ResolveICall<InternalSetLinkOwnerDelegate>("UnityEngine.AI.NavMesh::InternalSetLinkOwner");
		RemoveNavMeshDataInternalDelegateField = IL2CPP.ResolveICall<RemoveNavMeshDataInternalDelegate>("UnityEngine.AI.NavMesh::RemoveNavMeshDataInternal");
		RemoveLinkInternalDelegateField = IL2CPP.ResolveICall<RemoveLinkInternalDelegate>("UnityEngine.AI.NavMesh::RemoveLinkInternal");
		IsOffMeshConnectionOccupiedDelegateField = IL2CPP.ResolveICall<IsOffMeshConnectionOccupiedDelegate>("UnityEngine.AI.NavMesh::IsOffMeshConnectionOccupied");
		IsOffMeshConnectionActiveDelegateField = IL2CPP.ResolveICall<IsOffMeshConnectionActiveDelegate>("UnityEngine.AI.NavMesh::IsOffMeshConnectionActive");
		SetOffMeshConnectionActiveDelegateField = IL2CPP.ResolveICall<SetOffMeshConnectionActiveDelegate>("UnityEngine.AI.NavMesh::SetOffMeshConnectionActive");
		RemoveSettingsDelegateField = IL2CPP.ResolveICall<RemoveSettingsDelegate>("UnityEngine.AI.NavMesh::RemoveSettings");
		GetSettingsCountDelegateField = IL2CPP.ResolveICall<GetSettingsCountDelegate>("UnityEngine.AI.NavMesh::GetSettingsCount");
		RemoveAllNavMeshDataDelegateField = IL2CPP.ResolveICall<RemoveAllNavMeshDataDelegate>("UnityEngine.AI.NavMesh::RemoveAllNavMeshData");
		CalculatePathInternal_InjectedDelegateField = IL2CPP.ResolveICall<CalculatePathInternal_InjectedDelegate>("UnityEngine.AI.NavMesh::CalculatePathInternal_Injected");
		GetNavMeshLayerFromName_InjectedDelegateField = IL2CPP.ResolveICall<GetNavMeshLayerFromName_InjectedDelegate>("UnityEngine.AI.NavMesh::GetNavMeshLayerFromName_Injected");
		GetAreaFromName_InjectedDelegateField = IL2CPP.ResolveICall<GetAreaFromName_InjectedDelegate>("UnityEngine.AI.NavMesh::GetAreaFromName_Injected");
		InternalGetOwner_InjectedDelegateField = IL2CPP.ResolveICall<InternalGetOwner_InjectedDelegate>("UnityEngine.AI.NavMesh::InternalGetOwner_Injected");
		InternalGetLinkOwner_InjectedDelegateField = IL2CPP.ResolveICall<InternalGetLinkOwner_InjectedDelegate>("UnityEngine.AI.NavMesh::InternalGetLinkOwner_Injected");
		AddNavMeshDataInternal_InjectedDelegateField = IL2CPP.ResolveICall<AddNavMeshDataInternal_InjectedDelegate>("UnityEngine.AI.NavMesh::AddNavMeshDataInternal_Injected");
		AddNavMeshDataTransformedInternal_InjectedDelegateField = IL2CPP.ResolveICall<AddNavMeshDataTransformedInternal_InjectedDelegate>("UnityEngine.AI.NavMesh::AddNavMeshDataTransformedInternal_Injected");
		CalculatePathFilterInternal_InjectedDelegateField = IL2CPP.ResolveICall<CalculatePathFilterInternal_InjectedDelegate>("UnityEngine.AI.NavMesh::CalculatePathFilterInternal_Injected");
		GetSettingsNameFromID_InjectedDelegateField = IL2CPP.ResolveICall<GetSettingsNameFromID_InjectedDelegate>("UnityEngine.AI.NavMesh::GetSettingsNameFromID_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148275, XrefRangeEnd = 1148279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearPreUpdateListeners()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearPreUpdateListeners_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148279, XrefRangeEnd = 1148281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CallOnNavMeshPreUpdate()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CallOnNavMeshPreUpdate_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NavMesh(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
	{
		path.ClearCorners();
		return CalculatePathInternal(sourcePosition, targetPosition, areaMask, path);
	}

	public static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path)
	{
		return CalculatePathInternal_Injected(ref sourcePosition, ref targetPosition, areaMask, (path == null) ? ((System.IntPtr)0) : NavMeshPath.BindingsMarshaller.ConvertToNative(path));
	}

	public static void SetLayerCost(int layer, float cost)
	{
		SetLayerCostDelegateField(layer, cost);
	}

	public static float GetLayerCost(int layer)
	{
		return GetLayerCostDelegateField(layer);
	}

	public unsafe static int GetNavMeshLayerFromName(string layerName)
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
					return GetNavMeshLayerFromName_Injected(ref managedSpanWrapper);
				}
			}
			return GetNavMeshLayerFromName_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void SetAreaCost(int areaIndex, float cost)
	{
		SetAreaCostDelegateField(areaIndex, cost);
	}

	public static float GetAreaCost(int areaIndex)
	{
		return GetAreaCostDelegateField(areaIndex);
	}

	public unsafe static int GetAreaFromName(string areaName)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(areaName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(areaName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetAreaFromName_Injected(ref managedSpanWrapper);
				}
			}
			return GetAreaFromName_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static Il2CppStringArray GetAreaNames()
	{
		System.IntPtr intPtr = GetAreaNamesDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static void Triangulate(out Il2CppStructArray<Vector3> vertices, out Il2CppStructArray<int> indices)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void AddOffMeshLinks()
	{
	}

	public static void RestoreNavMesh()
	{
	}

	public static bool IsValidNavMeshDataHandle(int handle)
	{
		return IsValidNavMeshDataHandleDelegateField(handle);
	}

	public static bool IsValidLinkHandle(int handle)
	{
		return IsValidLinkHandleDelegateField(handle);
	}

	public static Object InternalGetOwner(int dataID)
	{
		return Unmarshal.UnmarshalUnityObject<Object>(InternalGetOwner_Injected(dataID));
	}

	public static bool InternalSetOwner(int dataID, int ownerID)
	{
		return InternalSetOwnerDelegateField(dataID, ownerID);
	}

	public static Object InternalGetLinkOwner(int linkID)
	{
		return Unmarshal.UnmarshalUnityObject<Object>(InternalGetLinkOwner_Injected(linkID));
	}

	public static bool InternalSetLinkOwner(int linkID, int ownerID)
	{
		return InternalSetLinkOwnerDelegateField(linkID, ownerID);
	}

	public static int AddNavMeshDataInternal(NavMeshData navMeshData)
	{
		return AddNavMeshDataInternal_Injected(Object.MarshalledUnityObject.Marshal(navMeshData));
	}

	public static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation)
	{
		return AddNavMeshDataTransformedInternal_Injected(Object.MarshalledUnityObject.Marshal(navMeshData), ref position, ref rotation);
	}

	public static void RemoveNavMeshDataInternal(int handle)
	{
		RemoveNavMeshDataInternalDelegateField(handle);
	}

	public static void RemoveLinkInternal(int handle)
	{
		RemoveLinkInternalDelegateField(handle);
	}

	public static bool IsOffMeshConnectionOccupied(int handle)
	{
		return IsOffMeshConnectionOccupiedDelegateField(handle);
	}

	public static bool IsOffMeshConnectionActive(int linkHandle)
	{
		return IsOffMeshConnectionActiveDelegateField(linkHandle);
	}

	public static void SetOffMeshConnectionActive(int linkHandle, bool activated)
	{
		SetOffMeshConnectionActiveDelegateField(linkHandle, activated);
	}

	public unsafe static bool CalculatePathFilterInternal(Vector3 sourcePosition, Vector3 targetPosition, NavMeshPath path, int type, int mask, Il2CppStructArray<float> costs)
	{
		//IL_001f: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//IL_0032: Expected O, but got Ref
		System.IntPtr path2 = ((path == null) ? ((System.IntPtr)0) : NavMeshPath.BindingsMarshaller.ConvertToNative(path));
		Unsafe.SkipInit(out Il2CppSystem.Span<float> span);
		((Il2CppSystem.Span<float>)(&span))._002Ector((Il2CppArrayBase<float>)(object)costs);
		bool result;
		fixed (float* begin = &((Il2CppSystem.Span<float>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper costs2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<float>)(&span)).Length);
			result = CalculatePathFilterInternal_Injected(ref sourcePosition, ref targetPosition, path2, type, mask, ref costs2);
		}
		return result;
	}

	public static void RemoveSettings(int agentTypeID)
	{
		RemoveSettingsDelegateField(agentTypeID);
	}

	public static int GetSettingsCount()
	{
		return GetSettingsCountDelegateField();
	}

	public static string GetSettingsNameFromID(int agentTypeID)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetSettingsNameFromID_Injected(agentTypeID, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static void RemoveAllNavMeshData()
	{
		RemoveAllNavMeshDataDelegateField();
	}

	public unsafe static bool CalculatePathInternal_Injected([In] ref Vector3 sourcePosition, [In] ref Vector3 targetPosition, int areaMask, System.IntPtr path)
	{
		return CalculatePathInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref sourcePosition), (nint)Unsafe.AsPointer(ref targetPosition), areaMask, path);
	}

	public unsafe static int GetNavMeshLayerFromName_Injected(ref ManagedSpanWrapper layerName)
	{
		return GetNavMeshLayerFromName_InjectedDelegateField((nint)Unsafe.AsPointer(ref layerName));
	}

	public unsafe static int GetAreaFromName_Injected(ref ManagedSpanWrapper areaName)
	{
		return GetAreaFromName_InjectedDelegateField((nint)Unsafe.AsPointer(ref areaName));
	}

	public static System.IntPtr InternalGetOwner_Injected(int dataID)
	{
		return InternalGetOwner_InjectedDelegateField(dataID);
	}

	public static System.IntPtr InternalGetLinkOwner_Injected(int linkID)
	{
		return InternalGetLinkOwner_InjectedDelegateField(linkID);
	}

	public static int AddNavMeshDataInternal_Injected(System.IntPtr navMeshData)
	{
		return AddNavMeshDataInternal_InjectedDelegateField(navMeshData);
	}

	public unsafe static int AddNavMeshDataTransformedInternal_Injected(System.IntPtr navMeshData, [In] ref Vector3 position, [In] ref Quaternion rotation)
	{
		return AddNavMeshDataTransformedInternal_InjectedDelegateField(navMeshData, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref rotation));
	}

	public unsafe static bool CalculatePathFilterInternal_Injected([In] ref Vector3 sourcePosition, [In] ref Vector3 targetPosition, System.IntPtr path, int type, int mask, ref ManagedSpanWrapper costs)
	{
		return CalculatePathFilterInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref sourcePosition), (nint)Unsafe.AsPointer(ref targetPosition), path, type, mask, (nint)Unsafe.AsPointer(ref costs));
	}

	public unsafe static void GetSettingsNameFromID_Injected(int agentTypeID, out ManagedSpanWrapper ret)
	{
		GetSettingsNameFromID_InjectedDelegateField(agentTypeID, (nint)Unsafe.AsPointer(ref ret));
	}
}
