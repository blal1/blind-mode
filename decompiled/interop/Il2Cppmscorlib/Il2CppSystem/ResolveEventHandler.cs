using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem;

public sealed class ResolveEventHandler : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Assembly_Object_ResolveEventArgs_0;

	static ResolveEventHandler()
	{
		Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ResolveEventHandler");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr, 100665658);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Assembly_Object_ResolveEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr, 100665659);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 737505, RefRangeEnd = 737513, XrefRangeStart = 737495, XrefRangeEnd = 737505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResolveEventHandler(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveEventHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Assembly Invoke(Object sender, ResolveEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Assembly_Object_ResolveEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
	}

	public ResolveEventHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator ResolveEventHandler(System.Func<Object, ResolveEventArgs, Assembly> P_0)
	{
		return DelegateSupport.ConvertDelegate<ResolveEventHandler>((System.Delegate)P_0);
	}

	public static ResolveEventHandler operator +(ResolveEventHandler P_0, ResolveEventHandler P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<ResolveEventHandler>();
	}

	public static ResolveEventHandler operator -(ResolveEventHandler P_0, ResolveEventHandler P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<ResolveEventHandler>();
		}
		return (ResolveEventHandler)obj;
	}
}
