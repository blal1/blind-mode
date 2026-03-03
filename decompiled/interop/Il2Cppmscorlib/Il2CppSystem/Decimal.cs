using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Decimal
{
	[StructLayout(LayoutKind.Explicit)]
	public struct DecCalc
	{
		[OriginalName("mscorlib.dll", "", "RoundingMode")]
		public enum RoundingMode
		{
			ToEven,
			AwayFromZero,
			Truncate,
			Floor,
			Ceiling
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct PowerOvfl
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_Hi;

			private static readonly System.IntPtr NativeFieldInfoPtr_MidLo;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0;

			[FieldOffset(0)]
			public readonly uint Hi;

			[FieldOffset(8)]
			public readonly ulong MidLo;

			static PowerOvfl()
			{
				Il2CppClassPointerStore<PowerOvfl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, "PowerOvfl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerOvfl>.NativeClassPtr);
				NativeFieldInfoPtr_Hi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerOvfl>.NativeClassPtr, "Hi");
				NativeFieldInfoPtr_MidLo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerOvfl>.NativeClassPtr, "MidLo");
				NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerOvfl>.NativeClassPtr, 100667539);
			}

			[CallerCount(0)]
			public unsafe PowerOvfl(uint hi, uint mid, uint lo)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[3];
				*ptr = (nint)(&hi);
				*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mid;
				*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lo;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unsafe Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PowerOvfl>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct Buf24
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_U0;

			private static readonly System.IntPtr NativeFieldInfoPtr_U1;

			private static readonly System.IntPtr NativeFieldInfoPtr_U2;

			private static readonly System.IntPtr NativeFieldInfoPtr_U3;

			private static readonly System.IntPtr NativeFieldInfoPtr_U4;

			private static readonly System.IntPtr NativeFieldInfoPtr_U5;

			private static readonly System.IntPtr NativeFieldInfoPtr_ulo64LE;

			private static readonly System.IntPtr NativeFieldInfoPtr_umid64LE;

			private static readonly System.IntPtr NativeFieldInfoPtr_uhigh64LE;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_set_Mid64_Public_set_Void_UInt64_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0;

			[FieldOffset(0)]
			public uint U0;

			[FieldOffset(4)]
			public uint U1;

			[FieldOffset(8)]
			public uint U2;

			[FieldOffset(12)]
			public uint U3;

			[FieldOffset(16)]
			public uint U4;

			[FieldOffset(20)]
			public uint U5;

			[FieldOffset(0)]
			public ulong ulo64LE;

			[FieldOffset(8)]
			public ulong umid64LE;

			[FieldOffset(16)]
			public ulong uhigh64LE;

			public unsafe ulong Low64
			{
				[CallerCount(255)]
				[CachedScanResults(RefRangeStart = 761723, RefRangeEnd = 761978, XrefRangeStart = 761723, XrefRangeEnd = 761978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 687877, RefRangeEnd = 687880, XrefRangeStart = 687877, XrefRangeEnd = 687880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[1];
					*ptr = (nint)(&value);
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
				}
			}

			public unsafe ulong Mid64
			{
				[CallerCount(0)]
				set
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[1];
					*ptr = (nint)(&value);
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Mid64_Public_set_Void_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
				}
			}

			public unsafe ulong High64
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 327424, RefRangeEnd = 327426, XrefRangeStart = 327424, XrefRangeEnd = 327426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[1];
					*ptr = (nint)(&value);
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
				}
			}

			static Buf24()
			{
				Il2CppClassPointerStore<Buf24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, "Buf24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buf24>.NativeClassPtr);
				NativeFieldInfoPtr_U0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buf24>.NativeClassPtr, "U0");
				NativeFieldInfoPtr_U1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buf24>.NativeClassPtr, "U1");
				NativeFieldInfoPtr_U2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buf24>.NativeClassPtr, "U2");
				NativeFieldInfoPtr_U3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buf24>.NativeClassPtr, "U3");
				NativeFieldInfoPtr_U4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buf24>.NativeClassPtr, "U4");
				NativeFieldInfoPtr_U5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buf24>.NativeClassPtr, "U5");
				NativeFieldInfoPtr_ulo64LE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buf24>.NativeClassPtr, "ulo64LE");
				NativeFieldInfoPtr_umid64LE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buf24>.NativeClassPtr, "umid64LE");
				NativeFieldInfoPtr_uhigh64LE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Buf24>.NativeClassPtr, "uhigh64LE");
				NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buf24>.NativeClassPtr, 100667540);
				NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buf24>.NativeClassPtr, 100667541);
				NativeMethodInfoPtr_set_Mid64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buf24>.NativeClassPtr, 100667542);
				NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buf24>.NativeClassPtr, 100667543);
			}

			public unsafe Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buf24>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_uflags;

		private static readonly System.IntPtr NativeFieldInfoPtr_uhi;

		private static readonly System.IntPtr NativeFieldInfoPtr_ulo;

		private static readonly System.IntPtr NativeFieldInfoPtr_umid;

		private static readonly System.IntPtr NativeFieldInfoPtr_ulomidLE;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_powers10;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_ulongPowers10;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_doublePowers10;

		private static readonly System.IntPtr NativeFieldInfoPtr_PowerOvflValues;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_High_Private_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_High_Private_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Low_Private_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Low_Private_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Mid_Private_get_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Mid_Private_set_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNegative_Private_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Low64_Private_set_Void_UInt64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UInt32x32To64_Private_Static_UInt64_UInt32_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UInt64x64To128_Private_Static_Void_UInt64_UInt64_byref_DecCalc_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Div96ByConst_Private_Static_Boolean_byref_UInt64_byref_UInt32_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Unscale_Private_Static_Void_byref_UInt32_byref_UInt64_byref_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ScaleResult_Private_Static_Int32_ptr_Buf24_UInt32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DivByConst_Private_Static_UInt32_ptr_UInt32_UInt32_byref_UInt32_byref_UInt32_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_LeadingZeroCount_Private_Static_Int32_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DecAddSub_Internal_Static_Void_byref_DecCalc_byref_DecCalc_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_VarDecCmp_Internal_Static_Int32_byref_Decimal_byref_Decimal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_VarDecCmpSub_Private_Static_Int32_byref_Decimal_byref_Decimal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_VarDecMul_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_VarDecFromR4_Internal_Static_Void_Single_byref_DecCalc_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_VarDecFromR8_Internal_Static_Void_Double_byref_DecCalc_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_VarR4FromDec_Internal_Static_Single_byref_Decimal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_VarR8FromDec_Internal_Static_Double_byref_Decimal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Internal_Static_Int32_byref_Decimal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InternalRound_Internal_Static_Void_byref_DecCalc_UInt32_RoundingMode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_DecCalc_0;

		[FieldOffset(0)]
		public uint uflags;

		[FieldOffset(4)]
		public uint uhi;

		[FieldOffset(8)]
		public uint ulo;

		[FieldOffset(12)]
		public uint umid;

		[FieldOffset(8)]
		public ulong ulomidLE;

		public unsafe static Il2CppStructArray<uint> s_powers10
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_powers10, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_powers10, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppStructArray<ulong> s_ulongPowers10
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ulongPowers10, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ulongPowers10, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppStructArray<double> s_doublePowers10
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_doublePowers10, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_doublePowers10, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppStructArray<PowerOvfl> PowerOvflValues
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PowerOvflValues, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<PowerOvfl>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PowerOvflValues, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe uint High
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_High_Private_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 376349, RefRangeEnd = 376359, XrefRangeStart = 376349, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_High_Private_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe uint Low
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Low_Private_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 765810, RefRangeEnd = 765814, XrefRangeStart = 765810, XrefRangeEnd = 765810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Low_Private_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe uint Mid
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Mid_Private_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 376360, RefRangeEnd = 376363, XrefRangeStart = 376360, XrefRangeEnd = 376363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Mid_Private_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe bool IsNegative
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 765814, RefRangeEnd = 765815, XrefRangeStart = 765814, XrefRangeEnd = 765814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNegative_Private_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe ulong Low64
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 765815, RefRangeEnd = 765844, XrefRangeStart = 765815, XrefRangeEnd = 765815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Low64_Private_set_Void_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static DecCalc()
		{
			Il2CppClassPointerStore<DecCalc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "DecCalc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecCalc>.NativeClassPtr);
			NativeFieldInfoPtr_uflags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, "uflags");
			NativeFieldInfoPtr_uhi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, "uhi");
			NativeFieldInfoPtr_ulo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, "ulo");
			NativeFieldInfoPtr_umid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, "umid");
			NativeFieldInfoPtr_ulomidLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, "ulomidLE");
			NativeFieldInfoPtr_s_powers10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, "s_powers10");
			NativeFieldInfoPtr_s_ulongPowers10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, "s_ulongPowers10");
			NativeFieldInfoPtr_s_doublePowers10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, "s_doublePowers10");
			NativeFieldInfoPtr_PowerOvflValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, "PowerOvflValues");
			NativeMethodInfoPtr_get_High_Private_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667509);
			NativeMethodInfoPtr_set_High_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667510);
			NativeMethodInfoPtr_get_Low_Private_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667511);
			NativeMethodInfoPtr_set_Low_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667512);
			NativeMethodInfoPtr_get_Mid_Private_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667513);
			NativeMethodInfoPtr_set_Mid_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667514);
			NativeMethodInfoPtr_get_IsNegative_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667515);
			NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667516);
			NativeMethodInfoPtr_set_Low64_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667517);
			NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667518);
			NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667519);
			NativeMethodInfoPtr_UInt32x32To64_Private_Static_UInt64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667520);
			NativeMethodInfoPtr_UInt64x64To128_Private_Static_Void_UInt64_UInt64_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667521);
			NativeMethodInfoPtr_Div96ByConst_Private_Static_Boolean_byref_UInt64_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667522);
			NativeMethodInfoPtr_Unscale_Private_Static_Void_byref_UInt32_byref_UInt64_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667523);
			NativeMethodInfoPtr_ScaleResult_Private_Static_Int32_ptr_Buf24_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667524);
			NativeMethodInfoPtr_DivByConst_Private_Static_UInt32_ptr_UInt32_UInt32_byref_UInt32_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667525);
			NativeMethodInfoPtr_LeadingZeroCount_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667526);
			NativeMethodInfoPtr_DecAddSub_Internal_Static_Void_byref_DecCalc_byref_DecCalc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667527);
			NativeMethodInfoPtr_VarDecCmp_Internal_Static_Int32_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667528);
			NativeMethodInfoPtr_VarDecCmpSub_Private_Static_Int32_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667529);
			NativeMethodInfoPtr_VarDecMul_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667530);
			NativeMethodInfoPtr_VarDecFromR4_Internal_Static_Void_Single_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667531);
			NativeMethodInfoPtr_VarDecFromR8_Internal_Static_Void_Double_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667532);
			NativeMethodInfoPtr_VarR4FromDec_Internal_Static_Single_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667533);
			NativeMethodInfoPtr_VarR8FromDec_Internal_Static_Double_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667534);
			NativeMethodInfoPtr_GetHashCode_Internal_Static_Int32_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667535);
			NativeMethodInfoPtr_InternalRound_Internal_Static_Void_byref_DecCalc_UInt32_RoundingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667536);
			NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, 100667537);
		}

		[CallerCount(0)]
		public unsafe static uint GetExponent(float f)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&f);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe static uint GetExponent(double d)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&d);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe static ulong UInt32x32To64(uint a, uint b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&a);
			*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UInt32x32To64_Private_Static_UInt64_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 765851, RefRangeEnd = 765853, XrefRangeStart = 765844, XrefRangeEnd = 765851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UInt64x64To128(ulong a, ulong b, ref DecCalc result)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&a);
			*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UInt64x64To128_Private_Static_Void_UInt64_UInt64_byref_DecCalc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe static bool Div96ByConst(ref ulong high64, ref uint low, uint pow)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)Unsafe.AsPointer(ref high64);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref low);
			*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pow;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Div96ByConst_Private_Static_Boolean_byref_UInt64_byref_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765853, XrefRangeEnd = 765862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Unscale(ref uint low, ref ulong high64, ref int scale)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)Unsafe.AsPointer(ref low);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref high64);
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scale);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unscale_Private_Static_Void_byref_UInt32_byref_UInt64_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765887, RefRangeEnd = 765888, XrefRangeStart = 765862, XrefRangeEnd = 765887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ScaleResult(Buf24* bufRes, uint hiRes, int scale)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)bufRes;
			*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hiRes;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScaleResult_Private_Static_Int32_ptr_Buf24_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe static uint DivByConst(uint* result, uint hiRes, out uint quotient, out uint remainder, uint power)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)result;
			*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hiRes;
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref quotient);
			*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref remainder);
			*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &power;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DivByConst_Private_Static_UInt32_ptr_UInt32_UInt32_byref_UInt32_byref_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe static int LeadingZeroCount(uint value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeadingZeroCount_Private_Static_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 765907, RefRangeEnd = 765911, XrefRangeStart = 765888, XrefRangeEnd = 765907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DecAddSub(ref DecCalc d1, ref DecCalc d2, bool sign)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)Unsafe.AsPointer(ref d1);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref d2);
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sign;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecAddSub_Internal_Static_Void_byref_DecCalc_byref_DecCalc_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 765920, RefRangeEnd = 765930, XrefRangeStart = 765911, XrefRangeEnd = 765920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int VarDecCmp([In] ref Decimal d1, [In] ref Decimal d2)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)Unsafe.AsPointer(ref d1);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref d2);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VarDecCmp_Internal_Static_Int32_byref_Decimal_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765944, RefRangeEnd = 765945, XrefRangeStart = 765930, XrefRangeEnd = 765944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int VarDecCmpSub([In] ref Decimal d1, [In] ref Decimal d2)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)Unsafe.AsPointer(ref d1);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref d2);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VarDecCmpSub_Private_Static_Int32_byref_Decimal_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765991, RefRangeEnd = 765992, XrefRangeStart = 765945, XrefRangeEnd = 765991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void VarDecMul(ref DecCalc d1, ref DecCalc d2)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)Unsafe.AsPointer(ref d1);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref d2);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VarDecMul_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766013, RefRangeEnd = 766014, XrefRangeStart = 765992, XrefRangeEnd = 766013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void VarDecFromR4(float input, out DecCalc result)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&input);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VarDecFromR4_Internal_Static_Void_Single_byref_DecCalc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766032, RefRangeEnd = 766033, XrefRangeStart = 766014, XrefRangeEnd = 766032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void VarDecFromR8(double input, out DecCalc result)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&input);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VarDecFromR8_Internal_Static_Void_Double_byref_DecCalc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766033, XrefRangeEnd = 766037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float VarR4FromDec([In] ref Decimal value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VarR4FromDec_Internal_Static_Single_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 766046, RefRangeEnd = 766051, XrefRangeStart = 766037, XrefRangeEnd = 766046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double VarR8FromDec([In] ref Decimal value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VarR8FromDec_Internal_Static_Double_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766051, XrefRangeEnd = 766062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode([In] ref Decimal d)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref d);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Internal_Static_Int32_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 766079, RefRangeEnd = 766084, XrefRangeStart = 766062, XrefRangeEnd = 766079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalRound(ref DecCalc d, uint scale, RoundingMode mode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)Unsafe.AsPointer(ref d);
			*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
			*(RoundingMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalRound_Internal_Static_Void_byref_DecCalc_UInt32_RoundingMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe static uint DecDivMod1E9(ref DecCalc value)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_DecCalc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecCalc>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Zero;

	private static readonly System.IntPtr NativeFieldInfoPtr_One;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinusOne;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_hi;

	private static readonly System.IntPtr NativeFieldInfoPtr_lo;

	private static readonly System.IntPtr NativeFieldInfoPtr_mid;

	private static readonly System.IntPtr NativeFieldInfoPtr_ulomidLE;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_High_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Low_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Mid_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNegative_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Scale_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsMutable_Private_Static_byref_DecCalc_byref_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_byref_Decimal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Static_Decimal_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_NumberStyles_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Negate_Public_Static_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Round_Private_Static_Decimal_byref_Decimal_Int32_MidpointRounding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Truncate_Private_Static_Void_byref_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Single_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Decimal_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Decimal_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Decimal_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

	[FieldOffset(0)]
	public readonly int flags;

	[FieldOffset(4)]
	public readonly int hi;

	[FieldOffset(8)]
	public readonly int lo;

	[FieldOffset(12)]
	public readonly int mid;

	[FieldOffset(8)]
	[System.NonSerialized]
	public readonly ulong ulomidLE;

	public unsafe static Decimal Zero
	{
		get
		{
			Unsafe.SkipInit(out Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Zero, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Zero, (void*)(&value));
		}
	}

	public unsafe static Decimal One
	{
		get
		{
			Unsafe.SkipInit(out Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_One, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_One, (void*)(&value));
		}
	}

	public unsafe static Decimal MinusOne
	{
		get
		{
			Unsafe.SkipInit(out Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinusOne, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinusOne, (void*)(&value));
		}
	}

	public unsafe static Decimal MaxValue
	{
		get
		{
			Unsafe.SkipInit(out Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxValue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxValue, (void*)(&value));
		}
	}

	public unsafe static Decimal MinValue
	{
		get
		{
			Unsafe.SkipInit(out Decimal result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MinValue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MinValue, (void*)(&value));
		}
	}

	public unsafe uint High
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_High_Internal_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint Low
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Low_Internal_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint Mid
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Mid_Internal_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsNegative
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765814, RefRangeEnd = 765815, XrefRangeStart = 765814, XrefRangeEnd = 765815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNegative_Internal_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int Scale
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766084, RefRangeEnd = 766085, XrefRangeStart = 766084, XrefRangeEnd = 766084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Scale_Internal_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ulong Low64
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766085, XrefRangeEnd = 766086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Decimal()
	{
		Il2CppClassPointerStore<Decimal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Decimal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decimal>.NativeClassPtr);
		NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "Zero");
		NativeFieldInfoPtr_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "One");
		NativeFieldInfoPtr_MinusOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "MinusOne");
		NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "MaxValue");
		NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "MinValue");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_hi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "hi");
		NativeFieldInfoPtr_lo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "lo");
		NativeFieldInfoPtr_mid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "mid");
		NativeFieldInfoPtr_ulomidLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "ulomidLE");
		NativeMethodInfoPtr_get_High_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667420);
		NativeMethodInfoPtr_get_Low_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667421);
		NativeMethodInfoPtr_get_Mid_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667422);
		NativeMethodInfoPtr_get_IsNegative_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667423);
		NativeMethodInfoPtr_get_Scale_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667424);
		NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667425);
		NativeMethodInfoPtr_AsMutable_Private_Static_byref_DecCalc_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667426);
		NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667427);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667428);
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667429);
		NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667430);
		NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667431);
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667432);
		NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667433);
		NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667434);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667435);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667436);
		NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667437);
		NativeMethodInfoPtr__ctor_Private_Void_byref_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667438);
		NativeMethodInfoPtr_Add_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667439);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667440);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667441);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667442);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667443);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667444);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667445);
		NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667446);
		NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667447);
		NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667448);
		NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667449);
		NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_NumberStyles_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667450);
		NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667451);
		NativeMethodInfoPtr_Negate_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667452);
		NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667453);
		NativeMethodInfoPtr_Round_Private_Static_Decimal_byref_Decimal_Int32_MidpointRounding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667454);
		NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667455);
		NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667456);
		NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667457);
		NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667458);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667459);
		NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667460);
		NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667461);
		NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667462);
		NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667463);
		NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667464);
		NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667465);
		NativeMethodInfoPtr_Truncate_Private_Static_Void_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667466);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667467);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667468);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667469);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667470);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667471);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667472);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667473);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667474);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667475);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667476);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667477);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667478);
		NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667479);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Single_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667480);
		NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667481);
		NativeMethodInfoPtr_op_Increment_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667482);
		NativeMethodInfoPtr_op_Addition_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667483);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667484);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667485);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667486);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667487);
		NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667488);
		NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667489);
		NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667490);
		NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667491);
		NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667492);
		NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667493);
		NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667494);
		NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667495);
		NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667496);
		NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667497);
		NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667498);
		NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667499);
		NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667500);
		NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667501);
		NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667502);
		NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667503);
		NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667504);
		NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667505);
		NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667506);
		NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667507);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ref DecCalc AsMutable(ref Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsMutable_Private_Static_byref_DecCalc_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(DecCalc*)intPtr2;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766092, RefRangeEnd = 766093, XrefRangeStart = 766086, XrefRangeEnd = 766092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint DecDivMod1E9(ref Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 766093, RefRangeEnd = 766097, XrefRangeStart = 766093, XrefRangeEnd = 766093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Decimal(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe Decimal(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 766097, RefRangeEnd = 766099, XrefRangeStart = 766097, XrefRangeEnd = 766097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Decimal(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766099, RefRangeEnd = 766100, XrefRangeStart = 766099, XrefRangeEnd = 766099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Decimal(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766107, RefRangeEnd = 766108, XrefRangeStart = 766100, XrefRangeEnd = 766107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Decimal(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 766115, RefRangeEnd = 766117, XrefRangeStart = 766108, XrefRangeEnd = 766115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Decimal(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool IsValid(int flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 766120, RefRangeEnd = 766122, XrefRangeStart = 766117, XrefRangeEnd = 766120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Decimal(Il2CppStructArray<int> bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 766122, RefRangeEnd = 766156, XrefRangeStart = 766122, XrefRangeEnd = 766122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&lo);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mid;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isNegative;
		*(byte**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766156, XrefRangeEnd = 766159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe Decimal([In] ref Decimal d, int flags)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref d);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_byref_Decimal_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766159, XrefRangeEnd = 766166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal Add(Decimal d1, Decimal d2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d1);
		*(Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Static_Decimal_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766173, RefRangeEnd = 766174, XrefRangeStart = 766166, XrefRangeEnd = 766173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int CompareTo(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766174, XrefRangeEnd = 766178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int CompareTo(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766178, XrefRangeEnd = 766185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766185, XrefRangeEnd = 766189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Decimal_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766203, RefRangeEnd = 766204, XrefRangeStart = 766189, XrefRangeEnd = 766203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766204, XrefRangeEnd = 766212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 766220, RefRangeEnd = 766222, XrefRangeStart = 766212, XrefRangeEnd = 766220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string ToString(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766230, RefRangeEnd = 766231, XrefRangeStart = 766222, XrefRangeEnd = 766230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string ToString(string format, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766231, XrefRangeEnd = 766236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 766245, RefRangeEnd = 766247, XrefRangeStart = 766236, XrefRangeEnd = 766245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal Parse(string s, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 766257, RefRangeEnd = 766260, XrefRangeStart = 766247, XrefRangeEnd = 766257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_NumberStyles_IFormatProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 766269, RefRangeEnd = 766271, XrefRangeStart = 766260, XrefRangeEnd = 766269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(NumberStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &style;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766271, RefRangeEnd = 766272, XrefRangeStart = 766271, XrefRangeEnd = 766271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal Negate(Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Negate_Public_Static_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 766284, RefRangeEnd = 766292, XrefRangeStart = 766272, XrefRangeEnd = 766284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal Round(Decimal d, int decimals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimals;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766292, XrefRangeEnd = 766301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal Round(ref Decimal d, int decimals, MidpointRounding mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref d);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &decimals;
		*(MidpointRounding**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Round_Private_Static_Decimal_byref_Decimal_Int32_MidpointRounding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766305, RefRangeEnd = 766306, XrefRangeStart = 766301, XrefRangeEnd = 766305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ToByte(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766310, RefRangeEnd = 766311, XrefRangeStart = 766306, XrefRangeEnd = 766310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte ToSByte(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766315, RefRangeEnd = 766316, XrefRangeStart = 766311, XrefRangeEnd = 766315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ToInt16(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766316, XrefRangeEnd = 766320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 766326, RefRangeEnd = 766330, XrefRangeStart = 766320, XrefRangeEnd = 766326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766337, RefRangeEnd = 766338, XrefRangeStart = 766330, XrefRangeEnd = 766337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long ToInt64(Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766342, RefRangeEnd = 766343, XrefRangeStart = 766338, XrefRangeEnd = 766342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ushort ToUInt16(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 766349, RefRangeEnd = 766352, XrefRangeStart = 766343, XrefRangeEnd = 766349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ToUInt32(Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766359, RefRangeEnd = 766360, XrefRangeStart = 766352, XrefRangeEnd = 766359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong ToUInt64(Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766360, XrefRangeEnd = 766367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 766371, RefRangeEnd = 766375, XrefRangeStart = 766367, XrefRangeEnd = 766371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal Truncate(Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766375, XrefRangeEnd = 766382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Truncate(ref Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Truncate_Private_Static_Void_byref_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 766382, RefRangeEnd = 766384, XrefRangeStart = 766382, XrefRangeEnd = 766382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Decimal(byte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766384, RefRangeEnd = 766385, XrefRangeStart = 766384, XrefRangeEnd = 766384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Decimal(sbyte value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 766385, RefRangeEnd = 766387, XrefRangeStart = 766385, XrefRangeEnd = 766385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Decimal(short value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766387, RefRangeEnd = 766388, XrefRangeStart = 766387, XrefRangeEnd = 766387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Decimal(ushort value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 766388, RefRangeEnd = 766396, XrefRangeStart = 766388, XrefRangeEnd = 766388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Decimal(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766396, RefRangeEnd = 766397, XrefRangeStart = 766396, XrefRangeEnd = 766396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Decimal(uint value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 766397, RefRangeEnd = 766401, XrefRangeStart = 766397, XrefRangeEnd = 766397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Decimal(long value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 766401, RefRangeEnd = 766405, XrefRangeStart = 766401, XrefRangeEnd = 766401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Decimal(ulong value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 766406, RefRangeEnd = 766408, XrefRangeStart = 766405, XrefRangeEnd = 766406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator Decimal(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766409, RefRangeEnd = 766410, XrefRangeStart = 766408, XrefRangeEnd = 766409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator Decimal(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766414, RefRangeEnd = 766415, XrefRangeStart = 766410, XrefRangeEnd = 766414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator int(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 766431, RefRangeEnd = 766434, XrefRangeStart = 766415, XrefRangeEnd = 766431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator long(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766450, RefRangeEnd = 766451, XrefRangeStart = 766434, XrefRangeEnd = 766450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator ulong(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766461, RefRangeEnd = 766462, XrefRangeStart = 766451, XrefRangeEnd = 766461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator float(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Single_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766469, RefRangeEnd = 766470, XrefRangeStart = 766462, XrefRangeEnd = 766469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator double(Decimal value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 766481, RefRangeEnd = 766482, XrefRangeStart = 766470, XrefRangeEnd = 766481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal operator ++(Decimal d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Increment_Public_Static_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 766489, RefRangeEnd = 766494, XrefRangeStart = 766482, XrefRangeEnd = 766489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal operator +(Decimal d1, Decimal d2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d1);
		*(Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_Decimal_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 766501, RefRangeEnd = 766504, XrefRangeStart = 766494, XrefRangeEnd = 766501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal operator -(Decimal d1, Decimal d2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d1);
		*(Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Subtraction_Public_Static_Decimal_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 766511, RefRangeEnd = 766523, XrefRangeStart = 766504, XrefRangeEnd = 766511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Decimal operator *(Decimal d1, Decimal d2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d1);
		*(Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Decimal_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 766527, RefRangeEnd = 766574, XrefRangeStart = 766523, XrefRangeEnd = 766527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(Decimal d1, Decimal d2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d1);
		*(Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 766578, RefRangeEnd = 766614, XrefRangeStart = 766574, XrefRangeEnd = 766578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(Decimal d1, Decimal d2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d1);
		*(Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 766618, RefRangeEnd = 766629, XrefRangeStart = 766614, XrefRangeEnd = 766618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator <(Decimal d1, Decimal d2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d1);
		*(Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 766633, RefRangeEnd = 766645, XrefRangeStart = 766629, XrefRangeEnd = 766633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator <=(Decimal d1, Decimal d2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d1);
		*(Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 766649, RefRangeEnd = 766661, XrefRangeStart = 766645, XrefRangeEnd = 766649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator >(Decimal d1, Decimal d2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d1);
		*(Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766661, XrefRangeEnd = 766665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator >=(Decimal d1, Decimal d2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&d1);
		*(Decimal**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &d2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual TypeCode GetTypeCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TypeCode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766665, XrefRangeEnd = 766669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool System_IConvertible_ToBoolean(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766669, XrefRangeEnd = 766678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual char System_IConvertible_ToChar(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766678, XrefRangeEnd = 766682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual sbyte System_IConvertible_ToSByte(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766682, XrefRangeEnd = 766686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual byte System_IConvertible_ToByte(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766686, XrefRangeEnd = 766690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual short System_IConvertible_ToInt16(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766690, XrefRangeEnd = 766694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ushort System_IConvertible_ToUInt16(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766694, XrefRangeEnd = 766698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int System_IConvertible_ToInt32(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766698, XrefRangeEnd = 766702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual uint System_IConvertible_ToUInt32(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766702, XrefRangeEnd = 766706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual long System_IConvertible_ToInt64(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766706, XrefRangeEnd = 766710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ulong System_IConvertible_ToUInt64(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766710, XrefRangeEnd = 766714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual float System_IConvertible_ToSingle(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766714, XrefRangeEnd = 766718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual double System_IConvertible_ToDouble(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 732551, RefRangeEnd = 732556, XrefRangeStart = 732551, XrefRangeEnd = 732556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Decimal*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766718, XrefRangeEnd = 766727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766727, XrefRangeEnd = 766734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Object System_IConvertible_ToType(Type type, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Decimal>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
