using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts;

public class IDynamicMessageSink : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0;

	static IDynamicMessageSink()
	{
		Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IDynamicMessageSink");
		NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr, 100670139);
		NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicMessageSink>.NativeClassPtr, 100670140);
	}

	[CallerCount(0)]
	public unsafe virtual void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)replyMsg);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bCliSide;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bAsync;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ProcessMessageFinish_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reqMsg);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bCliSide;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bAsync;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ProcessMessageStart_Public_Abstract_Virtual_New_Void_IMessage_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IDynamicMessageSink(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
