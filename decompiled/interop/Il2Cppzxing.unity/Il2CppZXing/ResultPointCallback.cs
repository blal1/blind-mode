using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppZXing;

public sealed class ResultPointCallback : Il2CppSystem.MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ResultPoint_0;

	static ResultPointCallback()
	{
		Il2CppClassPointerStore<ResultPointCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing", "ResultPointCallback");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPointCallback>.NativeClassPtr, 100663514);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResultPointCallback>.NativeClassPtr, 100663515);
	}

	[CallerCount(809)]
	[CachedScanResults(RefRangeStart = 49779, RefRangeEnd = 50588, XrefRangeStart = 49779, XrefRangeEnd = 50588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResultPointCallback(Il2CppSystem.Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResultPointCallback>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(ResultPoint point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)point);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ResultPointCallback(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator ResultPointCallback(System.Action<ResultPoint> P_0)
	{
		return DelegateSupport.ConvertDelegate<ResultPointCallback>((System.Delegate)P_0);
	}

	public static ResultPointCallback operator +(ResultPointCallback P_0, ResultPointCallback P_1)
	{
		return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<ResultPointCallback>();
	}

	public static ResultPointCallback operator -(ResultPointCallback P_0, ResultPointCallback P_1)
	{
		object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<ResultPointCallback>();
		}
		return (ResultPointCallback)obj;
	}
}
