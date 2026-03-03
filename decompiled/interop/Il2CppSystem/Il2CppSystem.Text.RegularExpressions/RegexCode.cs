using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions;

public sealed class RegexCode : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Onerep;

	private static readonly System.IntPtr NativeFieldInfoPtr_Notonerep;

	private static readonly System.IntPtr NativeFieldInfoPtr_Setrep;

	private static readonly System.IntPtr NativeFieldInfoPtr_Oneloop;

	private static readonly System.IntPtr NativeFieldInfoPtr_Notoneloop;

	private static readonly System.IntPtr NativeFieldInfoPtr_Setloop;

	private static readonly System.IntPtr NativeFieldInfoPtr_Onelazy;

	private static readonly System.IntPtr NativeFieldInfoPtr_Notonelazy;

	private static readonly System.IntPtr NativeFieldInfoPtr_Setlazy;

	private static readonly System.IntPtr NativeFieldInfoPtr_One;

	private static readonly System.IntPtr NativeFieldInfoPtr_Notone;

	private static readonly System.IntPtr NativeFieldInfoPtr_Set;

	private static readonly System.IntPtr NativeFieldInfoPtr_Multi;

	private static readonly System.IntPtr NativeFieldInfoPtr_Ref;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bol;

	private static readonly System.IntPtr NativeFieldInfoPtr_Eol;

	private static readonly System.IntPtr NativeFieldInfoPtr_Boundary;

	private static readonly System.IntPtr NativeFieldInfoPtr_Nonboundary;

	private static readonly System.IntPtr NativeFieldInfoPtr_Beginning;

	private static readonly System.IntPtr NativeFieldInfoPtr_Start;

	private static readonly System.IntPtr NativeFieldInfoPtr_EndZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_End;

	private static readonly System.IntPtr NativeFieldInfoPtr_Nothing;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lazybranch;

	private static readonly System.IntPtr NativeFieldInfoPtr_Branchmark;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lazybranchmark;

	private static readonly System.IntPtr NativeFieldInfoPtr_Nullcount;

	private static readonly System.IntPtr NativeFieldInfoPtr_Setcount;

	private static readonly System.IntPtr NativeFieldInfoPtr_Branchcount;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lazybranchcount;

	private static readonly System.IntPtr NativeFieldInfoPtr_Nullmark;

	private static readonly System.IntPtr NativeFieldInfoPtr_Setmark;

	private static readonly System.IntPtr NativeFieldInfoPtr_Capturemark;

	private static readonly System.IntPtr NativeFieldInfoPtr_Getmark;

	private static readonly System.IntPtr NativeFieldInfoPtr_Setjump;

	private static readonly System.IntPtr NativeFieldInfoPtr_Backjump;

	private static readonly System.IntPtr NativeFieldInfoPtr_Forejump;

	private static readonly System.IntPtr NativeFieldInfoPtr_Testref;

	private static readonly System.IntPtr NativeFieldInfoPtr_Goto;

	private static readonly System.IntPtr NativeFieldInfoPtr_Prune;

	private static readonly System.IntPtr NativeFieldInfoPtr_Stop;

	private static readonly System.IntPtr NativeFieldInfoPtr_ECMABoundary;

	private static readonly System.IntPtr NativeFieldInfoPtr_NonECMABoundary;

	private static readonly System.IntPtr NativeFieldInfoPtr_Mask;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rtl;

	private static readonly System.IntPtr NativeFieldInfoPtr_Back;

	private static readonly System.IntPtr NativeFieldInfoPtr_Back2;

	private static readonly System.IntPtr NativeFieldInfoPtr_Ci;

	private static readonly System.IntPtr NativeFieldInfoPtr_Codes;

	private static readonly System.IntPtr NativeFieldInfoPtr_Strings;

	private static readonly System.IntPtr NativeFieldInfoPtr_TrackCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_Caps;

	private static readonly System.IntPtr NativeFieldInfoPtr_CapSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_FCPrefix;

	private static readonly System.IntPtr NativeFieldInfoPtr_BMPrefix;

	private static readonly System.IntPtr NativeFieldInfoPtr_Anchors;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightToLeft;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_Nullable_1_RegexPrefix_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpcodeBacktracks_Public_Static_Boolean_Int32_0;

	public unsafe static int Onerep
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Onerep, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Onerep, (void*)(&value));
		}
	}

	public unsafe static int Notonerep
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Notonerep, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Notonerep, (void*)(&value));
		}
	}

	public unsafe static int Setrep
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Setrep, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Setrep, (void*)(&value));
		}
	}

	public unsafe static int Oneloop
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Oneloop, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Oneloop, (void*)(&value));
		}
	}

	public unsafe static int Notoneloop
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Notoneloop, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Notoneloop, (void*)(&value));
		}
	}

	public unsafe static int Setloop
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Setloop, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Setloop, (void*)(&value));
		}
	}

	public unsafe static int Onelazy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Onelazy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Onelazy, (void*)(&value));
		}
	}

	public unsafe static int Notonelazy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Notonelazy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Notonelazy, (void*)(&value));
		}
	}

	public unsafe static int Setlazy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Setlazy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Setlazy, (void*)(&value));
		}
	}

	public unsafe static int One
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_One, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_One, (void*)(&value));
		}
	}

	public unsafe static int Notone
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Notone, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Notone, (void*)(&value));
		}
	}

	public unsafe static int Set
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Set, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Set, (void*)(&value));
		}
	}

	public unsafe static int Multi
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Multi, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Multi, (void*)(&value));
		}
	}

	public unsafe static int Ref
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Ref, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Ref, (void*)(&value));
		}
	}

	public unsafe static int Bol
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Bol, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Bol, (void*)(&value));
		}
	}

	public unsafe static int Eol
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Eol, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Eol, (void*)(&value));
		}
	}

	public unsafe static int Boundary
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Boundary, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Boundary, (void*)(&value));
		}
	}

	public unsafe static int Nonboundary
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Nonboundary, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Nonboundary, (void*)(&value));
		}
	}

	public unsafe static int Beginning
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Beginning, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Beginning, (void*)(&value));
		}
	}

	public unsafe static int Start
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Start, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Start, (void*)(&value));
		}
	}

	public unsafe static int EndZ
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EndZ, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EndZ, (void*)(&value));
		}
	}

	public unsafe static int End
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End, (void*)(&value));
		}
	}

	public unsafe static int Nothing
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Nothing, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Nothing, (void*)(&value));
		}
	}

	public unsafe static int Lazybranch
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lazybranch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lazybranch, (void*)(&value));
		}
	}

	public unsafe static int Branchmark
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Branchmark, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Branchmark, (void*)(&value));
		}
	}

	public unsafe static int Lazybranchmark
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lazybranchmark, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lazybranchmark, (void*)(&value));
		}
	}

	public unsafe static int Nullcount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Nullcount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Nullcount, (void*)(&value));
		}
	}

	public unsafe static int Setcount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Setcount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Setcount, (void*)(&value));
		}
	}

	public unsafe static int Branchcount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Branchcount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Branchcount, (void*)(&value));
		}
	}

	public unsafe static int Lazybranchcount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lazybranchcount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lazybranchcount, (void*)(&value));
		}
	}

	public unsafe static int Nullmark
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Nullmark, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Nullmark, (void*)(&value));
		}
	}

	public unsafe static int Setmark
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Setmark, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Setmark, (void*)(&value));
		}
	}

	public unsafe static int Capturemark
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Capturemark, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Capturemark, (void*)(&value));
		}
	}

	public unsafe static int Getmark
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Getmark, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Getmark, (void*)(&value));
		}
	}

	public unsafe static int Setjump
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Setjump, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Setjump, (void*)(&value));
		}
	}

	public unsafe static int Backjump
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Backjump, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Backjump, (void*)(&value));
		}
	}

	public unsafe static int Forejump
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Forejump, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Forejump, (void*)(&value));
		}
	}

	public unsafe static int Testref
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Testref, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Testref, (void*)(&value));
		}
	}

	public unsafe static int Goto
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Goto, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Goto, (void*)(&value));
		}
	}

	public unsafe static int Prune
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Prune, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Prune, (void*)(&value));
		}
	}

	public unsafe static int Stop
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Stop, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Stop, (void*)(&value));
		}
	}

	public unsafe static int ECMABoundary
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ECMABoundary, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ECMABoundary, (void*)(&value));
		}
	}

	public unsafe static int NonECMABoundary
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NonECMABoundary, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NonECMABoundary, (void*)(&value));
		}
	}

	public unsafe static int Mask
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Mask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Mask, (void*)(&value));
		}
	}

	public unsafe static int Rtl
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Rtl, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Rtl, (void*)(&value));
		}
	}

	public unsafe static int Back
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Back, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Back, (void*)(&value));
		}
	}

	public unsafe static int Back2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Back2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Back2, (void*)(&value));
		}
	}

	public unsafe static int Ci
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Ci, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Ci, (void*)(&value));
		}
	}

	public unsafe Il2CppStructArray<int> Codes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Codes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Codes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray Strings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Strings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Strings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int TrackCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TrackCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TrackCount)) = value;
		}
	}

	public unsafe Hashtable Caps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Caps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Caps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int CapSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CapSize)) = value;
		}
	}

	public unsafe Nullable<RegexPrefix> FCPrefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FCPrefix);
			return new Nullable<RegexPrefix>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<RegexPrefix>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FCPrefix), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<RegexPrefix>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe RegexBoyerMoore BMPrefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BMPrefix);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegexBoyerMoore>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BMPrefix)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int Anchors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Anchors);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Anchors)) = value;
		}
	}

	public unsafe bool RightToLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightToLeft);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightToLeft)) = value;
		}
	}

	static RegexCode()
	{
		Il2CppClassPointerStore<RegexCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexCode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCode>.NativeClassPtr);
		NativeFieldInfoPtr_Onerep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Onerep");
		NativeFieldInfoPtr_Notonerep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notonerep");
		NativeFieldInfoPtr_Setrep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setrep");
		NativeFieldInfoPtr_Oneloop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Oneloop");
		NativeFieldInfoPtr_Notoneloop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notoneloop");
		NativeFieldInfoPtr_Setloop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setloop");
		NativeFieldInfoPtr_Onelazy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Onelazy");
		NativeFieldInfoPtr_Notonelazy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notonelazy");
		NativeFieldInfoPtr_Setlazy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setlazy");
		NativeFieldInfoPtr_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "One");
		NativeFieldInfoPtr_Notone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notone");
		NativeFieldInfoPtr_Set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Set");
		NativeFieldInfoPtr_Multi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Multi");
		NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Ref");
		NativeFieldInfoPtr_Bol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Bol");
		NativeFieldInfoPtr_Eol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Eol");
		NativeFieldInfoPtr_Boundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Boundary");
		NativeFieldInfoPtr_Nonboundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nonboundary");
		NativeFieldInfoPtr_Beginning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Beginning");
		NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Start");
		NativeFieldInfoPtr_EndZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "EndZ");
		NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "End");
		NativeFieldInfoPtr_Nothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nothing");
		NativeFieldInfoPtr_Lazybranch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Lazybranch");
		NativeFieldInfoPtr_Branchmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Branchmark");
		NativeFieldInfoPtr_Lazybranchmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Lazybranchmark");
		NativeFieldInfoPtr_Nullcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nullcount");
		NativeFieldInfoPtr_Setcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setcount");
		NativeFieldInfoPtr_Branchcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Branchcount");
		NativeFieldInfoPtr_Lazybranchcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Lazybranchcount");
		NativeFieldInfoPtr_Nullmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nullmark");
		NativeFieldInfoPtr_Setmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setmark");
		NativeFieldInfoPtr_Capturemark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Capturemark");
		NativeFieldInfoPtr_Getmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Getmark");
		NativeFieldInfoPtr_Setjump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setjump");
		NativeFieldInfoPtr_Backjump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Backjump");
		NativeFieldInfoPtr_Forejump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Forejump");
		NativeFieldInfoPtr_Testref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Testref");
		NativeFieldInfoPtr_Goto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Goto");
		NativeFieldInfoPtr_Prune = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Prune");
		NativeFieldInfoPtr_Stop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Stop");
		NativeFieldInfoPtr_ECMABoundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "ECMABoundary");
		NativeFieldInfoPtr_NonECMABoundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "NonECMABoundary");
		NativeFieldInfoPtr_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Mask");
		NativeFieldInfoPtr_Rtl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Rtl");
		NativeFieldInfoPtr_Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Back");
		NativeFieldInfoPtr_Back2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Back2");
		NativeFieldInfoPtr_Ci = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Ci");
		NativeFieldInfoPtr_Codes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Codes");
		NativeFieldInfoPtr_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Strings");
		NativeFieldInfoPtr_TrackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "TrackCount");
		NativeFieldInfoPtr_Caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Caps");
		NativeFieldInfoPtr_CapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "CapSize");
		NativeFieldInfoPtr_FCPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "FCPrefix");
		NativeFieldInfoPtr_BMPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "BMPrefix");
		NativeFieldInfoPtr_Anchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Anchors");
		NativeFieldInfoPtr_RightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "RightToLeft");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_Nullable_1_RegexPrefix_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, 100664620);
		NativeMethodInfoPtr_OpcodeBacktracks_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, 100664621);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 875076, RefRangeEnd = 875077, XrefRangeStart = 875067, XrefRangeEnd = 875076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegexCode(Il2CppStructArray<int> codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, Nullable<RegexPrefix> fcPrefix, int anchors, bool rightToLeft)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCode>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stringlist);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &trackcount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caps);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &capsize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bmPrefix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)fcPrefix));
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchors;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &rightToLeft;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_Nullable_1_RegexPrefix_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 875077, RefRangeEnd = 875082, XrefRangeStart = 875077, XrefRangeEnd = 875077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OpcodeBacktracks(int Op)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&Op);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpcodeBacktracks_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RegexCode(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
