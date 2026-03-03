using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.U2D.Animation;

public static class SpriteSkinHelpers : Il2CppSystem.Object
{
	[ObfuscatedName("UnityEngine.U2D.Animation.SpriteSkinHelpers+<>c__DisplayClass2_0")]
	public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_boneHash;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetSpriteBonesTransforms_b__0_Internal_Boolean_Bone_0;

		public unsafe string boneHash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneHash);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boneHash)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static __c__DisplayClass2_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteSkinHelpers>.NativeClassPtr, "<>c__DisplayClass2_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr);
			NativeFieldInfoPtr_boneHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, "boneHash");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, 100663725);
			NativeMethodInfoPtr__GetSpriteBonesTransforms_b__0_Internal_Boolean_Bone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr, 100663726);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass2_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass2_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetSpriteBonesTransforms_b__0(Bone x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetSpriteBonesTransforms_b__0_Internal_Boolean_Bone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c__DisplayClass2_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheChildren_Public_Static_Void_Transform_Dictionary_2_Int32_List_1_TransformData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTransformPath_Public_Static_String_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteBonesTransforms_Public_Static_Boolean_SpriteSkin_byref_Il2CppReferenceArray_1_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteBonesTransformFromPath_Private_Static_Boolean_Il2CppReferenceArray_1_SpriteBone_Dictionary_2_Int32_List_1_TransformData_Il2CppReferenceArray_1_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateBoneTransformsPath_Private_Static_Void_Int32_Il2CppReferenceArray_1_SpriteBone_Il2CppStringArray_0;

	static SpriteSkinHelpers()
	{
		Il2CppClassPointerStore<SpriteSkinHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "SpriteSkinHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteSkinHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_CacheChildren_Public_Static_Void_Transform_Dictionary_2_Int32_List_1_TransformData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinHelpers>.NativeClassPtr, 100663720);
		NativeMethodInfoPtr_GenerateTransformPath_Public_Static_String_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinHelpers>.NativeClassPtr, 100663721);
		NativeMethodInfoPtr_GetSpriteBonesTransforms_Public_Static_Boolean_SpriteSkin_byref_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinHelpers>.NativeClassPtr, 100663722);
		NativeMethodInfoPtr_GetSpriteBonesTransformFromPath_Private_Static_Boolean_Il2CppReferenceArray_1_SpriteBone_Dictionary_2_Int32_List_1_TransformData_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinHelpers>.NativeClassPtr, 100663723);
		NativeMethodInfoPtr_CalculateBoneTransformsPath_Private_Static_Void_Int32_Il2CppReferenceArray_1_SpriteBone_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinHelpers>.NativeClassPtr, 100663724);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 957853, RefRangeEnd = 957855, XrefRangeStart = 957823, XrefRangeEnd = 957853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CacheChildren(Transform current, Dictionary<int, List<SpriteSkin.TransformData>> cache)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)current);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cache);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheChildren_Public_Static_Void_Transform_Dictionary_2_Int32_List_1_TransformData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 957872, RefRangeEnd = 957873, XrefRangeStart = 957855, XrefRangeEnd = 957872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GenerateTransformPath(Transform rootBone, Transform child)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rootBone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)child);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateTransformPath_Public_Static_String_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 957916, RefRangeEnd = 957917, XrefRangeStart = 957873, XrefRangeEnd = 957916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetSpriteBonesTransforms(SpriteSkin spriteSkin, out Il2CppReferenceArray<Transform> outTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpriteBonesTransforms_Public_Static_Boolean_SpriteSkin_byref_Il2CppReferenceArray_1_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		outTransform = ((num3 == 0) ? null : new Il2CppReferenceArray<Transform>((System.IntPtr)num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957917, XrefRangeEnd = 957952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetSpriteBonesTransformFromPath(Il2CppReferenceArray<SpriteBone> spriteBones, Dictionary<int, List<SpriteSkin.TransformData>> hierarchyCache, Il2CppReferenceArray<Transform> outNewBoneTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteBones);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hierarchyCache);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outNewBoneTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpriteBonesTransformFromPath_Private_Static_Boolean_Il2CppReferenceArray_1_SpriteBone_Dictionary_2_Int32_List_1_TransformData_Il2CppReferenceArray_1_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 957956, RefRangeEnd = 957957, XrefRangeStart = 957952, XrefRangeEnd = 957956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalculateBoneTransformsPath(int index, Il2CppReferenceArray<SpriteBone> spriteBones, Il2CppStringArray paths)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteBones);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paths);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateBoneTransformsPath_Private_Static_Void_Int32_Il2CppReferenceArray_1_SpriteBone_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpriteSkinHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
