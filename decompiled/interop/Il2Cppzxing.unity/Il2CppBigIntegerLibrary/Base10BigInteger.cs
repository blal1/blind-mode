using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppBigIntegerLibrary;

public sealed class Base10BigInteger : Il2CppSystem.Object
{
	public class DigitContainer : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_digits;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int64_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int64_0;

		public unsafe Il2CppReferenceArray<Il2CppStructArray<long>> digits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_digits);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<long>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_digits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe long this[int index]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1411346, RefRangeEnd = 1411352, XrefRangeStart = 1411346, XrefRangeEnd = 1411346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&index);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1411356, RefRangeEnd = 1411368, XrefRangeStart = 1411352, XrefRangeEnd = 1411356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = (nint)(&index);
				*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static DigitContainer()
		{
			Il2CppClassPointerStore<DigitContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, "DigitContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DigitContainer>.NativeClassPtr);
			NativeFieldInfoPtr_digits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitContainer>.NativeClassPtr, "digits");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitContainer>.NativeClassPtr, 100663324);
			NativeMethodInfoPtr_get_Item_Public_get_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitContainer>.NativeClassPtr, 100663325);
			NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitContainer>.NativeClassPtr, 100663326);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411341, XrefRangeEnd = 1411346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigitContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigitContainer>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DigitContainer(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Zero;

	private static readonly System.IntPtr NativeFieldInfoPtr_One;

	private static readonly System.IntPtr NativeFieldInfoPtr_digits;

	private static readonly System.IntPtr NativeFieldInfoPtr_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_sign;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_NumberSign_Internal_set_Void_Sign_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Opposite_Public_Static_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Greater_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GreaterOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmallerOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abs_Public_Static_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Addition_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Multiplication_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Base10BigInteger_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Private_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Subtract_Private_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Multiply_Private_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0;

	public unsafe static Base10BigInteger Zero
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Zero, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Zero, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Base10BigInteger One
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_One, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_One, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DigitContainer digits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_digits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DigitContainer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_digits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = value;
		}
	}

	public unsafe Sign sign
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sign);
			return *(Sign*)num;
		}
		set
		{
			*(Sign*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sign)) = value;
		}
	}

	public unsafe Sign NumberSign
	{
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NumberSign_Internal_set_Void_Sign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Base10BigInteger()
	{
		Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "BigIntegerLibrary", "Base10BigInteger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr);
		NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, "Zero");
		NativeFieldInfoPtr_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, "One");
		NativeFieldInfoPtr_digits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, "digits");
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, "size");
		NativeFieldInfoPtr_sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, "sign");
		NativeMethodInfoPtr_set_NumberSign_Internal_set_Void_Sign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr__ctor_Public_Void_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_Equals_Public_Boolean_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_Opposite_Public_Static_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_Greater_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_GreaterOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_SmallerOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_Abs_Public_Static_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_Addition_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_Multiplication_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Base10BigInteger_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_op_Addition_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_Add_Private_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_Subtract_Private_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_Multiply_Private_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr, 100663322);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1411379, RefRangeEnd = 1411382, XrefRangeStart = 1411368, XrefRangeEnd = 1411379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Base10BigInteger()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1411393, RefRangeEnd = 1411398, XrefRangeStart = 1411382, XrefRangeEnd = 1411393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Base10BigInteger(long n)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1411411, RefRangeEnd = 1411416, XrefRangeStart = 1411398, XrefRangeEnd = 1411411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Base10BigInteger(Base10BigInteger n)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Base10BigInteger>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Base10BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411416, XrefRangeEnd = 1411418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Base10BigInteger other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Boolean_Base10BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411418, XrefRangeEnd = 1411422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411422, XrefRangeEnd = 1411423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411423, XrefRangeEnd = 1411449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411449, XrefRangeEnd = 1411457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Base10BigInteger Opposite(Base10BigInteger n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Opposite_Public_Static_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1411461, RefRangeEnd = 1411465, XrefRangeStart = 1411457, XrefRangeEnd = 1411461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Greater(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Greater_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411465, XrefRangeEnd = 1411469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GreaterOrEqual(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GreaterOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411469, XrefRangeEnd = 1411473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SmallerOrEqual(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmallerOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1411477, RefRangeEnd = 1411481, XrefRangeStart = 1411473, XrefRangeEnd = 1411477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Base10BigInteger Abs(Base10BigInteger n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abs_Public_Static_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1411520, RefRangeEnd = 1411522, XrefRangeStart = 1411481, XrefRangeEnd = 1411520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Base10BigInteger Addition(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Addition_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411522, XrefRangeEnd = 1411536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Base10BigInteger Multiplication(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Multiplication_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411536, XrefRangeEnd = 1411540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Base10BigInteger(long n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Base10BigInteger_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411540, XrefRangeEnd = 1411541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1411548, RefRangeEnd = 1411550, XrefRangeStart = 1411541, XrefRangeEnd = 1411548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator >=(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1411557, RefRangeEnd = 1411559, XrefRangeStart = 1411550, XrefRangeEnd = 1411557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator <=(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1411570, RefRangeEnd = 1411577, XrefRangeStart = 1411559, XrefRangeEnd = 1411570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Base10BigInteger operator -(Base10BigInteger n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411577, XrefRangeEnd = 1411581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Base10BigInteger operator +(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1411598, RefRangeEnd = 1411600, XrefRangeStart = 1411581, XrefRangeEnd = 1411598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Base10BigInteger operator *(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1411611, RefRangeEnd = 1411613, XrefRangeStart = 1411600, XrefRangeEnd = 1411611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Base10BigInteger Add(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Private_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1411625, RefRangeEnd = 1411628, XrefRangeStart = 1411613, XrefRangeEnd = 1411625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Base10BigInteger Subtract(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Subtract_Private_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1411644, RefRangeEnd = 1411646, XrefRangeStart = 1411628, XrefRangeEnd = 1411644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Base10BigInteger Multiply(Base10BigInteger a, Base10BigInteger b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Multiply_Private_Static_Base10BigInteger_Base10BigInteger_Base10BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Base10BigInteger>(intPtr2) : null;
	}

	public Base10BigInteger(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
