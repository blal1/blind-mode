using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppSpine.Unity;

public static class ISpineComponentExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_IsNullOrDestroyed_Public_Static_Boolean_ISpineComponent_0;

	static ISpineComponentExtensions()
	{
		Il2CppClassPointerStore<ISpineComponentExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "ISpineComponentExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISpineComponentExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_IsNullOrDestroyed_Public_Static_Boolean_ISpineComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISpineComponentExtensions>.NativeClassPtr, 100664028);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 856683, RefRangeEnd = 856690, XrefRangeStart = 856678, XrefRangeEnd = 856683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsNullOrDestroyed(this ISpineComponent component)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNullOrDestroyed_Public_Static_Boolean_ISpineComponent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ISpineComponentExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
