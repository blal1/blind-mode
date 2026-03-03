using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.Universal;

public class DecalDrawScreenSpaceSystem : DecalDrawSystem
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0;

	static DecalDrawScreenSpaceSystem()
	{
		Il2CppClassPointerStore<DecalDrawScreenSpaceSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalDrawScreenSpaceSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalDrawScreenSpaceSystem>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawScreenSpaceSystem>.NativeClassPtr, 100664166);
		NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalDrawScreenSpaceSystem>.NativeClassPtr, 100664167);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1083110, RefRangeEnd = 1083111, XrefRangeStart = 1083104, XrefRangeEnd = 1083110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalDrawScreenSpaceSystem(DecalEntityManager entityManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalDrawScreenSpaceSystem>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entityManager);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DecalEntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override int GetPassIndex(DecalCachedChunk decalCachedChunk)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decalCachedChunk);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetPassIndex_Protected_Virtual_Int32_DecalCachedChunk_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DecalDrawScreenSpaceSystem(IntPtr pointer)
		: base(pointer)
	{
	}
}
