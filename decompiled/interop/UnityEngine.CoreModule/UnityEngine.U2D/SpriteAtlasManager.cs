using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D;

public class SpriteAtlasManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_atlasRequested;

	private static readonly System.IntPtr NativeFieldInfoPtr_atlasRegistered;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_atlasRequested_Public_Static_add_Void_Action_2_String_Action_1_SpriteAtlas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_atlasRequested_Public_Static_rem_Void_Action_2_String_Action_1_SpriteAtlas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Register_Injected_Private_Static_Void_IntPtr_0;

	public unsafe static Il2CppSystem.Action<string, Il2CppSystem.Action<SpriteAtlas>> atlasRequested
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_atlasRequested, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string, Il2CppSystem.Action<SpriteAtlas>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_atlasRequested, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<SpriteAtlas> atlasRegistered
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_atlasRegistered, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<SpriteAtlas>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_atlasRegistered, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SpriteAtlasManager()
	{
		Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteAtlasManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr);
		NativeFieldInfoPtr_atlasRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, "atlasRequested");
		NativeFieldInfoPtr_atlasRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, "atlasRegistered");
		NativeMethodInfoPtr_add_atlasRequested_Public_Static_add_Void_Action_2_String_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100669040);
		NativeMethodInfoPtr_remove_atlasRequested_Public_Static_rem_Void_Action_2_String_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100669041);
		NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100669042);
		NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100669043);
		NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100669044);
		NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100669045);
		NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100669046);
		NativeMethodInfoPtr_Register_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlasManager>.NativeClassPtr, 100669047);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241749, RefRangeEnd = 1241750, XrefRangeStart = 1241741, XrefRangeEnd = 1241749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_atlasRequested(Il2CppSystem.Action<string, Il2CppSystem.Action<SpriteAtlas>> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_atlasRequested_Public_Static_add_Void_Action_2_String_Action_1_SpriteAtlas_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241758, RefRangeEnd = 1241759, XrefRangeStart = 1241750, XrefRangeEnd = 1241758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_atlasRequested(Il2CppSystem.Action<string, Il2CppSystem.Action<SpriteAtlas>> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_atlasRequested_Public_Static_rem_Void_Action_2_String_Action_1_SpriteAtlas_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241759, XrefRangeEnd = 1241763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RequestAtlas(string tag)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestAtlas_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[SpecialName]
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1241772, RefRangeEnd = 1241775, XrefRangeStart = 1241763, XrefRangeEnd = 1241772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_atlasRegistered(Il2CppSystem.Action<SpriteAtlas> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_atlasRegistered_Public_Static_add_Void_Action_1_SpriteAtlas_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241784, RefRangeEnd = 1241785, XrefRangeStart = 1241775, XrefRangeEnd = 1241784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_atlasRegistered(Il2CppSystem.Action<SpriteAtlas> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_atlasRegistered_Public_Static_rem_Void_Action_1_SpriteAtlas_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241785, XrefRangeEnd = 1241787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PostRegisteredAtlas(SpriteAtlas spriteAtlas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAtlas);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostRegisteredAtlas_Private_Static_Void_SpriteAtlas_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241787, XrefRangeEnd = 1241792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Register(SpriteAtlas spriteAtlas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteAtlas);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Register_Internal_Static_Void_SpriteAtlas_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241792, XrefRangeEnd = 1241794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Register_Injected(System.IntPtr spriteAtlas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&spriteAtlas);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Register_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpriteAtlasManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
