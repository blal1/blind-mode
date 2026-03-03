using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary;

public sealed class InternalFE : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FEtypeFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_FEassemblyFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_FEsecurityLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_FEserializerTypeEnum;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe FormatterTypeStyle FEtypeFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FEtypeFormat);
			return *(FormatterTypeStyle*)num;
		}
		set
		{
			*(FormatterTypeStyle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FEtypeFormat)) = value;
		}
	}

	public unsafe FormatterAssemblyStyle FEassemblyFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FEassemblyFormat);
			return *(FormatterAssemblyStyle*)num;
		}
		set
		{
			*(FormatterAssemblyStyle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FEassemblyFormat)) = value;
		}
	}

	public unsafe TypeFilterLevel FEsecurityLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FEsecurityLevel);
			return *(TypeFilterLevel*)num;
		}
		set
		{
			*(TypeFilterLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FEsecurityLevel)) = value;
		}
	}

	public unsafe InternalSerializerTypeE FEserializerTypeEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FEserializerTypeEnum);
			return *(InternalSerializerTypeE*)num;
		}
		set
		{
			*(InternalSerializerTypeE*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FEserializerTypeEnum)) = value;
		}
	}

	static InternalFE()
	{
		Il2CppClassPointerStore<InternalFE>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "InternalFE");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalFE>.NativeClassPtr);
		NativeFieldInfoPtr_FEtypeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEtypeFormat");
		NativeFieldInfoPtr_FEassemblyFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEassemblyFormat");
		NativeFieldInfoPtr_FEsecurityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEsecurityLevel");
		NativeFieldInfoPtr_FEserializerTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, "FEserializerTypeEnum");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalFE>.NativeClassPtr, 100671184);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InternalFE()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalFE>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InternalFE(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
