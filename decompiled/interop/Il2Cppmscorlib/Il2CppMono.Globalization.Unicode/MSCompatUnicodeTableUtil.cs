using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode;

public class MSCompatUnicodeTableUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Ignorable;

	private static readonly System.IntPtr NativeFieldInfoPtr_Category;

	private static readonly System.IntPtr NativeFieldInfoPtr_Level1;

	private static readonly System.IntPtr NativeFieldInfoPtr_Level2;

	private static readonly System.IntPtr NativeFieldInfoPtr_Level3;

	private static readonly System.IntPtr NativeFieldInfoPtr_CjkCHS;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cjk;

	public unsafe static CodePointIndexer Ignorable
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Ignorable, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Ignorable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CodePointIndexer Category
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Category, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Category, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CodePointIndexer Level1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Level1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Level1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CodePointIndexer Level2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Level2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Level2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CodePointIndexer Level3
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Level3, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Level3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CodePointIndexer CjkCHS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CjkCHS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CjkCHS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CodePointIndexer Cjk
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Cjk, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Cjk, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static MSCompatUnicodeTableUtil()
	{
		Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "MSCompatUnicodeTableUtil");
		NativeFieldInfoPtr_Ignorable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Ignorable");
		NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Category");
		NativeFieldInfoPtr_Level1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Level1");
		NativeFieldInfoPtr_Level2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Level2");
		NativeFieldInfoPtr_Level3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Level3");
		NativeFieldInfoPtr_CjkCHS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "CjkCHS");
		NativeFieldInfoPtr_Cjk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSCompatUnicodeTableUtil>.NativeClassPtr, "Cjk");
	}

	public MSCompatUnicodeTableUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
