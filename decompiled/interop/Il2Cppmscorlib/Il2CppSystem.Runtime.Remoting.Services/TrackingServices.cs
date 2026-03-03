using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Services;

public class TrackingServices : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__handlers;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0;

	public unsafe static ArrayList _handlers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__handlers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__handlers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TrackingServices()
	{
		Il2CppClassPointerStore<TrackingServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Services", "TrackingServices");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr);
		NativeFieldInfoPtr__handlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, "_handlers");
		NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100669996);
		NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100669997);
		NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackingServices>.NativeClassPtr, 100669998);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792437, XrefRangeEnd = 792467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NotifyMarshaledObject(Object obj, ObjRef or)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)or);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyMarshaledObject_Internal_Static_Void_Object_ObjRef_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 792497, RefRangeEnd = 792498, XrefRangeStart = 792467, XrefRangeEnd = 792497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NotifyUnmarshaledObject(Object obj, ObjRef or)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)or);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyUnmarshaledObject_Internal_Static_Void_Object_ObjRef_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 792528, RefRangeEnd = 792529, XrefRangeStart = 792498, XrefRangeEnd = 792528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NotifyDisconnectedObject(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyDisconnectedObject_Internal_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TrackingServices(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
