using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Threading.Tasks.Sources;

public class IValueTaskSource : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_Void_Int16_0;

	static IValueTaskSource()
	{
		Il2CppClassPointerStore<IValueTaskSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks.Sources", "IValueTaskSource");
		NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource>.NativeClassPtr, 100668466);
		NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource>.NativeClassPtr, 100668467);
		NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource>.NativeClassPtr, 100668468);
	}

	[CallerCount(0)]
	public unsafe virtual ValueTaskSourceStatus GetStatus(short token)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&token);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ValueTaskSourceStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void OnCompleted(Action<Object> continuation, Object state, short token, ValueTaskSourceOnCompletedFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &token;
		*(ValueTaskSourceOnCompletedFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void GetResult(short token)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&token);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_Void_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IValueTaskSource(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
public class IValueTaskSource<TResult> : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_TResult_Int16_0;

	static IValueTaskSource()
	{
		Il2CppClassPointerStore<IValueTaskSource<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks.Sources", "IValueTaskSource`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
		NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource<TResult>>.NativeClassPtr, 100668469);
		NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource<TResult>>.NativeClassPtr, 100668470);
		NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_TResult_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource<TResult>>.NativeClassPtr, 100668471);
	}

	[CallerCount(0)]
	public unsafe virtual ValueTaskSourceStatus GetStatus(short token)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&token);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ValueTaskSourceStatus*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void OnCompleted(Action<Object> continuation, Object state, short token, ValueTaskSourceOnCompletedFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &token;
		*(ValueTaskSourceOnCompletedFlags**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual TResult GetResult(short token)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&token);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_TResult_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
	}

	public IValueTaskSource(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
