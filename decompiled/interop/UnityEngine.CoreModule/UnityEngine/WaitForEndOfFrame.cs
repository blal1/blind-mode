using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine;

public sealed class WaitForEndOfFrame : YieldInstruction
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static WaitForEndOfFrame()
	{
		Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForEndOfFrame");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr, 100666581);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitForEndOfFrame()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public WaitForEndOfFrame(IntPtr pointer)
		: base(pointer)
	{
	}
}
