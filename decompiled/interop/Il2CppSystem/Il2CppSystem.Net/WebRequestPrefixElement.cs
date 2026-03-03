using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public class WebRequestPrefixElement : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Prefix;

	private static readonly System.IntPtr NativeFieldInfoPtr_creator;

	private static readonly System.IntPtr NativeFieldInfoPtr_creatorType;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0;

	public unsafe string Prefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Prefix);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Prefix)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe IWebRequestCreate creator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IWebRequestCreate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Type creatorType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creatorType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creatorType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IWebRequestCreate Creator
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 887812, RefRangeEnd = 887813, XrefRangeStart = 887790, XrefRangeEnd = 887812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IWebRequestCreate>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static WebRequestPrefixElement()
	{
		Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebRequestPrefixElement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr);
		NativeFieldInfoPtr_Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "Prefix");
		NativeFieldInfoPtr_creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "creator");
		NativeFieldInfoPtr_creatorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, "creatorType");
		NativeMethodInfoPtr_get_Creator_Public_get_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100666152);
		NativeMethodInfoPtr_set_Creator_Public_set_Void_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100666153);
		NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr, 100666154);
	}

	[CallerCount(138)]
	[CachedScanResults(RefRangeStart = 141598, RefRangeEnd = 141736, XrefRangeStart = 141598, XrefRangeEnd = 141736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WebRequestPrefixElement(string P, IWebRequestCreate C)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestPrefixElement>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)C);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_IWebRequestCreate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public WebRequestPrefixElement(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
