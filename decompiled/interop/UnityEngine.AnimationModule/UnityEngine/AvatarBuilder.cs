using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class AvatarBuilder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_BuildHumanAvatar_Public_Static_Avatar_GameObject_HumanDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildHumanAvatarInternal_Private_Static_Avatar_GameObject_HumanDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildGenericAvatar_Public_Static_Avatar_GameObject_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildHumanAvatarInternal_Injected_Private_Static_IntPtr_IntPtr_byref_HumanDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildGenericAvatar_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0;

	static AvatarBuilder()
	{
		Il2CppClassPointerStore<AvatarBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AvatarBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarBuilder>.NativeClassPtr);
		NativeMethodInfoPtr_BuildHumanAvatar_Public_Static_Avatar_GameObject_HumanDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarBuilder>.NativeClassPtr, 100664115);
		NativeMethodInfoPtr_BuildHumanAvatarInternal_Private_Static_Avatar_GameObject_HumanDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarBuilder>.NativeClassPtr, 100664116);
		NativeMethodInfoPtr_BuildGenericAvatar_Public_Static_Avatar_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarBuilder>.NativeClassPtr, 100664117);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarBuilder>.NativeClassPtr, 100664118);
		NativeMethodInfoPtr_BuildHumanAvatarInternal_Injected_Private_Static_IntPtr_IntPtr_byref_HumanDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarBuilder>.NativeClassPtr, 100664119);
		NativeMethodInfoPtr_BuildGenericAvatar_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarBuilder>.NativeClassPtr, 100664120);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157048, XrefRangeEnd = 1157060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Avatar BuildHumanAvatar(GameObject go, HumanDescription humanDescription)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)humanDescription));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildHumanAvatar_Public_Static_Avatar_GameObject_HumanDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157060, XrefRangeEnd = 1157068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Avatar BuildHumanAvatarInternal(GameObject go, HumanDescription humanDescription)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)humanDescription));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildHumanAvatarInternal_Private_Static_Avatar_GameObject_HumanDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157068, XrefRangeEnd = 1157095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Avatar BuildGenericAvatar(GameObject go, string rootMotionTransformName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rootMotionTransformName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildGenericAvatar_Public_Static_Avatar_GameObject_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AvatarBuilder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarBuilder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157095, XrefRangeEnd = 1157097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr BuildHumanAvatarInternal_Injected(System.IntPtr go, [In] ref HumanDescription humanDescription)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)humanDescription);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildHumanAvatarInternal_Injected_Private_Static_IntPtr_IntPtr_byref_HumanDescription_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157097, XrefRangeEnd = 1157099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr BuildGenericAvatar_Injected(System.IntPtr go, ref ManagedSpanWrapper rootMotionTransformName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&go);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rootMotionTransformName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildGenericAvatar_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AvatarBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
