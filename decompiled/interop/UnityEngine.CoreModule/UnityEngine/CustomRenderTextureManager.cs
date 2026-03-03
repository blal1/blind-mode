using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine;

public static class CustomRenderTextureManager : Il2CppSystem.Object
{
	private delegate void GetAllCustomRenderTexturesDelegate(System.IntPtr currentCustomRenderTextures);

	private static readonly System.IntPtr NativeFieldInfoPtr_textureLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureUnloaded;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0;

	private static readonly GetAllCustomRenderTexturesDelegate GetAllCustomRenderTexturesDelegateField;

	public unsafe static Il2CppSystem.Action<CustomRenderTexture> textureLoaded
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_textureLoaded, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<CustomRenderTexture>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_textureLoaded, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<CustomRenderTexture> textureUnloaded
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_textureUnloaded, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<CustomRenderTexture>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_textureUnloaded, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static CustomRenderTextureManager()
	{
		Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CustomRenderTextureManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr);
		NativeFieldInfoPtr_textureLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, "textureLoaded");
		NativeFieldInfoPtr_textureUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, "textureUnloaded");
		NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100664286);
		NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100664287);
		GetAllCustomRenderTexturesDelegateField = IL2CPP.ResolveICall<GetAllCustomRenderTexturesDelegate>("UnityEngine.CustomRenderTextureManager::GetAllCustomRenderTextures");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172057, XrefRangeEnd = 1172059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172059, XrefRangeEnd = 1172061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CustomRenderTextureManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_textureLoaded(Il2CppSystem.Action<CustomRenderTexture> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_textureLoaded(Il2CppSystem.Action<CustomRenderTexture> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_textureUnloaded(Il2CppSystem.Action<CustomRenderTexture> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_textureUnloaded(Il2CppSystem.Action<CustomRenderTexture> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void GetAllCustomRenderTextures(List<CustomRenderTexture> currentCustomRenderTextures)
	{
		GetAllCustomRenderTexturesDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentCustomRenderTextures));
	}

	[SpecialName]
	public static void add_updateTriggered(Il2CppSystem.Action<CustomRenderTexture, int> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_updateTriggered(Il2CppSystem.Action<CustomRenderTexture, int> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void InvokeTriggerUpdate(CustomRenderTexture crt, int updateCount)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_initializeTriggered(Il2CppSystem.Action<CustomRenderTexture> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_initializeTriggered(Il2CppSystem.Action<CustomRenderTexture> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void InvokeTriggerInitialize(CustomRenderTexture crt)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
