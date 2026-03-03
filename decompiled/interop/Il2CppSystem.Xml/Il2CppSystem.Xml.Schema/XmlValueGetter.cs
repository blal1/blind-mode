using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema;

public sealed class XmlValueGetter : MulticastDelegate
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_0;

	static XmlValueGetter()
	{
		Il2CppClassPointerStore<XmlValueGetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlValueGetter");
		NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueGetter>.NativeClassPtr, 100667984);
		NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValueGetter>.NativeClassPtr, 100667985);
	}

	[CallerCount(212)]
	[CachedScanResults(RefRangeStart = 546140, RefRangeEnd = 546352, XrefRangeStart = 546140, XrefRangeEnd = 546352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlValueGetter(Object @object, System.IntPtr method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlValueGetter>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Object Invoke()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public XmlValueGetter(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static implicit operator XmlValueGetter(System.Func<Object> P_0)
	{
		return DelegateSupport.ConvertDelegate<XmlValueGetter>((System.Delegate)P_0);
	}

	public static XmlValueGetter operator +(XmlValueGetter P_0, XmlValueGetter P_1)
	{
		return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<XmlValueGetter>();
	}

	public static XmlValueGetter operator -(XmlValueGetter P_0, XmlValueGetter P_1)
	{
		object obj = Delegate.Remove(P_0, P_1);
		if (obj != null)
		{
			obj = ((Il2CppObjectBase)obj).Cast<XmlValueGetter>();
		}
		return (XmlValueGetter)obj;
	}
}
