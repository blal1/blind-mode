using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.ComponentModel;

public class TypeConverter : Object
{
	[DefaultMember("Item")]
	public class StandardValuesCollection : Object
	{
		static StandardValuesCollection()
		{
			Il2CppClassPointerStore<StandardValuesCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "StandardValuesCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardValuesCollection>.NativeClassPtr);
		}

		public StandardValuesCollection(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCompatibleTypeConversion;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string s_UseCompatibleTypeConverterBehavior
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static bool useCompatibleTypeConversion
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_useCompatibleTypeConversion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_useCompatibleTypeConversion, (void*)(&value));
		}
	}

	static TypeConverter()
	{
		Il2CppClassPointerStore<TypeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "TypeConverter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr);
		NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "s_UseCompatibleTypeConverterBehavior");
		NativeFieldInfoPtr_useCompatibleTypeConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "useCompatibleTypeConversion");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100665288);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TypeConverter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TypeConverter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
