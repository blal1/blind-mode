using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct LoadSceneParameters
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_LoadSceneMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalPhysicsMode;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0;

	[FieldOffset(0)]
	public LoadSceneMode m_LoadSceneMode;

	[FieldOffset(4)]
	public LocalPhysicsMode m_LocalPhysicsMode;

	public LoadSceneMode loadSceneMode
	{
		get
		{
			return m_LoadSceneMode;
		}
		set
		{
			m_LoadSceneMode = value;
		}
	}

	public LocalPhysicsMode localPhysicsMode
	{
		get
		{
			return m_LocalPhysicsMode;
		}
		set
		{
			m_LocalPhysicsMode = value;
		}
	}

	static LoadSceneParameters()
	{
		Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "LoadSceneParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr);
		NativeFieldInfoPtr_m_LoadSceneMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, "m_LoadSceneMode");
		NativeFieldInfoPtr_m_LocalPhysicsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, "m_LocalPhysicsMode");
		NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, 100667282);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1228605, RefRangeEnd = 1228607, XrefRangeStart = 1228605, XrefRangeEnd = 1228605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoadSceneParameters(LoadSceneMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
