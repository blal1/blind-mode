using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngineInternal.Input;

public sealed class NativeUpdateCallback : Il2CppSystem.MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NativeInputUpdateType_ptr_NativeInputEventBuffer_0;

	static NativeUpdateCallback()
	{
		Il2CppClassPointerStore<NativeUpdateCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputModule.dll", "UnityEngineInternal.Input", "NativeUpdateCallback");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeUpdateCallback>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NativeInputUpdateType_ptr_NativeInputEventBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeUpdateCallback>.NativeClassPtr, 100663298);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 687835, RefRangeEnd = 687873, XrefRangeStart = 687835, XrefRangeEnd = 687873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeUpdateCallback(Il2CppSystem.Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeUpdateCallback>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&updateType);
		*(NativeInputEventBuffer**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = buffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NativeInputUpdateType_ptr_NativeInputEventBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NativeUpdateCallback(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
