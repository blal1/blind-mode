using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml;

public sealed class CachingEventHandler : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdCachingReader_0;

	static CachingEventHandler()
	{
		Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "CachingEventHandler");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr, 100664171);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdCachingReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr, 100664172);
	}

	[CallerCount(588)]
	[CachedScanResults(RefRangeStart = 148277, RefRangeEnd = 148865, XrefRangeStart = 148277, XrefRangeEnd = 148865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CachingEventHandler(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachingEventHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(XsdCachingReader cachingReader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cachingReader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdCachingReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CachingEventHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator CachingEventHandler(System.Action<XsdCachingReader> P_0)
	{
		return DelegateSupport.ConvertDelegate<CachingEventHandler>((System.Delegate)P_0);
	}

	public static CachingEventHandler operator +(CachingEventHandler P_0, CachingEventHandler P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<CachingEventHandler>();
	}

	public static CachingEventHandler operator -(CachingEventHandler P_0, CachingEventHandler P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<CachingEventHandler>();
		}
		return (CachingEventHandler)obj;
	}
}
