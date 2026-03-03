using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings;

public static class ExceptionMarshaller : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_pendingException;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPendingException_Private_Static_Void_Exception_0;

	public unsafe static Il2CppSystem.Exception s_pendingException
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_pendingException, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Exception>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_pendingException, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ExceptionMarshaller()
	{
		Il2CppClassPointerStore<ExceptionMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", "ExceptionMarshaller");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionMarshaller>.NativeClassPtr);
		NativeFieldInfoPtr_s_pendingException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionMarshaller>.NativeClassPtr, "s_pendingException");
		NativeMethodInfoPtr_SetPendingException_Private_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionMarshaller>.NativeClassPtr, 100667243);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228348, XrefRangeEnd = 1228354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPendingException(Il2CppSystem.Exception ex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPendingException_Private_Static_Void_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ExceptionMarshaller(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void CheckPendingException()
	{
		Il2CppSystem.Exception ex = s_pendingException;
		if (ex != null)
		{
			s_pendingException = null;
			throw ex;
		}
	}
}
