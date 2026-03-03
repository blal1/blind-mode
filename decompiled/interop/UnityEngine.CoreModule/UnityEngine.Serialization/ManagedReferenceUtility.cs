using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Serialization;

public sealed class ManagedReferenceUtility
{
	private delegate bool SetManagedReferenceIdForObjectInternal_InjectedDelegate(System.IntPtr obj, System.IntPtr scriptObj, long refId);

	private delegate long GetManagedReferenceIdForObjectInternal_InjectedDelegate(System.IntPtr obj, System.IntPtr scriptObj);

	private delegate System.IntPtr GetManagedReferenceInternal_InjectedDelegate(System.IntPtr obj, long id);

	private delegate void GetManagedReferenceIdsForObjectInternal_InjectedDelegate(System.IntPtr obj, [Out] System.IntPtr ret);

	public const long RefIdUnknown = -1L;

	public const long RefIdNull = -2L;

	private static readonly SetManagedReferenceIdForObjectInternal_InjectedDelegate SetManagedReferenceIdForObjectInternal_InjectedDelegateField = IL2CPP.ResolveICall<SetManagedReferenceIdForObjectInternal_InjectedDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::SetManagedReferenceIdForObjectInternal_Injected");

	private static readonly GetManagedReferenceIdForObjectInternal_InjectedDelegate GetManagedReferenceIdForObjectInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetManagedReferenceIdForObjectInternal_InjectedDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceIdForObjectInternal_Injected");

	private static readonly GetManagedReferenceInternal_InjectedDelegate GetManagedReferenceInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetManagedReferenceInternal_InjectedDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceInternal_Injected");

	private static readonly GetManagedReferenceIdsForObjectInternal_InjectedDelegate GetManagedReferenceIdsForObjectInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetManagedReferenceIdsForObjectInternal_InjectedDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceIdsForObjectInternal_Injected");

	public static bool SetManagedReferenceIdForObjectInternal(Object obj, Il2CppSystem.Object scriptObj, long refId)
	{
		return SetManagedReferenceIdForObjectInternal_Injected(Object.MarshalledUnityObject.Marshal(obj), scriptObj, refId);
	}

	public static bool SetManagedReferenceIdForObject(Object obj, Il2CppSystem.Object scriptObj, long refId)
	{
		if (scriptObj == null)
		{
			return refId == -2;
		}
		Il2CppSystem.Type type = scriptObj.GetType();
		if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()) || type.IsSubclassOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>())))
		{
			throw new Il2CppSystem.InvalidOperationException("Cannot assign an object deriving from UnityEngine.Object to a managed reference. This is not supported.");
		}
		return SetManagedReferenceIdForObjectInternal(obj, scriptObj, refId);
	}

	public static long GetManagedReferenceIdForObjectInternal(Object obj, Il2CppSystem.Object scriptObj)
	{
		return GetManagedReferenceIdForObjectInternal_Injected(Object.MarshalledUnityObject.Marshal(obj), scriptObj);
	}

	public static long GetManagedReferenceIdForObject(Object obj, Il2CppSystem.Object scriptObj)
	{
		return GetManagedReferenceIdForObjectInternal(obj, scriptObj);
	}

	public static Il2CppSystem.Object GetManagedReferenceInternal(Object obj, long id)
	{
		return GetManagedReferenceInternal_Injected(Object.MarshalledUnityObject.Marshal(obj), id);
	}

	public static Il2CppSystem.Object GetManagedReference(Object obj, long id)
	{
		return GetManagedReferenceInternal(obj, id);
	}

	public unsafe static Il2CppStructArray<long> GetManagedReferenceIdsForObjectInternal(Object obj)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<long> result;
		try
		{
			GetManagedReferenceIdsForObjectInternal_Injected(Object.MarshalledUnityObject.Marshal(obj), out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<long> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<long>*)(&array));
			result = array;
		}
		return result;
	}

	public static Il2CppStructArray<long> GetManagedReferenceIds(Object obj)
	{
		return GetManagedReferenceIdsForObjectInternal(obj);
	}

	public static bool SetManagedReferenceIdForObjectInternal_Injected(System.IntPtr obj, Il2CppSystem.Object scriptObj, long refId)
	{
		return SetManagedReferenceIdForObjectInternal_InjectedDelegateField(obj, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scriptObj), refId);
	}

	public static long GetManagedReferenceIdForObjectInternal_Injected(System.IntPtr obj, Il2CppSystem.Object scriptObj)
	{
		return GetManagedReferenceIdForObjectInternal_InjectedDelegateField(obj, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scriptObj));
	}

	public static Il2CppSystem.Object GetManagedReferenceInternal_Injected(System.IntPtr obj, long id)
	{
		System.IntPtr intPtr = GetManagedReferenceInternal_InjectedDelegateField(obj, id);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public unsafe static void GetManagedReferenceIdsForObjectInternal_Injected(System.IntPtr obj, out BlittableArrayWrapper ret)
	{
		GetManagedReferenceIdsForObjectInternal_InjectedDelegateField(obj, (nint)Unsafe.AsPointer(ref ret));
	}
}
