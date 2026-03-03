using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppZXing.Common;
using Il2CppZXing.OneD;

namespace Il2CppZXing.IMB;

public sealed class IMBReader : OneDReader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_barPosA;

	private static readonly System.IntPtr NativeFieldInfoPtr_barPosB;

	private static readonly System.IntPtr NativeFieldInfoPtr_barPosC;

	private static readonly System.IntPtr NativeFieldInfoPtr_barPosD;

	private static readonly System.IntPtr NativeFieldInfoPtr_barPosE;

	private static readonly System.IntPtr NativeFieldInfoPtr_barPosF;

	private static readonly System.IntPtr NativeFieldInfoPtr_barPosG;

	private static readonly System.IntPtr NativeFieldInfoPtr_barPosH;

	private static readonly System.IntPtr NativeFieldInfoPtr_barPosI;

	private static readonly System.IntPtr NativeFieldInfoPtr_barPosJ;

	private static readonly System.IntPtr NativeFieldInfoPtr_barPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_barTypeA;

	private static readonly System.IntPtr NativeFieldInfoPtr_barTypeB;

	private static readonly System.IntPtr NativeFieldInfoPtr_barTypeC;

	private static readonly System.IntPtr NativeFieldInfoPtr_barTypeD;

	private static readonly System.IntPtr NativeFieldInfoPtr_barTypeE;

	private static readonly System.IntPtr NativeFieldInfoPtr_barTypeF;

	private static readonly System.IntPtr NativeFieldInfoPtr_barTypeG;

	private static readonly System.IntPtr NativeFieldInfoPtr_barTypeH;

	private static readonly System.IntPtr NativeFieldInfoPtr_barTypeI;

	private static readonly System.IntPtr NativeFieldInfoPtr_barTypeJ;

	private static readonly System.IntPtr NativeFieldInfoPtr_barType;

	private static readonly System.IntPtr NativeFieldInfoPtr_table1Check;

	private static readonly System.IntPtr NativeFieldInfoPtr_table2Check;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentBitmap;

	private static readonly System.IntPtr NativeMethodInfoPtr_doDecode_Protected_Virtual_Result_BinaryBitmap_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_binaryStringToDec_Private_UInt16_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_invertedBinaryString_Private_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCodeWords_Private_Boolean_byref_Il2CppStructArray_1_Int32_String_IDictionary_2_Int32_Int32_IDictionary_2_Int32_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTrackingNumber_Private_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fillLists_Private_Void_BitArray_BitArray_BitArray_byref_List_1_Int32_byref_List_1_Int32_byref_List_1_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isIMB_Private_Int32_BitArray_byref_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getNumberBars_Private_Int32_BitArray_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppStructArray<int> barPosA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barPosA, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barPosA, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> barPosB
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barPosB, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barPosB, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> barPosC
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barPosC, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barPosC, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> barPosD
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barPosD, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barPosD, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> barPosE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barPosE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barPosE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> barPosF
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barPosF, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barPosF, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> barPosG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barPosG, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barPosG, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> barPosH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barPosH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barPosH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> barPosI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barPosI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barPosI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> barPosJ
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barPosJ, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barPosJ, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> barPos
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barPos, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barPos, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> barTypeA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barTypeA, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barTypeA, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> barTypeB
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barTypeB, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barTypeB, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> barTypeC
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barTypeC, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barTypeC, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> barTypeD
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barTypeD, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barTypeD, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> barTypeE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barTypeE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barTypeE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> barTypeF
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barTypeF, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barTypeF, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> barTypeG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barTypeG, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barTypeG, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> barTypeH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barTypeH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barTypeH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> barTypeI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barTypeI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barTypeI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> barTypeJ
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barTypeJ, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barTypeJ, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<char>> barType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_barType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<char>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_barType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IDictionary<int, int> table1Check
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_table1Check, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<int, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_table1Check, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IDictionary<int, int> table2Check
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_table2Check, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionary<int, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_table2Check, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BinaryBitmap currentBitmap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBitmap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BinaryBitmap>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentBitmap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static IMBReader()
	{
		Il2CppClassPointerStore<IMBReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.IMB", "IMBReader");
		NativeFieldInfoPtr_barPosA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barPosA");
		NativeFieldInfoPtr_barPosB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barPosB");
		NativeFieldInfoPtr_barPosC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barPosC");
		NativeFieldInfoPtr_barPosD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barPosD");
		NativeFieldInfoPtr_barPosE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barPosE");
		NativeFieldInfoPtr_barPosF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barPosF");
		NativeFieldInfoPtr_barPosG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barPosG");
		NativeFieldInfoPtr_barPosH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barPosH");
		NativeFieldInfoPtr_barPosI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barPosI");
		NativeFieldInfoPtr_barPosJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barPosJ");
		NativeFieldInfoPtr_barPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barPos");
		NativeFieldInfoPtr_barTypeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barTypeA");
		NativeFieldInfoPtr_barTypeB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barTypeB");
		NativeFieldInfoPtr_barTypeC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barTypeC");
		NativeFieldInfoPtr_barTypeD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barTypeD");
		NativeFieldInfoPtr_barTypeE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barTypeE");
		NativeFieldInfoPtr_barTypeF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barTypeF");
		NativeFieldInfoPtr_barTypeG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barTypeG");
		NativeFieldInfoPtr_barTypeH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barTypeH");
		NativeFieldInfoPtr_barTypeI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barTypeI");
		NativeFieldInfoPtr_barTypeJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barTypeJ");
		NativeFieldInfoPtr_barType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "barType");
		NativeFieldInfoPtr_table1Check = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "table1Check");
		NativeFieldInfoPtr_table2Check = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "table2Check");
		NativeFieldInfoPtr_currentBitmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, "currentBitmap");
		NativeMethodInfoPtr_doDecode_Protected_Virtual_Result_BinaryBitmap_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, 100664450);
		NativeMethodInfoPtr_reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, 100664451);
		NativeMethodInfoPtr_binaryStringToDec_Private_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, 100664452);
		NativeMethodInfoPtr_invertedBinaryString_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, 100664453);
		NativeMethodInfoPtr_getCodeWords_Private_Boolean_byref_Il2CppStructArray_1_Int32_String_IDictionary_2_Int32_Int32_IDictionary_2_Int32_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, 100664454);
		NativeMethodInfoPtr_getTrackingNumber_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, 100664455);
		NativeMethodInfoPtr_fillLists_Private_Void_BitArray_BitArray_BitArray_byref_List_1_Int32_byref_List_1_Int32_byref_List_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, 100664456);
		NativeMethodInfoPtr_isIMB_Private_Int32_BitArray_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, 100664457);
		NativeMethodInfoPtr_getNumberBars_Private_Int32_BitArray_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, 100664458);
		NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, 100664459);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMBReader>.NativeClassPtr, 100664460);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425885, XrefRangeEnd = 1425887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Result doDecode(BinaryBitmap image, IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doDecode_Protected_Virtual_Result_BinaryBitmap_IDictionary_2_DecodeHintType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425887, XrefRangeEnd = 1425896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425902, RefRangeEnd = 1425903, XrefRangeStart = 1425896, XrefRangeEnd = 1425902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort binaryStringToDec(string binary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(binary);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_binaryStringToDec_Private_UInt16_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425912, RefRangeEnd = 1425913, XrefRangeStart = 1425903, XrefRangeEnd = 1425912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string invertedBinaryString(string binary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(binary);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_invertedBinaryString_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1425962, RefRangeEnd = 1425964, XrefRangeStart = 1425913, XrefRangeEnd = 1425962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool getCodeWords(out Il2CppStructArray<int> codeWord, string imb, IDictionary<int, int> table1Check, IDictionary<int, int> table2Check, Il2CppReferenceArray<Il2CppStructArray<int>> barPos, Il2CppReferenceArray<Il2CppStructArray<char>> barType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		nint num = 0;
		*ptr = (nint)(&num);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(imb);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)table1Check);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)table2Check);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)barPos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)barType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCodeWords_Private_Boolean_byref_Il2CppStructArray_1_Int32_String_IDictionary_2_Int32_Int32_IDictionary_2_Int32_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		codeWord = ((num2 == 0) ? null : new Il2CppStructArray<int>((System.IntPtr)num2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425986, RefRangeEnd = 1425987, XrefRangeStart = 1425964, XrefRangeEnd = 1425986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getTrackingNumber(string imb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(imb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTrackingNumber_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425987, XrefRangeEnd = 1426010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void fillLists(BitArray row, BitArray topRow, BitArray botRow, ref List<int> listRow, ref List<int> listTop, ref List<int> listBot, int start, int stop)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)topRow);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)botRow);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listRow);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listTop);
		*(System.IntPtr**)num2 = &intPtr2;
		byte* num3 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listBot);
		*(System.IntPtr**)num3 = &intPtr3;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &stop;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fillLists_Private_Void_BitArray_BitArray_BitArray_byref_List_1_Int32_byref_List_1_Int32_byref_List_1_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr6 = intPtr;
		listRow = ((intPtr6 == (System.IntPtr)0) ? null : new List<int>(intPtr6));
		System.IntPtr intPtr7 = intPtr2;
		listTop = ((intPtr7 == (System.IntPtr)0) ? null : new List<int>(intPtr7));
		System.IntPtr intPtr8 = intPtr3;
		listBot = ((intPtr8 == (System.IntPtr)0) ? null : new List<int>(intPtr8));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1426014, RefRangeEnd = 1426015, XrefRangeStart = 1426010, XrefRangeEnd = 1426014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int isIMB(BitArray row, ref int pixelStartOffset, ref int pixelStopOffset, ref int pixelBarLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pixelStartOffset);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pixelStopOffset);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pixelBarLength);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isIMB_Private_Int32_BitArray_byref_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1426016, RefRangeEnd = 1426018, XrefRangeStart = 1426015, XrefRangeEnd = 1426016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getNumberBars(BitArray row, int start, int stop, int barWidth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &stop;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &barWidth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNumberBars_Private_Int32_BitArray_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426018, XrefRangeEnd = 1426134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Result decodeRow(int rowNumber, BitArray row, IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rowNumber);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeRow_Public_Virtual_Result_Int32_BitArray_IDictionary_2_DecodeHintType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426134, XrefRangeEnd = 1426138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IMBReader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IMBReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IMBReader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
