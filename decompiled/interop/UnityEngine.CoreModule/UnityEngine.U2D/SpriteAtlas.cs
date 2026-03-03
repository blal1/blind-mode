using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.U2D;

public class SpriteAtlas : Object
{
	private delegate bool get_isVariant_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_tag_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate int GetSpritesWithNameScripting_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr sprites, System.IntPtr name);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSprites_Public_Int32_Il2CppReferenceArray_1_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpritesScripting_Private_Int32_Il2CppReferenceArray_1_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanBindTo_Injected_Private_Static_Boolean_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSprite_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpritesScripting_Injected_Private_Static_Int32_IntPtr_Il2CppReferenceArray_1_Sprite_0;

	private static readonly get_isVariant_InjectedDelegate get_isVariant_InjectedDelegateField;

	private static readonly get_tag_InjectedDelegate get_tag_InjectedDelegateField;

	private static readonly GetSpritesWithNameScripting_InjectedDelegate GetSpritesWithNameScripting_InjectedDelegateField;

	public unsafe int spriteCount
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1241799, RefRangeEnd = 1241802, XrefRangeStart = 1241794, XrefRangeEnd = 1241799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spriteCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public bool isVariant
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isVariant_Injected(intPtr);
		}
	}

	public string tag
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_tag_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	static SpriteAtlas()
	{
		Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteAtlas");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr);
		NativeMethodInfoPtr_get_spriteCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100669048);
		NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100669049);
		NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100669050);
		NativeMethodInfoPtr_GetSprites_Public_Int32_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100669051);
		NativeMethodInfoPtr_GetSpritesScripting_Private_Int32_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100669052);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100669053);
		NativeMethodInfoPtr_get_spriteCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100669054);
		NativeMethodInfoPtr_CanBindTo_Injected_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100669055);
		NativeMethodInfoPtr_GetSprite_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100669056);
		NativeMethodInfoPtr_GetSpritesScripting_Injected_Private_Static_Int32_IntPtr_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100669057);
		get_isVariant_InjectedDelegateField = IL2CPP.ResolveICall<get_isVariant_InjectedDelegate>("UnityEngine.U2D.SpriteAtlas::get_isVariant_Injected");
		get_tag_InjectedDelegateField = IL2CPP.ResolveICall<get_tag_InjectedDelegate>("UnityEngine.U2D.SpriteAtlas::get_tag_Injected");
		GetSpritesWithNameScripting_InjectedDelegateField = IL2CPP.ResolveICall<GetSpritesWithNameScripting_InjectedDelegate>("UnityEngine.U2D.SpriteAtlas::GetSpritesWithNameScripting_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241813, RefRangeEnd = 1241814, XrefRangeStart = 1241802, XrefRangeEnd = 1241813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanBindTo(Sprite sprite)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1241833, RefRangeEnd = 1241837, XrefRangeStart = 1241814, XrefRangeEnd = 1241833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetSprite(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1241842, RefRangeEnd = 1241845, XrefRangeStart = 1241837, XrefRangeEnd = 1241842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSprites(Il2CppReferenceArray<Sprite> sprites)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprites);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSprites_Public_Int32_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1241842, RefRangeEnd = 1241845, XrefRangeStart = 1241842, XrefRangeEnd = 1241845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSpritesScripting(Il2CppReferenceArray<Sprite> sprites)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprites);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpritesScripting_Private_Int32_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241845, XrefRangeEnd = 1241849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpriteAtlas()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241849, XrefRangeEnd = 1241851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_spriteCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spriteCount_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241851, XrefRangeEnd = 1241853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanBindTo_Injected(System.IntPtr _unity_self, System.IntPtr sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sprite;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanBindTo_Injected_Private_Static_Boolean_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241853, XrefRangeEnd = 1241855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetSprite_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSprite_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241855, XrefRangeEnd = 1241857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSpritesScripting_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<Sprite> sprites)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprites);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpritesScripting_Injected_Private_Static_Int32_IntPtr_Il2CppReferenceArray_1_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SpriteAtlas(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public int GetSprites(Il2CppReferenceArray<Sprite> sprites, string name)
	{
		return GetSpritesWithNameScripting(sprites, name);
	}

	public unsafe int GetSpritesWithNameScripting(Il2CppReferenceArray<Sprite> sprites, string name)
	{
		//IL_0029: Expected O, but got Ref
		//IL_0035: Expected O, but got Ref
		//The blocks IL_003a are reachable both inside and outside the pinned region starting at IL_0029. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetSpritesWithNameScripting_Injected(intPtr, sprites, ref managedSpanWrapper);
				}
			}
			return GetSpritesWithNameScripting_Injected(intPtr, sprites, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static bool get_isVariant_Injected(System.IntPtr _unity_self)
	{
		return get_isVariant_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_tag_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_tag_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int GetSpritesWithNameScripting_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<Sprite> sprites, ref ManagedSpanWrapper name)
	{
		return GetSpritesWithNameScripting_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprites), (nint)Unsafe.AsPointer(ref name));
	}
}
