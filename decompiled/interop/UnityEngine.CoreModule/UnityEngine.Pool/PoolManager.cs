using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Pool;

public static class PoolManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_WeakPoolReferences;

	private static readonly System.IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0;

	public unsafe static List<Il2CppSystem.WeakReference<IPool>> s_WeakPoolReferences
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_WeakPoolReferences, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.WeakReference<IPool>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_WeakPoolReferences, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static PoolManager()
	{
		Il2CppClassPointerStore<PoolManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "PoolManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_WeakPoolReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, "s_WeakPoolReferences");
		NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolManager>.NativeClassPtr, 100667319);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1229058, RefRangeEnd = 1229059, XrefRangeStart = 1229032, XrefRangeEnd = 1229058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Register(IPool pool)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pool);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Register_Public_Static_Void_IPool_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PoolManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void Reset()
	{
		for (int num = s_WeakPoolReferences.Count - 1; num >= 0; num--)
		{
			if (s_WeakPoolReferences[num].TryGetTarget(out var target))
			{
				target.Clear();
			}
			else
			{
				s_WeakPoolReferences.RemoveAt(num);
			}
		}
	}
}
