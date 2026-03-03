using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text;

public class TextHandleTemporaryCache : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_TextInfoPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MinFramesInCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncRoot;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearTemporaryCache_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTextInfoToCache_Public_Void_TextHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTextInfoFromCache_Public_Virtual_New_Void_TextHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCaching_Private_Void_TextHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecycleTextInfoFromCache_Private_Void_TextHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCurrentFrame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe LinkedList<TextInfo> s_TextInfoPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_TextInfoPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LinkedList<TextInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_TextInfoPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int s_MinFramesInCache
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MinFramesInCache, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MinFramesInCache, (void*)(&value));
		}
	}

	public unsafe int currentFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFrame)) = value;
		}
	}

	public unsafe Il2CppSystem.Object syncRoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncRoot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncRoot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TextHandleTemporaryCache()
	{
		Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextHandleTemporaryCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr);
		NativeFieldInfoPtr_s_TextInfoPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr, "s_TextInfoPool");
		NativeFieldInfoPtr_s_MinFramesInCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr, "s_MinFramesInCache");
		NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr, "currentFrame");
		NativeFieldInfoPtr_syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr, "syncRoot");
		NativeMethodInfoPtr_ClearTemporaryCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr, 100663981);
		NativeMethodInfoPtr_AddTextInfoToCache_Public_Void_TextHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr, 100663982);
		NativeMethodInfoPtr_RemoveTextInfoFromCache_Public_Virtual_New_Void_TextHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr, 100663983);
		NativeMethodInfoPtr_RefreshCaching_Private_Void_TextHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr, 100663984);
		NativeMethodInfoPtr_RecycleTextInfoFromCache_Private_Void_TextHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr, 100663985);
		NativeMethodInfoPtr_UpdateCurrentFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr, 100663986);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr, 100663987);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284105, XrefRangeEnd = 1284114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearTemporaryCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearTemporaryCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1284182, RefRangeEnd = 1284183, XrefRangeStart = 1284114, XrefRangeEnd = 1284182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTextInfoToCache(TextHandle textHandle, int hashCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hashCode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTextInfoToCache_Public_Void_TextHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284183, XrefRangeEnd = 1284198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveTextInfoFromCache(TextHandle textHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveTextInfoFromCache_Public_Virtual_New_Void_TextHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284198, XrefRangeEnd = 1284209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshCaching(TextHandle textHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshCaching_Private_Void_TextHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1284235, RefRangeEnd = 1284236, XrefRangeStart = 1284209, XrefRangeEnd = 1284235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecycleTextInfoFromCache(TextHandle textHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecycleTextInfoFromCache_Private_Void_TextHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284236, XrefRangeEnd = 1284237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCurrentFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCurrentFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284237, XrefRangeEnd = 1284250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextHandleTemporaryCache()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextHandleTemporaryCache>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TextHandleTemporaryCache(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
