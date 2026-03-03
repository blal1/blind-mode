using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading.Tasks;

public class StackGuard : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_inliningDepth;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndInliningScope_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int m_inliningDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inliningDepth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_inliningDepth)) = value;
		}
	}

	static StackGuard()
	{
		Il2CppClassPointerStore<StackGuard>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "StackGuard");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackGuard>.NativeClassPtr);
		NativeFieldInfoPtr_m_inliningDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, "m_inliningDepth");
		NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100668356);
		NativeMethodInfoPtr_EndInliningScope_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100668357);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100668358);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 775385, RefRangeEnd = 775386, XrefRangeStart = 775384, XrefRangeEnd = 775385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryBeginInliningScope()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 775386, RefRangeEnd = 775388, XrefRangeStart = 775386, XrefRangeEnd = 775386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndInliningScope()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInliningScope_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StackGuard()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackGuard>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public StackGuard(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
