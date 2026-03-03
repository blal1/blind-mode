using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading;

public sealed class WaitOrTimerCallback : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Boolean_0;

	static WaitOrTimerCallback()
	{
		Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "WaitOrTimerCallback");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr, 100667937);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr, 100667938);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 771172, RefRangeEnd = 771189, XrefRangeStart = 771162, XrefRangeEnd = 771172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitOrTimerCallback(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(Object state, bool timedOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timedOut;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public WaitOrTimerCallback(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator WaitOrTimerCallback(System.Action<Object, bool> P_0)
	{
		return DelegateSupport.ConvertDelegate<WaitOrTimerCallback>((System.Delegate)P_0);
	}

	public static WaitOrTimerCallback operator +(WaitOrTimerCallback P_0, WaitOrTimerCallback P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<WaitOrTimerCallback>();
	}

	public static WaitOrTimerCallback operator -(WaitOrTimerCallback P_0, WaitOrTimerCallback P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<WaitOrTimerCallback>();
		}
		return (WaitOrTimerCallback)obj;
	}
}
