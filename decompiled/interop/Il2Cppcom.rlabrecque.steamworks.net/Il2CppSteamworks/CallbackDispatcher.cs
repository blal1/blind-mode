using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSteamworks;

public static class CallbackDispatcher : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_registeredCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_registeredGameServerCallbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_registeredCallResults;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_sync;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_pCallbackMsg;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_initCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExceptionHandler_Public_Static_Void_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInitialized_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_Callback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unregister_Internal_Static_Void_Callback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterAll_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RunFrame_Internal_Static_Void_Boolean_0;

	public unsafe static Dictionary<int, List<Callback>> m_registeredCallbacks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_registeredCallbacks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<Callback>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_registeredCallbacks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<int, List<Callback>> m_registeredGameServerCallbacks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_registeredGameServerCallbacks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<Callback>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_registeredGameServerCallbacks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<ulong, List<CallResult>> m_registeredCallResults
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_registeredCallResults, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ulong, List<CallResult>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_registeredCallResults, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Object m_sync
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_sync, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_sync, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static System.IntPtr m_pCallbackMsg
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_pCallbackMsg, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_pCallbackMsg, (void*)(&value));
		}
	}

	public unsafe static int m_initCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_initCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_initCount, (void*)(&value));
		}
	}

	public unsafe static bool IsInitialized
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686960, XrefRangeEnd = 686964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsInitialized_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static CallbackDispatcher()
	{
		Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "CallbackDispatcher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr);
		NativeFieldInfoPtr_m_registeredCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_registeredCallbacks");
		NativeFieldInfoPtr_m_registeredGameServerCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_registeredGameServerCallbacks");
		NativeFieldInfoPtr_m_registeredCallResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_registeredCallResults");
		NativeFieldInfoPtr_m_sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_sync");
		NativeFieldInfoPtr_m_pCallbackMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_pCallbackMsg");
		NativeFieldInfoPtr_m_initCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, "m_initCount");
		NativeMethodInfoPtr_ExceptionHandler_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_get_IsInitialized_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_Register_Internal_Static_Void_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_Unregister_Internal_Static_Void_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_UnregisterAll_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_RunFrame_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackDispatcher>.NativeClassPtr, 100663402);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 686957, RefRangeEnd = 686960, XrefRangeStart = 686953, XrefRangeEnd = 686957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExceptionHandler(Il2CppSystem.Exception e)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExceptionHandler_Public_Static_Void_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 686993, RefRangeEnd = 686994, XrefRangeStart = 686964, XrefRangeEnd = 686993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687014, RefRangeEnd = 687015, XrefRangeStart = 686994, XrefRangeEnd = 687014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Shutdown()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 687046, RefRangeEnd = 687049, XrefRangeStart = 687015, XrefRangeEnd = 687046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Register(Callback cb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Register_Internal_Static_Void_Callback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 687073, RefRangeEnd = 687079, XrefRangeStart = 687049, XrefRangeEnd = 687073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Unregister(Callback cb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unregister_Internal_Static_Void_Callback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687196, RefRangeEnd = 687197, XrefRangeStart = 687079, XrefRangeEnd = 687196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnregisterAll()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnregisterAll_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687333, RefRangeEnd = 687334, XrefRangeStart = 687197, XrefRangeEnd = 687333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RunFrame(bool isGameServer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isGameServer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RunFrame_Internal_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CallbackDispatcher(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
