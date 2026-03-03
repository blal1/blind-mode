using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppSpine.Unity;

public class SkeletonDataModifierAsset : ScriptableObject
{
	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_Void_SkeletonData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static SkeletonDataModifierAsset()
	{
		Il2CppClassPointerStore<SkeletonDataModifierAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "SkeletonDataModifierAsset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkeletonDataModifierAsset>.NativeClassPtr);
		NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_Void_SkeletonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonDataModifierAsset>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonDataModifierAsset>.NativeClassPtr, 100663416);
	}

	[CallerCount(0)]
	public unsafe virtual void Apply(SkeletonData skeletonData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeletonData);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Apply_Public_Abstract_Virtual_New_Void_SkeletonData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 26528, RefRangeEnd = 26564, XrefRangeStart = 26528, XrefRangeEnd = 26564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkeletonDataModifierAsset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkeletonDataModifierAsset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SkeletonDataModifierAsset(IntPtr pointer)
		: base(pointer)
	{
	}
}
