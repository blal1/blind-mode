using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppYgomEditor.EditScene.SpriteMaskTest;

public class SpriteMaskTestBehaviour : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_m_RectSize;

	private static readonly IntPtr NativeFieldInfoPtr_m_SpriteSize;

	private static readonly IntPtr NativeFieldInfoPtr_m_SpriteNativeSize;

	private static readonly IntPtr NativeFieldInfoPtr_m_BorderSize;

	private static readonly IntPtr NativeFieldInfoPtr_m_BorderNativeSize;

	private static readonly IntPtr NativeFieldInfoPtr_m_BorderScale;

	private static readonly IntPtr NativeFieldInfoPtr_m_BorderPos;

	private static readonly IntPtr NativeFieldInfoPtr_m_BorderMask;

	private static readonly IntPtr NativeFieldInfoPtr_m_CenterScale;

	private static readonly IntPtr NativeFieldInfoPtr_m_CenterPos;

	private static readonly IntPtr NativeFieldInfoPtr_m_MainTexScale;

	private static readonly IntPtr NativeFieldInfoPtr_m_MainTexMinMax;

	private static readonly IntPtr NativeFieldInfoPtr_m_Image;

	private static readonly IntPtr NativeMethodInfoPtr_get_image_Private_get_Image_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2 m_RectSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RectSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RectSize)) = value;
		}
	}

	public unsafe Vector2 m_SpriteSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSize)) = value;
		}
	}

	public unsafe Vector2 m_SpriteNativeSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteNativeSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteNativeSize)) = value;
		}
	}

	public unsafe Vector4 m_BorderSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BorderSize);
			return *(Vector4*)num;
		}
		set
		{
			*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BorderSize)) = value;
		}
	}

	public unsafe Vector4 m_BorderNativeSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BorderNativeSize);
			return *(Vector4*)num;
		}
		set
		{
			*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BorderNativeSize)) = value;
		}
	}

	public unsafe Vector2 m_BorderScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BorderScale);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BorderScale)) = value;
		}
	}

	public unsafe Vector2 m_BorderPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BorderPos);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BorderPos)) = value;
		}
	}

	public unsafe Vector4 m_BorderMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BorderMask);
			return *(Vector4*)num;
		}
		set
		{
			*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BorderMask)) = value;
		}
	}

	public unsafe Vector2 m_CenterScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CenterScale);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CenterScale)) = value;
		}
	}

	public unsafe Vector2 m_CenterPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CenterPos);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CenterPos)) = value;
		}
	}

	public unsafe Vector2 m_MainTexScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainTexScale);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainTexScale)) = value;
		}
	}

	public unsafe Vector4 m_MainTexMinMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainTexMinMax);
			return *(Vector4*)num;
		}
		set
		{
			*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainTexMinMax)) = value;
		}
	}

	public unsafe Image m_Image
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Image);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Image)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Image image
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50699, RefRangeEnd = 50708, XrefRangeStart = 50691, XrefRangeEnd = 50699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_image_Private_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
	}

	static SpriteMaskTestBehaviour()
	{
		Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomEditor.EditScene.SpriteMaskTest", "SpriteMaskTestBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr);
		NativeFieldInfoPtr_m_RectSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_RectSize");
		NativeFieldInfoPtr_m_SpriteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_SpriteSize");
		NativeFieldInfoPtr_m_SpriteNativeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_SpriteNativeSize");
		NativeFieldInfoPtr_m_BorderSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_BorderSize");
		NativeFieldInfoPtr_m_BorderNativeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_BorderNativeSize");
		NativeFieldInfoPtr_m_BorderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_BorderScale");
		NativeFieldInfoPtr_m_BorderPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_BorderPos");
		NativeFieldInfoPtr_m_BorderMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_BorderMask");
		NativeFieldInfoPtr_m_CenterScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_CenterScale");
		NativeFieldInfoPtr_m_CenterPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_CenterPos");
		NativeFieldInfoPtr_m_MainTexScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_MainTexScale");
		NativeFieldInfoPtr_m_MainTexMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_MainTexMinMax");
		NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, "m_Image");
		NativeMethodInfoPtr_get_image_Private_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, 100665116);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, 100665117);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr, 100665118);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50708, XrefRangeEnd = 50750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(103)]
	[CachedScanResults(RefRangeStart = 22793, RefRangeEnd = 22896, XrefRangeStart = 22793, XrefRangeEnd = 22896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpriteMaskTestBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteMaskTestBehaviour>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpriteMaskTestBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}
}
