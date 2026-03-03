using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public class ScriptingRuntime : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0;

	static ScriptingRuntime()
	{
		Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptingRuntime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr);
		NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr, 100666466);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1204064, RefRangeEnd = 1204066, XrefRangeStart = 1204062, XrefRangeEnd = 1204064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetAllUserAssemblies()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	public ScriptingRuntime(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
