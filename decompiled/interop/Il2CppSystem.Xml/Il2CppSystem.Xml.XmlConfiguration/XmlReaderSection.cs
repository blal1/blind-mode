using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.XmlConfiguration;

public sealed class XmlReaderSection : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultResolver_Internal_Static_XmlResolver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0;

	public unsafe static bool ProhibitDefaultUrlResolver
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool CollapseWhiteSpaceIntoEmptyString
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static XmlReaderSection()
	{
		Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XmlConfiguration", "XmlReaderSection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr);
		NativeMethodInfoPtr_get_ProhibitDefaultUrlResolver_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr, 100665848);
		NativeMethodInfoPtr_CreateDefaultResolver_Internal_Static_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr, 100665849);
		NativeMethodInfoPtr_get_CollapseWhiteSpaceIntoEmptyString_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSection>.NativeClassPtr, 100665850);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 919946, RefRangeEnd = 919950, XrefRangeStart = 919942, XrefRangeEnd = 919946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XmlResolver CreateDefaultResolver()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDefaultResolver_Internal_Static_XmlResolver_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
	}

	public XmlReaderSection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
