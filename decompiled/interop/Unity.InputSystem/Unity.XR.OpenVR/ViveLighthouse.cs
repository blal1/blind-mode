using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.InputSystem;

namespace Unity.XR.OpenVR;

public class ViveLighthouse : TrackedDevice
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ViveLighthouse()
	{
		Il2CppClassPointerStore<ViveLighthouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "Unity.XR.OpenVR", "ViveLighthouse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViveLighthouse>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViveLighthouse>.NativeClassPtr, 100663364);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 962989, RefRangeEnd = 963003, XrefRangeStart = 962988, XrefRangeEnd = 962989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ViveLighthouse()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViveLighthouse>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ViveLighthouse(IntPtr pointer)
		: base(pointer)
	{
	}
}
