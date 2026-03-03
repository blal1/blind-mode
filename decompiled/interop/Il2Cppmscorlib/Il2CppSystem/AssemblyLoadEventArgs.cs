using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem;

public class AssemblyLoadEventArgs : EventArgs
{
	private static readonly System.IntPtr NativeFieldInfoPtr__LoadedAssembly_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Assembly_0;

	public unsafe Assembly _LoadedAssembly_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LoadedAssembly_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LoadedAssembly_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AssemblyLoadEventArgs()
	{
		Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AssemblyLoadEventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr);
		NativeFieldInfoPtr__LoadedAssembly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr, "<LoadedAssembly>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr, 100664323);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 719792, RefRangeEnd = 719793, XrefRangeStart = 719780, XrefRangeEnd = 719792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssemblyLoadEventArgs(Assembly loadedAssembly)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyLoadEventArgs>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loadedAssembly);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AssemblyLoadEventArgs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
