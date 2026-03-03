using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.AI;

public sealed class NavMeshPath
{
	public static class BindingsMarshaller
	{
	}

	private delegate System.IntPtr InitializeNavMeshPathDelegate();

	private delegate void DestroyNavMeshPathDelegate(System.IntPtr ptr);

	private delegate int GetCornersNonAlloc_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr results);

	private delegate void CalculateCornersInternal_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void ClearCornersInternal_InjectedDelegate(System.IntPtr _unity_self);

	private delegate NavMeshPathStatus get_status_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly InitializeNavMeshPathDelegate InitializeNavMeshPathDelegateField = IL2CPP.ResolveICall<InitializeNavMeshPathDelegate>("UnityEngine.AI.NavMeshPath::InitializeNavMeshPath");

	private static readonly DestroyNavMeshPathDelegate DestroyNavMeshPathDelegateField = IL2CPP.ResolveICall<DestroyNavMeshPathDelegate>("UnityEngine.AI.NavMeshPath::DestroyNavMeshPath");

	private static readonly GetCornersNonAlloc_InjectedDelegate GetCornersNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<GetCornersNonAlloc_InjectedDelegate>("UnityEngine.AI.NavMeshPath::GetCornersNonAlloc_Injected");

	private static readonly CalculateCornersInternal_InjectedDelegate CalculateCornersInternal_InjectedDelegateField = IL2CPP.ResolveICall<CalculateCornersInternal_InjectedDelegate>("UnityEngine.AI.NavMeshPath::CalculateCornersInternal_Injected");

	private static readonly ClearCornersInternal_InjectedDelegate ClearCornersInternal_InjectedDelegateField = IL2CPP.ResolveICall<ClearCornersInternal_InjectedDelegate>("UnityEngine.AI.NavMeshPath::ClearCornersInternal_Injected");

	private static readonly get_status_InjectedDelegate get_status_InjectedDelegateField = IL2CPP.ResolveICall<get_status_InjectedDelegate>("UnityEngine.AI.NavMeshPath::get_status_Injected");

	public Il2CppStructArray<Vector3> corners
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public NavMeshPathStatus status
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			return get_status_Injected(intPtr);
		}
	}

	~NavMeshPath()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static System.IntPtr InitializeNavMeshPath()
	{
		return InitializeNavMeshPathDelegateField();
	}

	public static void DestroyNavMeshPath(System.IntPtr ptr)
	{
		DestroyNavMeshPathDelegateField(ptr);
	}

	public int GetCornersNonAlloc([Out] Il2CppStructArray<Vector3> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe Il2CppStructArray<Vector3> CalculateCornersInternal()
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Vector3> result;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			CalculateCornersInternal_Injected(intPtr, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Vector3> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Vector3>*)(&array));
			result = array;
		}
		return result;
	}

	public void ClearCornersInternal()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		ClearCornersInternal_Injected(intPtr);
	}

	public void ClearCorners()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void CalculateCorners()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static int GetCornersNonAlloc_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper results)
	{
		return GetCornersNonAlloc_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static void CalculateCornersInternal_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		CalculateCornersInternal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void ClearCornersInternal_Injected(System.IntPtr _unity_self)
	{
		ClearCornersInternal_InjectedDelegateField(_unity_self);
	}

	public static NavMeshPathStatus get_status_Injected(System.IntPtr _unity_self)
	{
		return get_status_InjectedDelegateField(_unity_self);
	}
}
