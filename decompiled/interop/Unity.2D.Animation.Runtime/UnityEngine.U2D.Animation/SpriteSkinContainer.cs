using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.U2D.Animation;

public class SpriteSkinContainer : ScriptableObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr_onAddedSpriteSkin;

	private static readonly System.IntPtr NativeFieldInfoPtr_onRemovedSpriteSkin;

	private static readonly System.IntPtr NativeFieldInfoPtr_onBoneTransformChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteSkin;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onAddedSpriteSkin_Public_Static_add_Void_Action_1_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onAddedSpriteSkin_Public_Static_rem_Void_Action_1_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onRemovedSpriteSkin_Public_Static_add_Void_Action_1_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onRemovedSpriteSkin_Public_Static_rem_Void_Action_1_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onBoneTransformChanged_Public_Static_add_Void_Action_1_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onBoneTransformChanged_Public_Static_rem_Void_Action_1_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_SpriteSkinContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteSkins_Public_get_IReadOnlyList_1_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSpriteSkin_Public_Void_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSpriteSkin_Public_Void_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BoneTransformsChanged_Public_Void_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppSystem.Action<SpriteSkin> onAddedSpriteSkin
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onAddedSpriteSkin, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<SpriteSkin>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onAddedSpriteSkin, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<SpriteSkin> onRemovedSpriteSkin
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onRemovedSpriteSkin, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<SpriteSkin>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onRemovedSpriteSkin, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<SpriteSkin> onBoneTransformChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onBoneTransformChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<SpriteSkin>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onBoneTransformChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static SpriteSkinContainer s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpriteSkinContainer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<SpriteSkin> m_SpriteSkin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSkin);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SpriteSkin>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSkin)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static SpriteSkinContainer instance
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 957798, RefRangeEnd = 957801, XrefRangeStart = 957779, XrefRangeEnd = 957798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_SpriteSkinContainer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpriteSkinContainer>(intPtr2) : null;
		}
	}

	public unsafe IReadOnlyList<SpriteSkin> spriteSkins
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spriteSkins_Public_get_IReadOnlyList_1_SpriteSkin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IReadOnlyList<SpriteSkin>>(intPtr2) : null;
		}
	}

	static SpriteSkinContainer()
	{
		Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "SpriteSkinContainer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr);
		NativeFieldInfoPtr_onAddedSpriteSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, "onAddedSpriteSkin");
		NativeFieldInfoPtr_onRemovedSpriteSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, "onRemovedSpriteSkin");
		NativeFieldInfoPtr_onBoneTransformChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, "onBoneTransformChanged");
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_m_SpriteSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, "m_SpriteSkin");
		NativeMethodInfoPtr_add_onAddedSpriteSkin_Public_Static_add_Void_Action_1_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663708);
		NativeMethodInfoPtr_remove_onAddedSpriteSkin_Public_Static_rem_Void_Action_1_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663709);
		NativeMethodInfoPtr_add_onRemovedSpriteSkin_Public_Static_add_Void_Action_1_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663710);
		NativeMethodInfoPtr_remove_onRemovedSpriteSkin_Public_Static_rem_Void_Action_1_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663711);
		NativeMethodInfoPtr_add_onBoneTransformChanged_Public_Static_add_Void_Action_1_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663712);
		NativeMethodInfoPtr_remove_onBoneTransformChanged_Public_Static_rem_Void_Action_1_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663713);
		NativeMethodInfoPtr_get_instance_Public_Static_get_SpriteSkinContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663714);
		NativeMethodInfoPtr_get_spriteSkins_Public_get_IReadOnlyList_1_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663715);
		NativeMethodInfoPtr_AddSpriteSkin_Public_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663716);
		NativeMethodInfoPtr_RemoveSpriteSkin_Public_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663717);
		NativeMethodInfoPtr_BoneTransformsChanged_Public_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663718);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr, 100663719);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957727, XrefRangeEnd = 957735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onAddedSpriteSkin(Il2CppSystem.Action<SpriteSkin> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onAddedSpriteSkin_Public_Static_add_Void_Action_1_SpriteSkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957735, XrefRangeEnd = 957743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onAddedSpriteSkin(Il2CppSystem.Action<SpriteSkin> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onAddedSpriteSkin_Public_Static_rem_Void_Action_1_SpriteSkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957743, XrefRangeEnd = 957752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onRemovedSpriteSkin(Il2CppSystem.Action<SpriteSkin> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onRemovedSpriteSkin_Public_Static_add_Void_Action_1_SpriteSkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957752, XrefRangeEnd = 957761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onRemovedSpriteSkin(Il2CppSystem.Action<SpriteSkin> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onRemovedSpriteSkin_Public_Static_rem_Void_Action_1_SpriteSkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957761, XrefRangeEnd = 957770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onBoneTransformChanged(Il2CppSystem.Action<SpriteSkin> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onBoneTransformChanged_Public_Static_add_Void_Action_1_SpriteSkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957770, XrefRangeEnd = 957779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onBoneTransformChanged(Il2CppSystem.Action<SpriteSkin> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onBoneTransformChanged_Public_Static_rem_Void_Action_1_SpriteSkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957801, XrefRangeEnd = 957808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddSpriteSkin(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSpriteSkin_Public_Void_SpriteSkin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957808, XrefRangeEnd = 957813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveSpriteSkin(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSpriteSkin_Public_Void_SpriteSkin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957813, XrefRangeEnd = 957815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BoneTransformsChanged(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BoneTransformsChanged_Public_Void_SpriteSkin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957815, XrefRangeEnd = 957823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpriteSkinContainer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteSkinContainer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpriteSkinContainer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
