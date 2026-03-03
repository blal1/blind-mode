using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI;

public class IVertexModifier : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0;

	static IVertexModifier()
	{
		Il2CppClassPointerStore<IVertexModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IVertexModifier");
		NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVertexModifier>.NativeClassPtr, 100664630);
	}

	[CallerCount(0)]
	public unsafe virtual void ModifyVertices(List<UIVertex> verts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)verts);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IVertexModifier(IntPtr pointer)
		: base(pointer)
	{
	}
}
