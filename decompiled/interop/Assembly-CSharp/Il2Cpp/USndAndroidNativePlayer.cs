using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

public class USndAndroidNativePlayer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_player;

	private static readonly System.IntPtr NativeFieldInfoPtr_plugin;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Terminate_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadData_Public_Static_Int32_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Static_Int32_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unload_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static USndAndroidNativePlayer player
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_player, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<USndAndroidNativePlayer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_player, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AndroidJavaObject plugin
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_plugin, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_plugin, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static USndAndroidNativePlayer()
	{
		Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "USndAndroidNativePlayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr);
		NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr, "player");
		NativeFieldInfoPtr_plugin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr, "plugin");
		NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr, 100664059);
		NativeMethodInfoPtr_Terminate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr, 100664060);
		NativeMethodInfoPtr_LoadData_Public_Static_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr, 100664061);
		NativeMethodInfoPtr_Play_Public_Static_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr, 100664062);
		NativeMethodInfoPtr_Stop_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr, 100664063);
		NativeMethodInfoPtr_Unload_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr, 100664064);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr, 100664065);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38824, RefRangeEnd = 38825, XrefRangeStart = 38789, XrefRangeEnd = 38824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize(int maxNum)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxNum);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38839, RefRangeEnd = 38840, XrefRangeStart = 38825, XrefRangeEnd = 38839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Terminate()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Terminate_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 38856, RefRangeEnd = 38858, XrefRangeStart = 38840, XrefRangeEnd = 38856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadData(string saveName, string className, string funcName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(saveName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(className);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(funcName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadData_Public_Static_Int32_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38880, RefRangeEnd = 38881, XrefRangeStart = 38858, XrefRangeEnd = 38880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Play(int soundId, float volume, float rate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&soundId);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Play_Public_Static_Int32_Int32_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38881, XrefRangeEnd = 38893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Stop(int streamId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&streamId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 38905, RefRangeEnd = 38907, XrefRangeStart = 38893, XrefRangeEnd = 38905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Unload(int soundId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&soundId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unload_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe USndAndroidNativePlayer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<USndAndroidNativePlayer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public USndAndroidNativePlayer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
