using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading;

public class EventWaitHandle : WaitHandle
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Boolean_0;

	static EventWaitHandle()
	{
		Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "EventWaitHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100667755);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100667756);
		NativeMethodInfoPtr_Reset_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100667757);
		NativeMethodInfoPtr_Set_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100667758);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768651, XrefRangeEnd = 768652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventWaitHandle(bool initialState, EventResetMode mode)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&initialState);
		*(EventResetMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 768674, RefRangeEnd = 768678, XrefRangeStart = 768652, XrefRangeEnd = 768674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventWaitHandle(bool initialState, EventResetMode mode, string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&initialState);
		*(EventResetMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 768680, RefRangeEnd = 768684, XrefRangeStart = 768678, XrefRangeEnd = 768680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 768686, RefRangeEnd = 768711, XrefRangeStart = 768684, XrefRangeEnd = 768686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Set()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public EventWaitHandle(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
