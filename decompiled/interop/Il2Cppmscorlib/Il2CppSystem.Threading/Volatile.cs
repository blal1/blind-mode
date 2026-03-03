using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading;

public static class Volatile : Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct VolatileInt32
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Value;

		[FieldOffset(0)]
		public int Value;

		static VolatileInt32()
		{
			Il2CppClassPointerStore<VolatileInt32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Volatile>.NativeClassPtr, "VolatileInt32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolatileInt32>.NativeClassPtr);
			NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolatileInt32>.NativeClassPtr, "Value");
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolatileInt32>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class VolatileObject : ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Value;

		public unsafe Object Value
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Value)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static VolatileObject()
		{
			Il2CppClassPointerStore<VolatileObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Volatile>.NativeClassPtr, "VolatileObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolatileObject>.NativeClassPtr);
			NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolatileObject>.NativeClassPtr, "Value");
		}

		public VolatileObject(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public VolatileObject()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolatileObject>.NativeClassPtr))
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_Read_Public_Static_T_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0, Il2CppClassPointerStore<Volatile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Write_Public_Static_Void_byref_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0, Il2CppClassPointerStore<Volatile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Static_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_byref_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0;

	static Volatile()
	{
		Il2CppClassPointerStore<Volatile>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Volatile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Volatile>.NativeClassPtr);
		NativeMethodInfoPtr_Read_Public_Static_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100668089);
		NativeMethodInfoPtr_Write_Public_Static_Void_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100668090);
		NativeMethodInfoPtr_Read_Public_Static_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100668091);
		NativeMethodInfoPtr_Write_Public_Static_Void_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volatile>.NativeClassPtr, 100668092);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772615, XrefRangeEnd = 772616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Read(ref int location)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref location);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Read_Public_Static_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772616, XrefRangeEnd = 772617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Write(ref int location, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref location);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Public_Static_Void_byref_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772617, XrefRangeEnd = 772618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Read<T>(ref T location) where T : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)location);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Read_Public_Static_T_byref_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		location = ((intPtr4 == (System.IntPtr)0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772618, XrefRangeEnd = 772620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Write<T>(ref T location, T value) where T : class
	{
		//IL_005c->IL005f: Incompatible stack types: I vs Ref
		//IL_004f->IL005f: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)location);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = value;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Write_Public_Static_Void_byref_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		location = ((intPtr4 == (System.IntPtr)0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	public Volatile(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
