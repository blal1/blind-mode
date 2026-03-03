using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml.Serialization;

public sealed class XmlNodeEventHandler : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeEventArgs_0;

	static XmlNodeEventHandler()
	{
		Il2CppClassPointerStore<XmlNodeEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlNodeEventHandler");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeEventHandler>.NativeClassPtr, 100665292);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeEventHandler>.NativeClassPtr, 100665293);
	}

	[CallerCount(110)]
	[CachedScanResults(RefRangeStart = 49659, RefRangeEnd = 49769, XrefRangeStart = 49659, XrefRangeEnd = 49769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlNodeEventHandler(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeEventHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Invoke(Object sender, XmlNodeEventArgs e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_XmlNodeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlNodeEventHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator XmlNodeEventHandler(System.Action<Object, XmlNodeEventArgs> P_0)
	{
		return DelegateSupport.ConvertDelegate<XmlNodeEventHandler>((System.Delegate)P_0);
	}

	public static XmlNodeEventHandler operator +(XmlNodeEventHandler P_0, XmlNodeEventHandler P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<XmlNodeEventHandler>();
	}

	public static XmlNodeEventHandler operator -(XmlNodeEventHandler P_0, XmlNodeEventHandler P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<XmlNodeEventHandler>();
		}
		return (XmlNodeEventHandler)obj;
	}
}
