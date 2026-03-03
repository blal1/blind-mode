using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml.Schema;

public sealed class XmlSchemaCompilationSettings : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_enableUpaCheck;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EnableUpaCheck_Public_get_Boolean_0;

	public unsafe bool enableUpaCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableUpaCheck);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableUpaCheck)) = value;
		}
	}

	public unsafe bool EnableUpaCheck
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnableUpaCheck_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static XmlSchemaCompilationSettings()
	{
		Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaCompilationSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr);
		NativeFieldInfoPtr_enableUpaCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr, "enableUpaCheck");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr, 100667467);
		NativeMethodInfoPtr_get_EnableUpaCheck_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr, 100667468);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 939076, RefRangeEnd = 939084, XrefRangeStart = 939075, XrefRangeEnd = 939076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaCompilationSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XmlSchemaCompilationSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
