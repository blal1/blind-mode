using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppYgomSystem.UI;

namespace Il2Cpp;

public class CardPictureSystemCheckLauncher : ViewController
{
	private static readonly IntPtr NativeFieldInfoPtr_PREFAB_NAME;

	private static readonly IntPtr NativeFieldInfoPtr_m_Boot;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string PREFAB_NAME
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PREFAB_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PREFAB_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool m_Boot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Boot);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Boot)) = value;
		}
	}

	static CardPictureSystemCheckLauncher()
	{
		Il2CppClassPointerStore<CardPictureSystemCheckLauncher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardPictureSystemCheckLauncher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardPictureSystemCheckLauncher>.NativeClassPtr);
		NativeFieldInfoPtr_PREFAB_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPictureSystemCheckLauncher>.NativeClassPtr, "PREFAB_NAME");
		NativeFieldInfoPtr_m_Boot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPictureSystemCheckLauncher>.NativeClassPtr, "m_Boot");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPictureSystemCheckLauncher>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPictureSystemCheckLauncher>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPictureSystemCheckLauncher>.NativeClassPtr, 100663311);
	}

	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25082, XrefRangeEnd = 25091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25091, XrefRangeEnd = 25095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardPictureSystemCheckLauncher()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardPictureSystemCheckLauncher>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CardPictureSystemCheckLauncher(IntPtr pointer)
		: base(pointer)
	{
	}
}
