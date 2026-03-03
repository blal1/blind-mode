using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

[System.Serializable]
public sealed class ConsoleCancelEventArgs : EventArgs
{
	private static readonly System.IntPtr NativeFieldInfoPtr__type;

	private static readonly System.IntPtr NativeFieldInfoPtr__Cancel_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	public unsafe ConsoleSpecialKey _type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type);
			return *(ConsoleSpecialKey*)num;
		}
		set
		{
			*(ConsoleSpecialKey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type)) = value;
		}
	}

	public unsafe bool _Cancel_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Cancel_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Cancel_k__BackingField)) = value;
		}
	}

	public unsafe bool Cancel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ConsoleCancelEventArgs()
	{
		Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleCancelEventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr);
		NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, "_type");
		NativeFieldInfoPtr__Cancel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, "<Cancel>k__BackingField");
		NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100666295);
		NativeMethodInfoPtr_get_Cancel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100666296);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr, 100666297);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 748953, RefRangeEnd = 748954, XrefRangeStart = 748949, XrefRangeEnd = 748953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConsoleCancelEventArgs(ConsoleSpecialKey type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ConsoleSpecialKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748954, XrefRangeEnd = 748957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConsoleCancelEventArgs()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleCancelEventArgs>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ConsoleCancelEventArgs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
