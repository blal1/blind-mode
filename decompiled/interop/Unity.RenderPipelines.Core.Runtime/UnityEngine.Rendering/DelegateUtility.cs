using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class DelegateUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Cast_Public_Static_Delegate_Delegate_Type_0;

	static DelegateUtility()
	{
		Il2CppClassPointerStore<DelegateUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DelegateUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateUtility>.NativeClassPtr);
		NativeMethodInfoPtr_Cast_Public_Static_Delegate_Delegate_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateUtility>.NativeClassPtr, 100666676);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052712, XrefRangeEnd = 1052721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Delegate Cast(Il2CppSystem.Delegate source, Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cast_Public_Static_Delegate_Delegate_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Delegate>(intPtr2) : null;
	}

	public DelegateUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
