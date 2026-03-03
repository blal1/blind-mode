using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;

namespace UnityEngineInternal;

public class GenericStack : Stack
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static GenericStack()
	{
		Il2CppClassPointerStore<GenericStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngineInternal", "GenericStack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericStack>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericStack>.NativeClassPtr, 100663304);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1163740, RefRangeEnd = 1163742, XrefRangeStart = 1163739, XrefRangeEnd = 1163740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GenericStack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericStack>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GenericStack(IntPtr pointer)
		: base(pointer)
	{
	}
}
