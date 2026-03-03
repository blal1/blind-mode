using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.U2D.Animation;

public sealed class CalculateSpriteSkinAABBJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_vertices;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSpriteSkinValidForDeformArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteSkinData;

	private static readonly System.IntPtr NativeFieldInfoPtr_bounds;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe NativeSlice<byte> vertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertices);
			return new NativeSlice<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<byte>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<byte>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<bool> isSpriteSkinValidForDeformArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSpriteSkinValidForDeformArray);
			return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSpriteSkinValidForDeformArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<SpriteSkinData> spriteSkinData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteSkinData);
			return new NativeArray<SpriteSkinData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SpriteSkinData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteSkinData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SpriteSkinData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Bounds> bounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bounds);
			return new NativeArray<Bounds>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Bounds>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bounds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Bounds>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static CalculateSpriteSkinAABBJob()
	{
		Il2CppClassPointerStore<CalculateSpriteSkinAABBJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "CalculateSpriteSkinAABBJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CalculateSpriteSkinAABBJob>.NativeClassPtr);
		NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculateSpriteSkinAABBJob>.NativeClassPtr, "vertices");
		NativeFieldInfoPtr_isSpriteSkinValidForDeformArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculateSpriteSkinAABBJob>.NativeClassPtr, "isSpriteSkinValidForDeformArray");
		NativeFieldInfoPtr_spriteSkinData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculateSpriteSkinAABBJob>.NativeClassPtr, "spriteSkinData");
		NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculateSpriteSkinAABBJob>.NativeClassPtr, "bounds");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalculateSpriteSkinAABBJob>.NativeClassPtr, 100663336);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954294, XrefRangeEnd = 954301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CalculateSpriteSkinAABBJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CalculateSpriteSkinAABBJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalculateSpriteSkinAABBJob>.NativeClassPtr))
	{
	}
}
