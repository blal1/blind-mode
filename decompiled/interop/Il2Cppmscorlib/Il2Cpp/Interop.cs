using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2Cpp;

public static class Interop : Il2CppSystem.Object
{
	public static class Kernel32 : Il2CppSystem.Object
	{
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct WIN32_FIND_DATA
		{
			[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
			[ObfuscatedName("Interop+Kernel32+WIN32_FIND_DATA+<_cFileName>e__FixedBuffer")]
			public struct __cFileName_e__FixedBuffer
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

				[FieldOffset(0)]
				public char FixedElementField;

				static __cFileName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<__cFileName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "<_cFileName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__cFileName_e__FixedBuffer>.NativeClassPtr);
					NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__cFileName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				public unsafe Il2CppSystem.Object BoxIl2CppObject()
				{
					return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__cFileName_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
				}
			}

			[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
			[ObfuscatedName("Interop+Kernel32+WIN32_FIND_DATA+<_cAlternateFileName>e__FixedBuffer")]
			public struct __cAlternateFileName_e__FixedBuffer
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

				[FieldOffset(0)]
				public char FixedElementField;

				static __cAlternateFileName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<__cAlternateFileName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "<_cAlternateFileName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__cAlternateFileName_e__FixedBuffer>.NativeClassPtr);
					NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__cAlternateFileName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				public unsafe Il2CppSystem.Object BoxIl2CppObject()
				{
					return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__cAlternateFileName_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
				}
			}

			private static readonly System.IntPtr NativeFieldInfoPtr_dwFileAttributes;

			private static readonly System.IntPtr NativeFieldInfoPtr_ftCreationTime;

			private static readonly System.IntPtr NativeFieldInfoPtr_ftLastAccessTime;

			private static readonly System.IntPtr NativeFieldInfoPtr_ftLastWriteTime;

			private static readonly System.IntPtr NativeFieldInfoPtr_nFileSizeHigh;

			private static readonly System.IntPtr NativeFieldInfoPtr_nFileSizeLow;

			private static readonly System.IntPtr NativeFieldInfoPtr_dwReserved0;

			private static readonly System.IntPtr NativeFieldInfoPtr_dwReserved1;

			private static readonly System.IntPtr NativeFieldInfoPtr__cFileName;

			private static readonly System.IntPtr NativeFieldInfoPtr__cAlternateFileName;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_cFileName_Internal_get_ReadOnlySpan_1_Char_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_SetFileName_Internal_Void_String_0;

			[FieldOffset(0)]
			public uint dwFileAttributes;

			[FieldOffset(4)]
			public FILE_TIME ftCreationTime;

			[FieldOffset(12)]
			public FILE_TIME ftLastAccessTime;

			[FieldOffset(20)]
			public FILE_TIME ftLastWriteTime;

			[FieldOffset(28)]
			public uint nFileSizeHigh;

			[FieldOffset(32)]
			public uint nFileSizeLow;

			[FieldOffset(36)]
			public uint dwReserved0;

			[FieldOffset(40)]
			public uint dwReserved1;

			[FieldOffset(44)]
			public __cFileName_e__FixedBuffer _cFileName;

			[FieldOffset(564)]
			public __cAlternateFileName_e__FixedBuffer _cAlternateFileName;

			public unsafe Il2CppSystem.ReadOnlySpan<char> cFileName
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 695934, RefRangeEnd = 695938, XrefRangeStart = 695933, XrefRangeEnd = 695934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cFileName_Internal_get_ReadOnlySpan_1_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new Il2CppSystem.ReadOnlySpan<char>(pointer);
				}
			}

			static WIN32_FIND_DATA()
			{
				Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, "WIN32_FIND_DATA");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr);
				NativeFieldInfoPtr_dwFileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "dwFileAttributes");
				NativeFieldInfoPtr_ftCreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "ftCreationTime");
				NativeFieldInfoPtr_ftLastAccessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "ftLastAccessTime");
				NativeFieldInfoPtr_ftLastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "ftLastWriteTime");
				NativeFieldInfoPtr_nFileSizeHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "nFileSizeHigh");
				NativeFieldInfoPtr_nFileSizeLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "nFileSizeLow");
				NativeFieldInfoPtr_dwReserved0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "dwReserved0");
				NativeFieldInfoPtr_dwReserved1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "dwReserved1");
				NativeFieldInfoPtr__cFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "_cFileName");
				NativeFieldInfoPtr__cAlternateFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, "_cAlternateFileName");
				NativeMethodInfoPtr_get_cFileName_Internal_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, 100663327);
				NativeMethodInfoPtr_SetFileName_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, 100663328);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 695943, RefRangeEnd = 695946, XrefRangeStart = 695938, XrefRangeEnd = 695943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFileName(string fileName)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFileName_Internal_Void_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WIN32_FIND_DATA>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct REG_TZI_FORMAT
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_Bias;

			private static readonly System.IntPtr NativeFieldInfoPtr_StandardBias;

			private static readonly System.IntPtr NativeFieldInfoPtr_DaylightBias;

			private static readonly System.IntPtr NativeFieldInfoPtr_StandardDate;

			private static readonly System.IntPtr NativeFieldInfoPtr_DaylightDate;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_ZONE_INFORMATION_0;

			[FieldOffset(0)]
			public int Bias;

			[FieldOffset(4)]
			public int StandardBias;

			[FieldOffset(8)]
			public int DaylightBias;

			[FieldOffset(12)]
			public SYSTEMTIME StandardDate;

			[FieldOffset(28)]
			public SYSTEMTIME DaylightDate;

			static REG_TZI_FORMAT()
			{
				Il2CppClassPointerStore<REG_TZI_FORMAT>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, "REG_TZI_FORMAT");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<REG_TZI_FORMAT>.NativeClassPtr);
				NativeFieldInfoPtr_Bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<REG_TZI_FORMAT>.NativeClassPtr, "Bias");
				NativeFieldInfoPtr_StandardBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<REG_TZI_FORMAT>.NativeClassPtr, "StandardBias");
				NativeFieldInfoPtr_DaylightBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<REG_TZI_FORMAT>.NativeClassPtr, "DaylightBias");
				NativeFieldInfoPtr_StandardDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<REG_TZI_FORMAT>.NativeClassPtr, "StandardDate");
				NativeFieldInfoPtr_DaylightDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<REG_TZI_FORMAT>.NativeClassPtr, "DaylightDate");
				NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<REG_TZI_FORMAT>.NativeClassPtr, 100663329);
			}

			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 695946, RefRangeEnd = 695947, XrefRangeStart = 695946, XrefRangeEnd = 695946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe REG_TZI_FORMAT([In] ref TIME_ZONE_INFORMATION tzi)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)Unsafe.AsPointer(ref tzi);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_ZONE_INFORMATION_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<REG_TZI_FORMAT>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct SYSTEMTIME
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_Year;

			private static readonly System.IntPtr NativeFieldInfoPtr_Month;

			private static readonly System.IntPtr NativeFieldInfoPtr_DayOfWeek;

			private static readonly System.IntPtr NativeFieldInfoPtr_Day;

			private static readonly System.IntPtr NativeFieldInfoPtr_Hour;

			private static readonly System.IntPtr NativeFieldInfoPtr_Minute;

			private static readonly System.IntPtr NativeFieldInfoPtr_Second;

			private static readonly System.IntPtr NativeFieldInfoPtr_Milliseconds;

			private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Internal_Boolean_byref_SYSTEMTIME_0;

			[FieldOffset(0)]
			public ushort Year;

			[FieldOffset(2)]
			public ushort Month;

			[FieldOffset(4)]
			public ushort DayOfWeek;

			[FieldOffset(6)]
			public ushort Day;

			[FieldOffset(8)]
			public ushort Hour;

			[FieldOffset(10)]
			public ushort Minute;

			[FieldOffset(12)]
			public ushort Second;

			[FieldOffset(14)]
			public ushort Milliseconds;

			static SYSTEMTIME()
			{
				Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, "SYSTEMTIME");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr);
				NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr, "Year");
				NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr, "Month");
				NativeFieldInfoPtr_DayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr, "DayOfWeek");
				NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr, "Day");
				NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr, "Hour");
				NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr, "Minute");
				NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr, "Second");
				NativeFieldInfoPtr_Milliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr, "Milliseconds");
				NativeMethodInfoPtr_Equals_Internal_Boolean_byref_SYSTEMTIME_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr, 100663330);
			}

			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 695947, RefRangeEnd = 695952, XrefRangeStart = 695947, XrefRangeEnd = 695947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals([In] ref SYSTEMTIME other)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)Unsafe.AsPointer(ref other);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Internal_Boolean_byref_SYSTEMTIME_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SYSTEMTIME>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct TIME_DYNAMIC_ZONE_INFORMATION
		{
			[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
			[ObfuscatedName("Interop+Kernel32+TIME_DYNAMIC_ZONE_INFORMATION+<StandardName>e__FixedBuffer")]
			public struct _StandardName_e__FixedBuffer
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

				[FieldOffset(0)]
				public char FixedElementField;

				static _StandardName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<_StandardName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "<StandardName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_StandardName_e__FixedBuffer>.NativeClassPtr);
					NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_StandardName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				public unsafe Il2CppSystem.Object BoxIl2CppObject()
				{
					return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_StandardName_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
				}
			}

			[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
			[ObfuscatedName("Interop+Kernel32+TIME_DYNAMIC_ZONE_INFORMATION+<DaylightName>e__FixedBuffer")]
			public struct _DaylightName_e__FixedBuffer
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

				[FieldOffset(0)]
				public char FixedElementField;

				static _DaylightName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<_DaylightName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "<DaylightName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_DaylightName_e__FixedBuffer>.NativeClassPtr);
					NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_DaylightName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				public unsafe Il2CppSystem.Object BoxIl2CppObject()
				{
					return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_DaylightName_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
				}
			}

			[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
			[ObfuscatedName("Interop+Kernel32+TIME_DYNAMIC_ZONE_INFORMATION+<TimeZoneKeyName>e__FixedBuffer")]
			public struct _TimeZoneKeyName_e__FixedBuffer
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

				[FieldOffset(0)]
				public char FixedElementField;

				static _TimeZoneKeyName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<_TimeZoneKeyName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "<TimeZoneKeyName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_TimeZoneKeyName_e__FixedBuffer>.NativeClassPtr);
					NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_TimeZoneKeyName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				public unsafe Il2CppSystem.Object BoxIl2CppObject()
				{
					return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_TimeZoneKeyName_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
				}
			}

			private static readonly System.IntPtr NativeFieldInfoPtr_Bias;

			private static readonly System.IntPtr NativeFieldInfoPtr_StandardName;

			private static readonly System.IntPtr NativeFieldInfoPtr_StandardDate;

			private static readonly System.IntPtr NativeFieldInfoPtr_StandardBias;

			private static readonly System.IntPtr NativeFieldInfoPtr_DaylightName;

			private static readonly System.IntPtr NativeFieldInfoPtr_DaylightDate;

			private static readonly System.IntPtr NativeFieldInfoPtr_DaylightBias;

			private static readonly System.IntPtr NativeFieldInfoPtr_TimeZoneKeyName;

			private static readonly System.IntPtr NativeFieldInfoPtr_DynamicDaylightTimeDisabled;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeZoneKeyName_Internal_String_0;

			[FieldOffset(0)]
			public int Bias;

			[FieldOffset(4)]
			public _StandardName_e__FixedBuffer StandardName;

			[FieldOffset(68)]
			public SYSTEMTIME StandardDate;

			[FieldOffset(84)]
			public int StandardBias;

			[FieldOffset(88)]
			public _DaylightName_e__FixedBuffer DaylightName;

			[FieldOffset(152)]
			public SYSTEMTIME DaylightDate;

			[FieldOffset(168)]
			public int DaylightBias;

			[FieldOffset(172)]
			public _TimeZoneKeyName_e__FixedBuffer TimeZoneKeyName;

			[FieldOffset(428)]
			public byte DynamicDaylightTimeDisabled;

			static TIME_DYNAMIC_ZONE_INFORMATION()
			{
				Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, "TIME_DYNAMIC_ZONE_INFORMATION");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr);
				NativeFieldInfoPtr_Bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "Bias");
				NativeFieldInfoPtr_StandardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "StandardName");
				NativeFieldInfoPtr_StandardDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "StandardDate");
				NativeFieldInfoPtr_StandardBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "StandardBias");
				NativeFieldInfoPtr_DaylightName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "DaylightName");
				NativeFieldInfoPtr_DaylightDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "DaylightDate");
				NativeFieldInfoPtr_DaylightBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "DaylightBias");
				NativeFieldInfoPtr_TimeZoneKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "TimeZoneKeyName");
				NativeFieldInfoPtr_DynamicDaylightTimeDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, "DynamicDaylightTimeDisabled");
				NativeMethodInfoPtr_GetTimeZoneKeyName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, 100663331);
			}

			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 695953, RefRangeEnd = 695954, XrefRangeStart = 695952, XrefRangeEnd = 695953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetTimeZoneKeyName()
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeZoneKeyName_Internal_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TIME_DYNAMIC_ZONE_INFORMATION>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct TIME_ZONE_INFORMATION
		{
			[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
			[ObfuscatedName("Interop+Kernel32+TIME_ZONE_INFORMATION+<StandardName>e__FixedBuffer")]
			public struct _StandardName_e__FixedBuffer
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

				[FieldOffset(0)]
				public char FixedElementField;

				static _StandardName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<_StandardName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, "<StandardName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_StandardName_e__FixedBuffer>.NativeClassPtr);
					NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_StandardName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				public unsafe Il2CppSystem.Object BoxIl2CppObject()
				{
					return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_StandardName_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
				}
			}

			[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
			[ObfuscatedName("Interop+Kernel32+TIME_ZONE_INFORMATION+<DaylightName>e__FixedBuffer")]
			public struct _DaylightName_e__FixedBuffer
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

				[FieldOffset(0)]
				public char FixedElementField;

				static _DaylightName_e__FixedBuffer()
				{
					Il2CppClassPointerStore<_DaylightName_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, "<DaylightName>e__FixedBuffer");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_DaylightName_e__FixedBuffer>.NativeClassPtr);
					NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_DaylightName_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
				}

				public unsafe Il2CppSystem.Object BoxIl2CppObject()
				{
					return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_DaylightName_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
				}
			}

			private static readonly System.IntPtr NativeFieldInfoPtr_Bias;

			private static readonly System.IntPtr NativeFieldInfoPtr_StandardName;

			private static readonly System.IntPtr NativeFieldInfoPtr_StandardDate;

			private static readonly System.IntPtr NativeFieldInfoPtr_StandardBias;

			private static readonly System.IntPtr NativeFieldInfoPtr_DaylightName;

			private static readonly System.IntPtr NativeFieldInfoPtr_DaylightDate;

			private static readonly System.IntPtr NativeFieldInfoPtr_DaylightBias;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_DYNAMIC_ZONE_INFORMATION_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetStandardName_Internal_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetDaylightName_Internal_String_0;

			[FieldOffset(0)]
			public int Bias;

			[FieldOffset(4)]
			public _StandardName_e__FixedBuffer StandardName;

			[FieldOffset(68)]
			public SYSTEMTIME StandardDate;

			[FieldOffset(84)]
			public int StandardBias;

			[FieldOffset(88)]
			public _DaylightName_e__FixedBuffer DaylightName;

			[FieldOffset(152)]
			public SYSTEMTIME DaylightDate;

			[FieldOffset(168)]
			public int DaylightBias;

			static TIME_ZONE_INFORMATION()
			{
				Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, "TIME_ZONE_INFORMATION");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr);
				NativeFieldInfoPtr_Bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, "Bias");
				NativeFieldInfoPtr_StandardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardName");
				NativeFieldInfoPtr_StandardDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardDate");
				NativeFieldInfoPtr_StandardBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, "StandardBias");
				NativeFieldInfoPtr_DaylightName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightName");
				NativeFieldInfoPtr_DaylightDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightDate");
				NativeFieldInfoPtr_DaylightBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, "DaylightBias");
				NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_DYNAMIC_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, 100663332);
				NativeMethodInfoPtr_GetStandardName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, 100663333);
				NativeMethodInfoPtr_GetDaylightName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, 100663334);
			}

			[CallerCount(0)]
			public unsafe TIME_ZONE_INFORMATION([In] ref TIME_DYNAMIC_ZONE_INFORMATION dtzi)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)Unsafe.AsPointer(ref dtzi);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_byref_TIME_DYNAMIC_ZONE_INFORMATION_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 695955, RefRangeEnd = 695959, XrefRangeStart = 695954, XrefRangeEnd = 695955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetStandardName()
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStandardName_Internal_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 695960, RefRangeEnd = 695962, XrefRangeStart = 695959, XrefRangeEnd = 695960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetDaylightName()
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDaylightName_Internal_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TIME_ZONE_INFORMATION>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[OriginalName("mscorlib.dll", "", "FILE_INFO_BY_HANDLE_CLASS")]
		public enum FILE_INFO_BY_HANDLE_CLASS : uint
		{
			FileBasicInfo,
			FileStandardInfo,
			FileNameInfo,
			FileRenameInfo,
			FileDispositionInfo,
			FileAllocationInfo,
			FileEndOfFileInfo,
			FileStreamInfo,
			FileCompressionInfo,
			FileAttributeTagInfo,
			FileIdBothDirectoryInfo,
			FileIdBothDirectoryRestartInfo,
			FileIoPriorityHintInfo,
			FileRemoteProtocolInfo,
			FileFullDirectoryInfo,
			FileFullDirectoryRestartInfo
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct FILE_TIME
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_dwLowDateTime;

			private static readonly System.IntPtr NativeFieldInfoPtr_dwHighDateTime;

			[FieldOffset(0)]
			public uint dwLowDateTime;

			[FieldOffset(4)]
			public uint dwHighDateTime;

			static FILE_TIME()
			{
				Il2CppClassPointerStore<FILE_TIME>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, "FILE_TIME");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FILE_TIME>.NativeClassPtr);
				NativeFieldInfoPtr_dwLowDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_TIME>.NativeClassPtr, "dwLowDateTime");
				NativeFieldInfoPtr_dwHighDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_TIME>.NativeClassPtr, "dwHighDateTime");
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FILE_TIME>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[OriginalName("mscorlib.dll", "", "FINDEX_INFO_LEVELS")]
		public enum FINDEX_INFO_LEVELS : uint
		{
			FindExInfoStandard,
			FindExInfoBasic,
			FindExInfoMaxInfoLevel
		}

		[OriginalName("mscorlib.dll", "", "FINDEX_SEARCH_OPS")]
		public enum FINDEX_SEARCH_OPS : uint
		{
			FindExSearchNameMatch,
			FindExSearchLimitToDirectories,
			FindExSearchLimitToDevices,
			FindExSearchMaxSearchOp
		}

		[OriginalName("mscorlib.dll", "", "GET_FILEEX_INFO_LEVELS")]
		public enum GET_FILEEX_INFO_LEVELS : uint
		{
			GetFileExInfoStandard,
			GetFileExMaxInfoLevel
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct SECURITY_ATTRIBUTES
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_nLength;

			private static readonly System.IntPtr NativeFieldInfoPtr_lpSecurityDescriptor;

			private static readonly System.IntPtr NativeFieldInfoPtr_bInheritHandle;

			[FieldOffset(0)]
			public uint nLength;

			[FieldOffset(8)]
			public System.IntPtr lpSecurityDescriptor;

			[FieldOffset(16)]
			public BOOL bInheritHandle;

			static SECURITY_ATTRIBUTES()
			{
				Il2CppClassPointerStore<SECURITY_ATTRIBUTES>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, "SECURITY_ATTRIBUTES");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECURITY_ATTRIBUTES>.NativeClassPtr);
				NativeFieldInfoPtr_nLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECURITY_ATTRIBUTES>.NativeClassPtr, "nLength");
				NativeFieldInfoPtr_lpSecurityDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECURITY_ATTRIBUTES>.NativeClassPtr, "lpSecurityDescriptor");
				NativeFieldInfoPtr_bInheritHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECURITY_ATTRIBUTES>.NativeClassPtr, "bInheritHandle");
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECURITY_ATTRIBUTES>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct WIN32_FILE_ATTRIBUTE_DATA
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_dwFileAttributes;

			private static readonly System.IntPtr NativeFieldInfoPtr_ftCreationTime;

			private static readonly System.IntPtr NativeFieldInfoPtr_ftLastAccessTime;

			private static readonly System.IntPtr NativeFieldInfoPtr_ftLastWriteTime;

			private static readonly System.IntPtr NativeFieldInfoPtr_nFileSizeHigh;

			private static readonly System.IntPtr NativeFieldInfoPtr_nFileSizeLow;

			private static readonly System.IntPtr NativeMethodInfoPtr_PopulateFrom_Internal_Void_byref_WIN32_FIND_DATA_0;

			[FieldOffset(0)]
			public int dwFileAttributes;

			[FieldOffset(4)]
			public FILE_TIME ftCreationTime;

			[FieldOffset(12)]
			public FILE_TIME ftLastAccessTime;

			[FieldOffset(20)]
			public FILE_TIME ftLastWriteTime;

			[FieldOffset(28)]
			public uint nFileSizeHigh;

			[FieldOffset(32)]
			public uint nFileSizeLow;

			static WIN32_FILE_ATTRIBUTE_DATA()
			{
				Il2CppClassPointerStore<WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, "WIN32_FILE_ATTRIBUTE_DATA");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr);
				NativeFieldInfoPtr_dwFileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "dwFileAttributes");
				NativeFieldInfoPtr_ftCreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "ftCreationTime");
				NativeFieldInfoPtr_ftLastAccessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "ftLastAccessTime");
				NativeFieldInfoPtr_ftLastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "ftLastWriteTime");
				NativeFieldInfoPtr_nFileSizeHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "nFileSizeHigh");
				NativeFieldInfoPtr_nFileSizeLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, "nFileSizeLow");
				NativeMethodInfoPtr_PopulateFrom_Internal_Void_byref_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, 100663335);
			}

			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 695962, RefRangeEnd = 695963, XrefRangeStart = 695962, XrefRangeEnd = 695962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PopulateFrom(ref WIN32_FIND_DATA findData)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)Unsafe.AsPointer(ref findData);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateFrom_Internal_Void_byref_WIN32_FIND_DATA_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WIN32_FILE_ATTRIBUTE_DATA>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_DeleteVolumeMountPointPrivate_Internal_Static_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DeleteVolumeMountPoint_Internal_Static_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FreeLibrary_Internal_Static_Boolean_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_LoadLibraryEx_Internal_Static_SafeLibraryHandle_String_IntPtr_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFileMUIPath_Internal_Static_Boolean_UInt32_String_StringBuilder_byref_Int32_StringBuilder_byref_Int32_byref_Int64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_TIME_DYNAMIC_ZONE_INFORMATION_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeZoneInformation_Internal_Static_UInt32_byref_TIME_ZONE_INFORMATION_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CloseHandle_Internal_Static_Boolean_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateDirectoryPrivate_Private_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateDirectory_Internal_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateFilePrivate_Private_Static_IntPtr_String_Int32_FileShare_ptr_SECURITY_ATTRIBUTES_FileMode_Int32_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateFile_IntPtr_Internal_Static_IntPtr_String_Int32_FileShare_FileMode_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFilePrivate_Private_Static_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFile_Internal_Static_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstFileExPrivate_Private_Static_SafeFindHandle_String_FINDEX_INFO_LEVELS_byref_WIN32_FIND_DATA_FINDEX_SEARCH_OPS_IntPtr_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstFile_Internal_Static_SafeFindHandle_String_byref_WIN32_FIND_DATA_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FindNextFile_Internal_Static_Boolean_SafeFindHandle_byref_WIN32_FIND_DATA_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FormatMessage_Private_Static_Int32_Int32_IntPtr_UInt32_Int32_ptr_Char_Int32_Il2CppStructArray_1_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMessage_Internal_Static_String_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMessage_Internal_Static_String_IntPtr_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryGetErrorMessage_Private_Static_Boolean_IntPtr_Int32_Span_1_Char_byref_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFileAttributesExPrivate_Private_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFileAttributesEx_Internal_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetFileInformationByHandleEx_Public_Static_Boolean_IntPtr_FILE_INFO_BY_HANDLE_CLASS_IntPtr_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveFileExPrivate_Private_Static_Boolean_String_String_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveFile_Internal_Static_Boolean_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDirectoryPrivate_Private_Static_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDirectory_Internal_Static_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetThreadErrorMode_Internal_Static_Boolean_UInt32_byref_UInt32_0;

		static Kernel32()
		{
			Il2CppClassPointerStore<Kernel32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "Kernel32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Kernel32>.NativeClassPtr);
			NativeMethodInfoPtr_DeleteVolumeMountPointPrivate_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663298);
			NativeMethodInfoPtr_DeleteVolumeMountPoint_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663299);
			NativeMethodInfoPtr_FreeLibrary_Internal_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663300);
			NativeMethodInfoPtr_LoadLibraryEx_Internal_Static_SafeLibraryHandle_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663301);
			NativeMethodInfoPtr_GetFileMUIPath_Internal_Static_Boolean_UInt32_String_StringBuilder_byref_Int32_StringBuilder_byref_Int32_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663302);
			NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_TIME_DYNAMIC_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663303);
			NativeMethodInfoPtr_GetTimeZoneInformation_Internal_Static_UInt32_byref_TIME_ZONE_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663304);
			NativeMethodInfoPtr_CloseHandle_Internal_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663305);
			NativeMethodInfoPtr_CreateDirectoryPrivate_Private_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663306);
			NativeMethodInfoPtr_CreateDirectory_Internal_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663307);
			NativeMethodInfoPtr_CreateFilePrivate_Private_Static_IntPtr_String_Int32_FileShare_ptr_SECURITY_ATTRIBUTES_FileMode_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663308);
			NativeMethodInfoPtr_CreateFile_IntPtr_Internal_Static_IntPtr_String_Int32_FileShare_FileMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663309);
			NativeMethodInfoPtr_DeleteFilePrivate_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663310);
			NativeMethodInfoPtr_DeleteFile_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663311);
			NativeMethodInfoPtr_FindFirstFileExPrivate_Private_Static_SafeFindHandle_String_FINDEX_INFO_LEVELS_byref_WIN32_FIND_DATA_FINDEX_SEARCH_OPS_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663312);
			NativeMethodInfoPtr_FindFirstFile_Internal_Static_SafeFindHandle_String_byref_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663313);
			NativeMethodInfoPtr_FindNextFile_Internal_Static_Boolean_SafeFindHandle_byref_WIN32_FIND_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663314);
			NativeMethodInfoPtr_FormatMessage_Private_Static_Int32_Int32_IntPtr_UInt32_Int32_ptr_Char_Int32_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663315);
			NativeMethodInfoPtr_GetMessage_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663316);
			NativeMethodInfoPtr_GetMessage_Internal_Static_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663317);
			NativeMethodInfoPtr_TryGetErrorMessage_Private_Static_Boolean_IntPtr_Int32_Span_1_Char_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663318);
			NativeMethodInfoPtr_GetFileAttributesExPrivate_Private_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663319);
			NativeMethodInfoPtr_GetFileAttributesEx_Internal_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663320);
			NativeMethodInfoPtr_GetFileInformationByHandleEx_Public_Static_Boolean_IntPtr_FILE_INFO_BY_HANDLE_CLASS_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663321);
			NativeMethodInfoPtr_MoveFileExPrivate_Private_Static_Boolean_String_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663322);
			NativeMethodInfoPtr_MoveFile_Internal_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663323);
			NativeMethodInfoPtr_RemoveDirectoryPrivate_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663324);
			NativeMethodInfoPtr_RemoveDirectory_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663325);
			NativeMethodInfoPtr_SetThreadErrorMode_Internal_Static_Boolean_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Kernel32>.NativeClassPtr, 100663326);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695963, XrefRangeEnd = 695966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteVolumeMountPointPrivate(string mountPoint)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mountPoint);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteVolumeMountPointPrivate_Internal_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 695973, RefRangeEnd = 695974, XrefRangeStart = 695966, XrefRangeEnd = 695973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteVolumeMountPoint(string mountPoint)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mountPoint);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteVolumeMountPoint_Internal_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 695977, RefRangeEnd = 695978, XrefRangeStart = 695974, XrefRangeEnd = 695977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FreeLibrary(System.IntPtr hModule)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&hModule);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeLibrary_Internal_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 695985, RefRangeEnd = 695986, XrefRangeStart = 695978, XrefRangeEnd = 695985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeLibraryHandle LoadLibraryEx(string libFilename, System.IntPtr reserved, int flags)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(libFilename);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &reserved;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadLibraryEx_Internal_Static_SafeLibraryHandle_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SafeLibraryHandle>(intPtr2) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 695995, RefRangeEnd = 695996, XrefRangeStart = 695986, XrefRangeEnd = 695995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileMUIPath(uint flags, string filePath, [Out] StringBuilder language, ref int languageLength, [Out] StringBuilder fileMuiPath, ref int fileMuiPathLength, ref long enumerator)
		{
			//IL_0097: Expected native int or pointer, but got O
			//IL_00a9: Expected native int or pointer, but got O
			System.IntPtr* ptr = stackalloc System.IntPtr[7];
			*ptr = (nint)(&flags);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
			byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref languageLength);
			byte* num3 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num4 = 0;
			*(nint**)num3 = &num4;
			*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref fileMuiPathLength);
			*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref enumerator);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileMUIPath_Internal_Static_Boolean_UInt32_String_StringBuilder_byref_Int32_StringBuilder_byref_Int32_byref_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num5 = num2;
			Unsafe.Write((void*)(nint)language, (num5 == 0) ? null : new StringBuilder(num5));
			nint num6 = num4;
			Unsafe.Write((void*)(nint)fileMuiPath, (num6 == 0) ? null : new StringBuilder(num6));
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 695999, RefRangeEnd = 696000, XrefRangeStart = 695996, XrefRangeEnd = 695999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetDynamicTimeZoneInformation(out TIME_DYNAMIC_ZONE_INFORMATION pTimeZoneInformation)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref pTimeZoneInformation);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDynamicTimeZoneInformation_Internal_Static_UInt32_byref_TIME_DYNAMIC_ZONE_INFORMATION_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 696003, RefRangeEnd = 696006, XrefRangeStart = 696000, XrefRangeEnd = 696003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetTimeZoneInformation(out TIME_ZONE_INFORMATION lpTimeZoneInformation)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref lpTimeZoneInformation);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeZoneInformation_Internal_Static_UInt32_byref_TIME_ZONE_INFORMATION_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 696009, RefRangeEnd = 696013, XrefRangeStart = 696006, XrefRangeEnd = 696009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseHandle(System.IntPtr handle)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&handle);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseHandle_Internal_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696013, XrefRangeEnd = 696016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateDirectoryPrivate(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpSecurityAttributes);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDirectoryPrivate_Private_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 696023, RefRangeEnd = 696025, XrefRangeStart = 696016, XrefRangeEnd = 696023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateDirectory(string path, ref SECURITY_ATTRIBUTES lpSecurityAttributes)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpSecurityAttributes);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDirectory_Internal_Static_Boolean_String_byref_SECURITY_ATTRIBUTES_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696025, XrefRangeEnd = 696028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr CreateFilePrivate(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, SECURITY_ATTRIBUTES* securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, System.IntPtr hTemplateFile)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[7];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(lpFileName);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwDesiredAccess;
			*(FileShare**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwShareMode;
			*(SECURITY_ATTRIBUTES**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = securityAttrs;
			*(FileMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwCreationDisposition;
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwFlagsAndAttributes;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &hTemplateFile;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFilePrivate_Private_Static_IntPtr_String_Int32_FileShare_ptr_SECURITY_ATTRIBUTES_FileMode_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696035, RefRangeEnd = 696036, XrefRangeStart = 696028, XrefRangeEnd = 696035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static System.IntPtr CreateFile_IntPtr(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, FileMode dwCreationDisposition, int dwFlagsAndAttributes)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(lpFileName);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwDesiredAccess;
			*(FileShare**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwShareMode;
			*(FileMode**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwCreationDisposition;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwFlagsAndAttributes;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFile_IntPtr_Internal_Static_IntPtr_String_Int32_FileShare_FileMode_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696036, XrefRangeEnd = 696039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteFilePrivate(string path)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteFilePrivate_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696046, RefRangeEnd = 696047, XrefRangeStart = 696039, XrefRangeEnd = 696046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteFile(string path)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteFile_Internal_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696047, XrefRangeEnd = 696054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeFindHandle FindFirstFileExPrivate(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, ref WIN32_FIND_DATA lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, System.IntPtr lpSearchFilter, int dwAdditionalFlags)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(lpFileName);
			*(FINDEX_INFO_LEVELS**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fInfoLevelId;
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpFindFileData);
			*(FINDEX_SEARCH_OPS**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fSearchOp;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &lpSearchFilter;
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwAdditionalFlags;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstFileExPrivate_Private_Static_SafeFindHandle_String_FINDEX_INFO_LEVELS_byref_WIN32_FIND_DATA_FINDEX_SEARCH_OPS_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SafeFindHandle>(intPtr2) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696065, RefRangeEnd = 696066, XrefRangeStart = 696054, XrefRangeEnd = 696065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SafeFindHandle FindFirstFile(string fileName, ref WIN32_FIND_DATA data)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref data);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFirstFile_Internal_Static_SafeFindHandle_String_byref_WIN32_FIND_DATA_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SafeFindHandle>(intPtr2) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696071, RefRangeEnd = 696072, XrefRangeStart = 696066, XrefRangeEnd = 696071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FindNextFile(SafeFindHandle hndFindFile, ref WIN32_FIND_DATA lpFindFileData)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hndFindFile);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpFindFileData);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindNextFile_Internal_Static_Boolean_SafeFindHandle_byref_WIN32_FIND_DATA_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696072, XrefRangeEnd = 696075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FormatMessage(int dwFlags, System.IntPtr lpSource, uint dwMessageId, int dwLanguageId, char* lpBuffer, int nSize, Il2CppStructArray<System.IntPtr> arguments)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[7];
			*ptr = (nint)(&dwFlags);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lpSource;
			*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwMessageId;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwLanguageId;
			*(char**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = lpBuffer;
			*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &nSize;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arguments);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatMessage_Private_Static_Int32_Int32_IntPtr_UInt32_Int32_ptr_Char_Int32_Il2CppStructArray_1_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 696076, RefRangeEnd = 696078, XrefRangeStart = 696075, XrefRangeEnd = 696076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(int errorCode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&errorCode);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMessage_Internal_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696093, RefRangeEnd = 696094, XrefRangeStart = 696078, XrefRangeEnd = 696093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(System.IntPtr moduleHandle, int errorCode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&moduleHandle);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &errorCode;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMessage_Internal_Static_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696124, RefRangeEnd = 696125, XrefRangeStart = 696094, XrefRangeEnd = 696124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetErrorMessage(System.IntPtr moduleHandle, int errorCode, Il2CppSystem.Span<char> buffer, out string errorMsg)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&moduleHandle);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &errorCode;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetErrorMessage_Private_Static_Boolean_IntPtr_Int32_Span_1_Char_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			errorMsg = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696125, XrefRangeEnd = 696128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileAttributesExPrivate(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			*(GET_FILEEX_INFO_LEVELS**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileInfoLevel;
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpFileInformation);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileAttributesExPrivate_Private_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 696135, RefRangeEnd = 696137, XrefRangeStart = 696128, XrefRangeEnd = 696135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileAttributesEx(string name, GET_FILEEX_INFO_LEVELS fileInfoLevel, ref WIN32_FILE_ATTRIBUTE_DATA lpFileInformation)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			*(GET_FILEEX_INFO_LEVELS**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileInfoLevel;
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpFileInformation);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileAttributesEx_Internal_Static_Boolean_String_GET_FILEEX_INFO_LEVELS_byref_WIN32_FILE_ATTRIBUTE_DATA_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696140, RefRangeEnd = 696141, XrefRangeStart = 696137, XrefRangeEnd = 696140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileInformationByHandleEx(System.IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, System.IntPtr lpFileInformation, uint dwBufferSize)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&hFile);
			*(FILE_INFO_BY_HANDLE_CLASS**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileInformationClass;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lpFileInformation;
			*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwBufferSize;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileInformationByHandleEx_Public_Static_Boolean_IntPtr_FILE_INFO_BY_HANDLE_CLASS_IntPtr_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696141, XrefRangeEnd = 696144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MoveFileExPrivate(string src, string dst, uint flags)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(dst);
			*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveFileExPrivate_Private_Static_Boolean_String_String_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696152, RefRangeEnd = 696153, XrefRangeStart = 696144, XrefRangeEnd = 696152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MoveFile(string src, string dst)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(dst);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveFile_Internal_Static_Boolean_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696153, XrefRangeEnd = 696156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveDirectoryPrivate(string path)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDirectoryPrivate_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696163, RefRangeEnd = 696164, XrefRangeStart = 696156, XrefRangeEnd = 696163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveDirectory(string path)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDirectory_Internal_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 696167, RefRangeEnd = 696173, XrefRangeStart = 696164, XrefRangeEnd = 696167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetThreadErrorMode(uint dwNewMode, out uint lpOldMode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&dwNewMode);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpOldMode);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetThreadErrorMode_Internal_Static_Boolean_UInt32_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public Kernel32(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class BCrypt : Il2CppSystem.Object
	{
		[OriginalName("mscorlib.dll", "", "NTSTATUS")]
		public enum NTSTATUS : uint
		{
			STATUS_SUCCESS = 0u,
			STATUS_NOT_FOUND = 3221226021u,
			STATUS_INVALID_PARAMETER = 3221225485u,
			STATUS_NO_MEMORY = 3221225495u
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_BCryptGenRandom_Internal_Static_NTSTATUS_IntPtr_ptr_Byte_Int32_Int32_0;

		static BCrypt()
		{
			Il2CppClassPointerStore<BCrypt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "BCrypt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BCrypt>.NativeClassPtr);
			NativeMethodInfoPtr_BCryptGenRandom_Internal_Static_NTSTATUS_IntPtr_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BCrypt>.NativeClassPtr, 100663336);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696173, XrefRangeEnd = 696175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NTSTATUS BCryptGenRandom(System.IntPtr hAlgorithm, byte* pbBuffer, int cbBuffer, int dwFlags)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&hAlgorithm);
			*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = pbBuffer;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cbBuffer;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwFlags;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BCryptGenRandom_Internal_Static_NTSTATUS_IntPtr_ptr_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(NTSTATUS*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BCrypt(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class User32 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadString_Internal_Static_Int32_SafeLibraryHandle_Int32_StringBuilder_Int32_0;

		static User32()
		{
			Il2CppClassPointerStore<User32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "User32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<User32>.NativeClassPtr);
			NativeMethodInfoPtr_LoadString_Internal_Static_Int32_SafeLibraryHandle_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<User32>.NativeClassPtr, 100663337);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696183, RefRangeEnd = 696184, XrefRangeStart = 696175, XrefRangeEnd = 696183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LoadString(SafeLibraryHandle handle, int id, [Out] StringBuilder buffer, int bufferLength)
		{
			//IL_0067: Expected native int or pointer, but got O
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
			byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLength;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadString_Internal_Static_Int32_SafeLibraryHandle_Int32_StringBuilder_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num3 = num2;
			Unsafe.Write((void*)(nint)buffer, (num3 == 0) ? null : new StringBuilder(num3));
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public User32(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("mscorlib.dll", "", "BOOL")]
	public enum BOOL
	{
		FALSE,
		TRUE
	}

	[OriginalName("mscorlib.dll", "", "BOOLEAN")]
	public enum BOOLEAN : byte
	{
		FALSE,
		TRUE
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct LongFileTime
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_TicksSince1601;

		[FieldOffset(0)]
		public long TicksSince1601;

		static LongFileTime()
		{
			Il2CppClassPointerStore<LongFileTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "LongFileTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongFileTime>.NativeClassPtr);
			NativeFieldInfoPtr_TicksSince1601 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongFileTime>.NativeClassPtr, "TicksSince1601");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LongFileTime>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UNICODE_STRING
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Length;

		private static readonly System.IntPtr NativeFieldInfoPtr_MaximumLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_Buffer;

		[FieldOffset(0)]
		public ushort Length;

		[FieldOffset(2)]
		public ushort MaximumLength;

		[FieldOffset(8)]
		public System.IntPtr Buffer;

		static UNICODE_STRING()
		{
			Il2CppClassPointerStore<UNICODE_STRING>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "UNICODE_STRING");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UNICODE_STRING>.NativeClassPtr);
			NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UNICODE_STRING>.NativeClassPtr, "Length");
			NativeFieldInfoPtr_MaximumLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UNICODE_STRING>.NativeClassPtr, "MaximumLength");
			NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UNICODE_STRING>.NativeClassPtr, "Buffer");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UNICODE_STRING>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class NtDll : Il2CppSystem.Object
	{
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct FILE_FULL_DIR_INFORMATION
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_NextEntryOffset;

			private static readonly System.IntPtr NativeFieldInfoPtr_FileIndex;

			private static readonly System.IntPtr NativeFieldInfoPtr_CreationTime;

			private static readonly System.IntPtr NativeFieldInfoPtr_LastAccessTime;

			private static readonly System.IntPtr NativeFieldInfoPtr_LastWriteTime;

			private static readonly System.IntPtr NativeFieldInfoPtr_ChangeTime;

			private static readonly System.IntPtr NativeFieldInfoPtr_EndOfFile;

			private static readonly System.IntPtr NativeFieldInfoPtr_AllocationSize;

			private static readonly System.IntPtr NativeFieldInfoPtr_FileAttributes;

			private static readonly System.IntPtr NativeFieldInfoPtr_FileNameLength;

			private static readonly System.IntPtr NativeFieldInfoPtr_EaSize;

			private static readonly System.IntPtr NativeFieldInfoPtr__fileName;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetNextInfo_Public_Static_ptr_FILE_FULL_DIR_INFORMATION_ptr_FILE_FULL_DIR_INFORMATION_0;

			[FieldOffset(0)]
			public uint NextEntryOffset;

			[FieldOffset(4)]
			public uint FileIndex;

			[FieldOffset(8)]
			public LongFileTime CreationTime;

			[FieldOffset(16)]
			public LongFileTime LastAccessTime;

			[FieldOffset(24)]
			public LongFileTime LastWriteTime;

			[FieldOffset(32)]
			public LongFileTime ChangeTime;

			[FieldOffset(40)]
			public long EndOfFile;

			[FieldOffset(48)]
			public long AllocationSize;

			[FieldOffset(56)]
			public FileAttributes FileAttributes;

			[FieldOffset(60)]
			public uint FileNameLength;

			[FieldOffset(64)]
			public uint EaSize;

			[FieldOffset(68)]
			public char _fileName;

			public unsafe Il2CppSystem.ReadOnlySpan<char> FileName
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 696186, RefRangeEnd = 696197, XrefRangeStart = 696184, XrefRangeEnd = 696186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new Il2CppSystem.ReadOnlySpan<char>(pointer);
				}
			}

			static FILE_FULL_DIR_INFORMATION()
			{
				Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NtDll>.NativeClassPtr, "FILE_FULL_DIR_INFORMATION");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr);
				NativeFieldInfoPtr_NextEntryOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "NextEntryOffset");
				NativeFieldInfoPtr_FileIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "FileIndex");
				NativeFieldInfoPtr_CreationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "CreationTime");
				NativeFieldInfoPtr_LastAccessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "LastAccessTime");
				NativeFieldInfoPtr_LastWriteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "LastWriteTime");
				NativeFieldInfoPtr_ChangeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "ChangeTime");
				NativeFieldInfoPtr_EndOfFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "EndOfFile");
				NativeFieldInfoPtr_AllocationSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "AllocationSize");
				NativeFieldInfoPtr_FileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "FileAttributes");
				NativeFieldInfoPtr_FileNameLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "FileNameLength");
				NativeFieldInfoPtr_EaSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "EaSize");
				NativeFieldInfoPtr__fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, "_fileName");
				NativeMethodInfoPtr_get_FileName_Public_get_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, 100663342);
				NativeMethodInfoPtr_GetNextInfo_Public_Static_ptr_FILE_FULL_DIR_INFORMATION_ptr_FILE_FULL_DIR_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, 100663343);
			}

			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 696197, RefRangeEnd = 696199, XrefRangeStart = 696197, XrefRangeEnd = 696197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static FILE_FULL_DIR_INFORMATION* GetNextInfo(FILE_FULL_DIR_INFORMATION* info)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)info;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextInfo_Public_Static_ptr_FILE_FULL_DIR_INFORMATION_ptr_FILE_FULL_DIR_INFORMATION_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (FILE_FULL_DIR_INFORMATION*)result;
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FILE_FULL_DIR_INFORMATION>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[OriginalName("mscorlib.dll", "", "FILE_INFORMATION_CLASS")]
		public enum FILE_INFORMATION_CLASS : uint
		{
			FileDirectoryInformation = 1u,
			FileFullDirectoryInformation,
			FileBothDirectoryInformation,
			FileBasicInformation,
			FileStandardInformation,
			FileInternalInformation,
			FileEaInformation,
			FileAccessInformation,
			FileNameInformation,
			FileRenameInformation,
			FileLinkInformation,
			FileNamesInformation,
			FileDispositionInformation,
			FilePositionInformation,
			FileFullEaInformation,
			FileModeInformation,
			FileAlignmentInformation,
			FileAllInformation,
			FileAllocationInformation,
			FileEndOfFileInformation,
			FileAlternateNameInformation,
			FileStreamInformation,
			FilePipeInformation,
			FilePipeLocalInformation,
			FilePipeRemoteInformation,
			FileMailslotQueryInformation,
			FileMailslotSetInformation,
			FileCompressionInformation,
			FileObjectIdInformation,
			FileCompletionInformation,
			FileMoveClusterInformation,
			FileQuotaInformation,
			FileReparsePointInformation,
			FileNetworkOpenInformation,
			FileAttributeTagInformation,
			FileTrackingInformation,
			FileIdBothDirectoryInformation,
			FileIdFullDirectoryInformation,
			FileValidDataLengthInformation,
			FileShortNameInformation,
			FileIoCompletionNotificationInformation,
			FileIoStatusBlockRangeInformation,
			FileIoPriorityHintInformation,
			FileSfioReserveInformation,
			FileSfioVolumeInformation,
			FileHardLinkInformation,
			FileProcessIdsUsingFileInformation,
			FileNormalizedNameInformation,
			FileNetworkPhysicalNameInformation,
			FileIdGlobalTxDirectoryInformation,
			FileIsRemoteDeviceInformation,
			FileUnusedInformation,
			FileNumaNodeInformation,
			FileStandardLinkInformation,
			FileRemoteProtocolInformation,
			FileRenameInformationBypassAccessCheck,
			FileLinkInformationBypassAccessCheck,
			FileVolumeNameInformation,
			FileIdInformation,
			FileIdExtdDirectoryInformation,
			FileReplaceCompletionInformation,
			FileHardLinkFullIdInformation,
			FileIdExtdBothDirectoryInformation,
			FileDispositionInformationEx,
			FileRenameInformationEx,
			FileRenameInformationExBypassAccessCheck,
			FileDesiredStorageClassInformation,
			FileStatInformation
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct IO_STATUS_BLOCK
		{
			[StructLayout(LayoutKind.Explicit)]
			public struct IO_STATUS
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_Status;

				private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;

				[FieldOffset(0)]
				public uint Status;

				[FieldOffset(0)]
				public System.IntPtr Pointer;

				static IO_STATUS()
				{
					Il2CppClassPointerStore<IO_STATUS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IO_STATUS_BLOCK>.NativeClassPtr, "IO_STATUS");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IO_STATUS>.NativeClassPtr);
					NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IO_STATUS>.NativeClassPtr, "Status");
					NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IO_STATUS>.NativeClassPtr, "Pointer");
				}

				public unsafe Il2CppSystem.Object BoxIl2CppObject()
				{
					return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IO_STATUS>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
				}
			}

			private static readonly System.IntPtr NativeFieldInfoPtr_Status;

			private static readonly System.IntPtr NativeFieldInfoPtr_Information;

			[FieldOffset(0)]
			public IO_STATUS Status;

			[FieldOffset(8)]
			public System.IntPtr Information;

			static IO_STATUS_BLOCK()
			{
				Il2CppClassPointerStore<IO_STATUS_BLOCK>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NtDll>.NativeClassPtr, "IO_STATUS_BLOCK");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IO_STATUS_BLOCK>.NativeClassPtr);
				NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IO_STATUS_BLOCK>.NativeClassPtr, "Status");
				NativeFieldInfoPtr_Information = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IO_STATUS_BLOCK>.NativeClassPtr, "Information");
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IO_STATUS_BLOCK>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct OBJECT_ATTRIBUTES
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_Length;

			private static readonly System.IntPtr NativeFieldInfoPtr_RootDirectory;

			private static readonly System.IntPtr NativeFieldInfoPtr_ObjectName;

			private static readonly System.IntPtr NativeFieldInfoPtr_Attributes;

			private static readonly System.IntPtr NativeFieldInfoPtr_SecurityDescriptor;

			private static readonly System.IntPtr NativeFieldInfoPtr_SecurityQualityOfService;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_UNICODE_STRING_ObjectAttributes_IntPtr_0;

			[FieldOffset(0)]
			public uint Length;

			[FieldOffset(8)]
			public System.IntPtr RootDirectory;

			[FieldOffset(16)]
			public System.IntPtr ObjectName;

			[FieldOffset(24)]
			public ObjectAttributes Attributes;

			[FieldOffset(32)]
			public System.IntPtr SecurityDescriptor;

			[FieldOffset(40)]
			public System.IntPtr SecurityQualityOfService;

			static OBJECT_ATTRIBUTES()
			{
				Il2CppClassPointerStore<OBJECT_ATTRIBUTES>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NtDll>.NativeClassPtr, "OBJECT_ATTRIBUTES");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OBJECT_ATTRIBUTES>.NativeClassPtr);
				NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJECT_ATTRIBUTES>.NativeClassPtr, "Length");
				NativeFieldInfoPtr_RootDirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJECT_ATTRIBUTES>.NativeClassPtr, "RootDirectory");
				NativeFieldInfoPtr_ObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJECT_ATTRIBUTES>.NativeClassPtr, "ObjectName");
				NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJECT_ATTRIBUTES>.NativeClassPtr, "Attributes");
				NativeFieldInfoPtr_SecurityDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJECT_ATTRIBUTES>.NativeClassPtr, "SecurityDescriptor");
				NativeFieldInfoPtr_SecurityQualityOfService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OBJECT_ATTRIBUTES>.NativeClassPtr, "SecurityQualityOfService");
				NativeMethodInfoPtr__ctor_Public_Void_ptr_UNICODE_STRING_ObjectAttributes_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OBJECT_ATTRIBUTES>.NativeClassPtr, 100663344);
			}

			[CallerCount(0)]
			public unsafe OBJECT_ATTRIBUTES(UNICODE_STRING* objectName, ObjectAttributes attributes, System.IntPtr rootDirectory)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[3];
				*ptr = (nint)objectName;
				*(ObjectAttributes**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &attributes;
				*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rootDirectory;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ptr_UNICODE_STRING_ObjectAttributes_IntPtr_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OBJECT_ATTRIBUTES>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		[OriginalName("mscorlib.dll", "", "ObjectAttributes")]
		[System.Flags]
		public enum ObjectAttributes : uint
		{
			OBJ_INHERIT = 2u,
			OBJ_PERMANENT = 0x10u,
			OBJ_EXCLUSIVE = 0x20u,
			OBJ_CASE_INSENSITIVE = 0x40u,
			OBJ_OPENIF = 0x80u,
			OBJ_OPENLINK = 0x100u
		}

		[OriginalName("mscorlib.dll", "", "CreateDisposition")]
		public enum CreateDisposition : uint
		{
			FILE_SUPERSEDE,
			FILE_OPEN,
			FILE_CREATE,
			FILE_OPEN_IF,
			FILE_OVERWRITE,
			FILE_OVERWRITE_IF
		}

		[OriginalName("mscorlib.dll", "", "CreateOptions")]
		public enum CreateOptions : uint
		{
			FILE_DIRECTORY_FILE = 1u,
			FILE_WRITE_THROUGH = 2u,
			FILE_SEQUENTIAL_ONLY = 4u,
			FILE_NO_INTERMEDIATE_BUFFERING = 8u,
			FILE_SYNCHRONOUS_IO_ALERT = 0x10u,
			FILE_SYNCHRONOUS_IO_NONALERT = 0x20u,
			FILE_NON_DIRECTORY_FILE = 0x40u,
			FILE_CREATE_TREE_CONNECTION = 0x80u,
			FILE_COMPLETE_IF_OPLOCKED = 0x100u,
			FILE_NO_EA_KNOWLEDGE = 0x200u,
			FILE_RANDOM_ACCESS = 0x800u,
			FILE_DELETE_ON_CLOSE = 0x1000u,
			FILE_OPEN_BY_FILE_ID = 0x2000u,
			FILE_OPEN_FOR_BACKUP_INTENT = 0x4000u,
			FILE_NO_COMPRESSION = 0x8000u,
			FILE_OPEN_REQUIRING_OPLOCK = 0x10000u,
			FILE_DISALLOW_EXCLUSIVE = 0x20000u,
			FILE_SESSION_AWARE = 0x40000u,
			FILE_RESERVE_OPFILTER = 0x100000u,
			FILE_OPEN_REPARSE_POINT = 0x200000u,
			FILE_OPEN_NO_RECALL = 0x400000u
		}

		[OriginalName("mscorlib.dll", "", "DesiredAccess")]
		[System.Flags]
		public enum DesiredAccess : uint
		{
			FILE_READ_DATA = 1u,
			FILE_LIST_DIRECTORY = 1u,
			FILE_WRITE_DATA = 2u,
			FILE_ADD_FILE = 2u,
			FILE_APPEND_DATA = 4u,
			FILE_ADD_SUBDIRECTORY = 4u,
			FILE_CREATE_PIPE_INSTANCE = 4u,
			FILE_READ_EA = 8u,
			FILE_WRITE_EA = 0x10u,
			FILE_EXECUTE = 0x20u,
			FILE_TRAVERSE = 0x20u,
			FILE_DELETE_CHILD = 0x40u,
			FILE_READ_ATTRIBUTES = 0x80u,
			FILE_WRITE_ATTRIBUTES = 0x100u,
			FILE_ALL_ACCESS = 0xF01FFu,
			DELETE = 0x10000u,
			READ_CONTROL = 0x20000u,
			WRITE_DAC = 0x40000u,
			WRITE_OWNER = 0x80000u,
			SYNCHRONIZE = 0x100000u,
			STANDARD_RIGHTS_READ = 0x20000u,
			STANDARD_RIGHTS_WRITE = 0x20000u,
			STANDARD_RIGHTS_EXECUTE = 0x20000u,
			FILE_GENERIC_READ = 0x80000000u,
			FILE_GENERIC_WRITE = 0x40000000u,
			FILE_GENERIC_EXECUTE = 0x20000000u
		}

		private static readonly System.IntPtr NativeMethodInfoPtr_NtCreateFile_Private_Static_Int32_byref_IntPtr_DesiredAccess_byref_OBJECT_ATTRIBUTES_byref_IO_STATUS_BLOCK_ptr_Int64_FileAttributes_FileShare_CreateDisposition_CreateOptions_ptr_Void_UInt32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateFile_Internal_Static_ValueTuple_2_Int32_IntPtr_ReadOnlySpan_1_Char_IntPtr_CreateDisposition_DesiredAccess_FileShare_FileAttributes_CreateOptions_ObjectAttributes_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NtQueryDirectoryFile_Public_Static_Int32_IntPtr_IntPtr_IntPtr_IntPtr_byref_IO_STATUS_BLOCK_IntPtr_UInt32_FILE_INFORMATION_CLASS_BOOLEAN_ptr_UNICODE_STRING_BOOLEAN_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RtlNtStatusToDosError_Public_Static_UInt32_Int32_0;

		static NtDll()
		{
			Il2CppClassPointerStore<NtDll>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "NtDll");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NtDll>.NativeClassPtr);
			NativeMethodInfoPtr_NtCreateFile_Private_Static_Int32_byref_IntPtr_DesiredAccess_byref_OBJECT_ATTRIBUTES_byref_IO_STATUS_BLOCK_ptr_Int64_FileAttributes_FileShare_CreateDisposition_CreateOptions_ptr_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtDll>.NativeClassPtr, 100663338);
			NativeMethodInfoPtr_CreateFile_Internal_Static_ValueTuple_2_Int32_IntPtr_ReadOnlySpan_1_Char_IntPtr_CreateDisposition_DesiredAccess_FileShare_FileAttributes_CreateOptions_ObjectAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtDll>.NativeClassPtr, 100663339);
			NativeMethodInfoPtr_NtQueryDirectoryFile_Public_Static_Int32_IntPtr_IntPtr_IntPtr_IntPtr_byref_IO_STATUS_BLOCK_IntPtr_UInt32_FILE_INFORMATION_CLASS_BOOLEAN_ptr_UNICODE_STRING_BOOLEAN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtDll>.NativeClassPtr, 100663340);
			NativeMethodInfoPtr_RtlNtStatusToDosError_Public_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtDll>.NativeClassPtr, 100663341);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696199, XrefRangeEnd = 696201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NtCreateFile(out System.IntPtr FileHandle, DesiredAccess DesiredAccess, ref OBJECT_ATTRIBUTES ObjectAttributes, out IO_STATUS_BLOCK IoStatusBlock, long* AllocationSize, FileAttributes FileAttributes, FileShare ShareAccess, CreateDisposition CreateDisposition, CreateOptions CreateOptions, void* EaBuffer, uint EaLength)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[11];
			*ptr = (nint)Unsafe.AsPointer(ref FileHandle);
			*(DesiredAccess**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &DesiredAccess;
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ObjectAttributes);
			*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref IoStatusBlock);
			*(long**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = AllocationSize;
			*(FileAttributes**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileAttributes;
			*(FileShare**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &ShareAccess;
			*(CreateDisposition**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &CreateDisposition;
			*(CreateOptions**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &CreateOptions;
			*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = EaBuffer;
			*(uint**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &EaLength;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NtCreateFile_Private_Static_Int32_byref_IntPtr_DesiredAccess_byref_OBJECT_ATTRIBUTES_byref_IO_STATUS_BLOCK_ptr_Int64_FileAttributes_FileShare_CreateDisposition_CreateOptions_ptr_Void_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 696212, RefRangeEnd = 696215, XrefRangeStart = 696201, XrefRangeEnd = 696212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppSystem.ValueTuple<int, System.IntPtr> CreateFile(Il2CppSystem.ReadOnlySpan<char> path, System.IntPtr rootDirectory, CreateDisposition createDisposition, DesiredAccess desiredAccess = DesiredAccess.SYNCHRONIZE | DesiredAccess.FILE_GENERIC_READ, FileShare shareAccess = FileShare.ReadWrite | FileShare.Delete, FileAttributes fileAttributes = (FileAttributes)0, CreateOptions createOptions = CreateOptions.FILE_SYNCHRONOUS_IO_NONALERT, ObjectAttributes objectAttributes = ObjectAttributes.OBJ_CASE_INSENSITIVE)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[8];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)path));
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rootDirectory;
			*(CreateDisposition**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &createDisposition;
			*(DesiredAccess**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &desiredAccess;
			*(FileShare**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &shareAccess;
			*(FileAttributes**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileAttributes;
			*(CreateOptions**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &createOptions;
			*(ObjectAttributes**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &objectAttributes;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFile_Internal_Static_ValueTuple_2_Int32_IntPtr_ReadOnlySpan_1_Char_IntPtr_CreateDisposition_DesiredAccess_FileShare_FileAttributes_CreateOptions_ObjectAttributes_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.ValueTuple<int, System.IntPtr>(pointer);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 696217, RefRangeEnd = 696220, XrefRangeStart = 696215, XrefRangeEnd = 696217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NtQueryDirectoryFile(System.IntPtr FileHandle, System.IntPtr Event, System.IntPtr ApcRoutine, System.IntPtr ApcContext, out IO_STATUS_BLOCK IoStatusBlock, System.IntPtr FileInformation, uint Length, FILE_INFORMATION_CLASS FileInformationClass, BOOLEAN ReturnSingleEntry, UNICODE_STRING* FileName, BOOLEAN RestartScan)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[11];
			*ptr = (nint)(&FileHandle);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &Event;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ApcRoutine;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ApcContext;
			*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref IoStatusBlock);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileInformation;
			*(uint**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &Length;
			*(FILE_INFORMATION_CLASS**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileInformationClass;
			*(BOOLEAN**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &ReturnSingleEntry;
			*(UNICODE_STRING**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = FileName;
			*(BOOLEAN**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &RestartScan;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NtQueryDirectoryFile_Public_Static_Int32_IntPtr_IntPtr_IntPtr_IntPtr_byref_IO_STATUS_BLOCK_IntPtr_UInt32_FILE_INFORMATION_CLASS_BOOLEAN_ptr_UNICODE_STRING_BOOLEAN_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 696222, RefRangeEnd = 696227, XrefRangeStart = 696220, XrefRangeEnd = 696222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint RtlNtStatusToDosError(int Status)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&Status);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RtlNtStatusToDosError_Public_Static_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public NtDll(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class Advapi32 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_RegCloseKey_Internal_Static_Int32_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RegEnumKeyEx_Internal_Static_Int32_SafeRegistryHandle_Int32_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Int32_StringBuilder_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RegOpenKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_Int32_byref_SafeRegistryHandle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RegQueryInfoKey_Internal_Static_Int32_SafeRegistryHandle_StringBuilder_Il2CppStructArray_1_Int32_IntPtr_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Byte_byref_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int64_byref_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Char_byref_Int32_0;

		static Advapi32()
		{
			Il2CppClassPointerStore<Advapi32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interop>.NativeClassPtr, "Advapi32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Advapi32>.NativeClassPtr);
			NativeMethodInfoPtr_RegCloseKey_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Advapi32>.NativeClassPtr, 100663345);
			NativeMethodInfoPtr_RegEnumKeyEx_Internal_Static_Int32_SafeRegistryHandle_Int32_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Int32_StringBuilder_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Advapi32>.NativeClassPtr, 100663346);
			NativeMethodInfoPtr_RegOpenKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_Int32_byref_SafeRegistryHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Advapi32>.NativeClassPtr, 100663347);
			NativeMethodInfoPtr_RegQueryInfoKey_Internal_Static_Int32_SafeRegistryHandle_StringBuilder_Il2CppStructArray_1_Int32_IntPtr_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Advapi32>.NativeClassPtr, 100663348);
			NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Advapi32>.NativeClassPtr, 100663349);
			NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Advapi32>.NativeClassPtr, 100663350);
			NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int64_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Advapi32>.NativeClassPtr, 100663351);
			NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Advapi32>.NativeClassPtr, 100663352);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 696229, RefRangeEnd = 696232, XrefRangeStart = 696227, XrefRangeEnd = 696229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegCloseKey(System.IntPtr hKey)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&hKey);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegCloseKey_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696239, RefRangeEnd = 696240, XrefRangeStart = 696232, XrefRangeEnd = 696239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegEnumKeyEx(SafeRegistryHandle hKey, int dwIndex, Il2CppStructArray<char> lpName, ref int lpcbName, Il2CppStructArray<int> lpReserved, [Out] StringBuilder lpClass, Il2CppStructArray<int> lpcbClass, Il2CppStructArray<long> lpftLastWriteTime)
		{
			//IL_00b3: Expected native int or pointer, but got O
			System.IntPtr* ptr = stackalloc System.IntPtr[8];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hKey);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwIndex;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpName);
			*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpcbName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpReserved);
			byte* num = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpcbClass);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpftLastWriteTime);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegEnumKeyEx_Internal_Static_Int32_SafeRegistryHandle_Int32_Il2CppStructArray_1_Char_byref_Int32_Il2CppStructArray_1_Int32_StringBuilder_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num3 = num2;
			Unsafe.Write((void*)(nint)lpClass, (num3 == 0) ? null : new StringBuilder(num3));
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696249, RefRangeEnd = 696250, XrefRangeStart = 696240, XrefRangeEnd = 696249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegOpenKeyEx(SafeRegistryHandle hKey, string lpSubKey, int ulOptions, int samDesired, out SafeRegistryHandle hkResult)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hKey);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(lpSubKey);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ulOptions;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &samDesired;
			byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegOpenKeyEx_Internal_Static_Int32_SafeRegistryHandle_String_Int32_Int32_byref_SafeRegistryHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num3 = num2;
			hkResult = ((num3 == 0) ? null : new SafeRegistryHandle(num3));
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 696257, RefRangeEnd = 696261, XrefRangeStart = 696250, XrefRangeEnd = 696257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryInfoKey(SafeRegistryHandle hKey, [Out] StringBuilder lpClass, Il2CppStructArray<int> lpcbClass, System.IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, Il2CppStructArray<int> lpcbMaxSubKeyLen, Il2CppStructArray<int> lpcbMaxClassLen, ref int lpcValues, Il2CppStructArray<int> lpcbMaxValueNameLen, Il2CppStructArray<int> lpcbMaxValueLen, Il2CppStructArray<int> lpcbSecurityDescriptor, Il2CppStructArray<int> lpftLastWriteTime)
		{
			//IL_00ff: Expected native int or pointer, but got O
			System.IntPtr* ptr = stackalloc System.IntPtr[12];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hKey);
			byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpcbClass);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lpReserved_MustBeZero;
			*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpcSubKeys);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpcbMaxSubKeyLen);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpcbMaxClassLen);
			*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpcValues);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpcbMaxValueNameLen);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpcbMaxValueLen);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpcbSecurityDescriptor);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpftLastWriteTime);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegQueryInfoKey_Internal_Static_Int32_SafeRegistryHandle_StringBuilder_Il2CppStructArray_1_Int32_IntPtr_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num3 = num2;
			Unsafe.Write((void*)(nint)lpClass, (num3 == 0) ? null : new StringBuilder(num3));
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 696268, RefRangeEnd = 696272, XrefRangeStart = 696261, XrefRangeEnd = 696268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Il2CppStructArray<int> lpReserved, ref int lpType, [Out] Il2CppStructArray<byte> lpData, ref int lpcbData)
		{
			//IL_008d: Expected native int or pointer, but got O
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hKey);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpReserved);
			*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpType);
			byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpcbData);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Byte_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num3 = num2;
			Unsafe.Write((void*)(nint)lpData, (num3 == 0) ? null : new Il2CppStructArray<byte>((System.IntPtr)num3));
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696276, RefRangeEnd = 696277, XrefRangeStart = 696272, XrefRangeEnd = 696276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Il2CppStructArray<int> lpReserved, ref int lpType, ref int lpData, ref int lpcbData)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hKey);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpReserved);
			*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpType);
			*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpData);
			*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpcbData);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 696281, RefRangeEnd = 696282, XrefRangeStart = 696277, XrefRangeEnd = 696281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Il2CppStructArray<int> lpReserved, ref int lpType, ref long lpData, ref int lpcbData)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hKey);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpReserved);
			*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpType);
			*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpData);
			*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpcbData);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_byref_Int64_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 696289, RefRangeEnd = 696292, XrefRangeStart = 696282, XrefRangeEnd = 696289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RegQueryValueEx(SafeRegistryHandle hKey, string lpValueName, Il2CppStructArray<int> lpReserved, ref int lpType, [Out] Il2CppStructArray<char> lpData, ref int lpcbData)
		{
			//IL_008d: Expected native int or pointer, but got O
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hKey);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(lpValueName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpReserved);
			*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpType);
			byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lpcbData);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegQueryValueEx_Internal_Static_Int32_SafeRegistryHandle_String_Il2CppStructArray_1_Int32_byref_Int32_Il2CppStructArray_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num3 = num2;
			Unsafe.Write((void*)(nint)lpData, (num3 == 0) ? null : new Il2CppStructArray<char>((System.IntPtr)num3));
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public Advapi32(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomBytes_Internal_Static_Void_ptr_Byte_Int32_0;

	static Interop()
	{
		Il2CppClassPointerStore<Interop>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "", "Interop");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interop>.NativeClassPtr);
		NativeMethodInfoPtr_GetRandomBytes_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interop>.NativeClassPtr, 100663297);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 696295, RefRangeEnd = 696298, XrefRangeStart = 696292, XrefRangeEnd = 696295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRandomBytes(byte* buffer, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)buffer;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomBytes_Internal_Static_Void_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Interop(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
