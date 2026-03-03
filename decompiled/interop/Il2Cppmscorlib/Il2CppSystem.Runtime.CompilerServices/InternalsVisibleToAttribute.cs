using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices;

public sealed class InternalsVisibleToAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__assemblyName;

	private static readonly System.IntPtr NativeFieldInfoPtr__allInternalsVisible;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0;

	public unsafe string _assemblyName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assemblyName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assemblyName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool _allInternalsVisible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allInternalsVisible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allInternalsVisible)) = value;
		}
	}

	public unsafe bool AllInternalsVisible
	{
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static InternalsVisibleToAttribute()
	{
		Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "InternalsVisibleToAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, "_assemblyName");
		NativeFieldInfoPtr__allInternalsVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, "_allInternalsVisible");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100671505);
		NativeMethodInfoPtr_set_AllInternalsVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr, 100671506);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806943, XrefRangeEnd = 806945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InternalsVisibleToAttribute(string assemblyName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalsVisibleToAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InternalsVisibleToAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
