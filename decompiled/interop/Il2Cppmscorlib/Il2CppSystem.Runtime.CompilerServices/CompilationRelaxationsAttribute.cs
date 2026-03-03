using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices;

[System.Serializable]
public class CompilationRelaxationsAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_relaxations;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0;

	public unsafe int m_relaxations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_relaxations);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_relaxations)) = value;
		}
	}

	public unsafe int CompilationRelaxations
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static CompilationRelaxationsAttribute()
	{
		Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "CompilationRelaxationsAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_m_relaxations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, "m_relaxations");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100671502);
		NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100671503);
		NativeMethodInfoPtr_get_CompilationRelaxations_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr, 100671504);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166660, RefRangeEnd = 166661, XrefRangeStart = 166660, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CompilationRelaxationsAttribute(int relaxations)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&relaxations);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166660, RefRangeEnd = 166661, XrefRangeStart = 166660, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompilationRelaxationsAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&relaxations);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CompilationRelaxations_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CompilationRelaxationsAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
