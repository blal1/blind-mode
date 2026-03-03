using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.TextCore.Text;

[Serializable]
public class TextColorGradient : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_colorMode;

	private static readonly IntPtr NativeFieldInfoPtr_topLeft;

	private static readonly IntPtr NativeFieldInfoPtr_topRight;

	private static readonly IntPtr NativeFieldInfoPtr_bottomLeft;

	private static readonly IntPtr NativeFieldInfoPtr_bottomRight;

	private static readonly IntPtr NativeFieldInfoPtr_k_DefaultColorMode;

	private static readonly IntPtr NativeFieldInfoPtr_k_DefaultColor;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0;

	public unsafe ColorGradientMode colorMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorMode);
			return *(ColorGradientMode*)num;
		}
		set
		{
			*(ColorGradientMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorMode)) = value;
		}
	}

	public unsafe Color topLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topLeft);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topLeft)) = value;
		}
	}

	public unsafe Color topRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topRight);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topRight)) = value;
		}
	}

	public unsafe Color bottomLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bottomLeft);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bottomLeft)) = value;
		}
	}

	public unsafe Color bottomRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bottomRight);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bottomRight)) = value;
		}
	}

	public unsafe static ColorGradientMode k_DefaultColorMode
	{
		get
		{
			Unsafe.SkipInit(out ColorGradientMode result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DefaultColorMode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DefaultColorMode, (void*)(&value));
		}
	}

	public unsafe static Color k_DefaultColor
	{
		get
		{
			Unsafe.SkipInit(out Color result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DefaultColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DefaultColor, (void*)(&value));
		}
	}

	static TextColorGradient()
	{
		Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextColorGradient");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr);
		NativeFieldInfoPtr_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "colorMode");
		NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "topLeft");
		NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "topRight");
		NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "bottomLeft");
		NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "bottomRight");
		NativeFieldInfoPtr_k_DefaultColorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "k_DefaultColorMode");
		NativeFieldInfoPtr_k_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, "k_DefaultColor");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, 100663637);
		NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr, 100663638);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278836, XrefRangeEnd = 1278844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextColorGradient()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextColorGradient(Color color)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextColorGradient(Color color0, Color color1, Color color2, Color color3)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextColorGradient>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&color0);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &color1;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &color2;
		*(Color**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &color3;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TextColorGradient(IntPtr pointer)
		: base(pointer)
	{
	}
}
