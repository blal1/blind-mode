using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMicrosoft.Win32.SafeHandles;

public static class SafeHandleCache<T> : Il2CppSystem.Object where T : SafeHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_invalidHandle;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCachedInvalidHandle_Internal_Static_Boolean_SafeHandle_0;

	public unsafe static T s_invalidHandle
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_invalidHandle, (void*)(&intPtr));
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
		}
		set
		{
			//IL_0052->IL0055: Incompatible stack types: I vs Ref
			//IL_0031->IL0055: Incompatible stack types: I vs Ref
			//IL_003e->IL0055: Incompatible stack types: I vs Ref
			//IL_0045->IL0055: Incompatible stack types: I vs Ref
			System.IntPtr nativeFieldInfoPtr_s_invalidHandle = NativeFieldInfoPtr_s_invalidHandle;
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				T val = value;
				if (val is string)
				{
					reference = ref *(_003F*)IL2CPP.ManagedStringToIl2Cpp(val as string);
				}
				else
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null));
					reference = ref *(_003F*)intPtr;
					if (intPtr != (System.IntPtr)0)
					{
						reference = ref *(_003F*)intPtr;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
						{
							reference = ref *(_003F*)IL2CPP.il2cpp_object_unbox(intPtr);
						}
					}
				}
			}
			else
			{
				reference = ref value;
			}
			IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_s_invalidHandle, Unsafe.AsPointer(ref reference));
		}
	}

	static SafeHandleCache()
	{
		Il2CppClassPointerStore<SafeHandleCache<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeHandleCache`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandleCache<T>>.NativeClassPtr);
		NativeFieldInfoPtr_s_invalidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandleCache<T>>.NativeClassPtr, "s_invalidHandle");
		NativeMethodInfoPtr_IsCachedInvalidHandle_Internal_Static_Boolean_SafeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleCache<T>>.NativeClassPtr, 100663828);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701109, RefRangeEnd = 701110, XrefRangeStart = 701106, XrefRangeEnd = 701109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCachedInvalidHandle(SafeHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCachedInvalidHandle_Internal_Static_Boolean_SafeHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SafeHandleCache(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
