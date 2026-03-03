using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

public sealed class RenderGraphParameters : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_executionName;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentFrameIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererListCulling;

	private static readonly System.IntPtr NativeFieldInfoPtr_scriptableRenderContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_invalidContextForTesting;

	public unsafe string executionName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executionName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executionName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int currentFrameIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFrameIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFrameIndex)) = value;
		}
	}

	public unsafe bool rendererListCulling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererListCulling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererListCulling)) = value;
		}
	}

	public unsafe ScriptableRenderContext scriptableRenderContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scriptableRenderContext);
			return *(ScriptableRenderContext*)num;
		}
		set
		{
			*(ScriptableRenderContext*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scriptableRenderContext)) = value;
		}
	}

	public unsafe CommandBuffer commandBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commandBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commandBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool invalidContextForTesting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invalidContextForTesting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invalidContextForTesting)) = value;
		}
	}

	static RenderGraphParameters()
	{
		Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RenderGraphParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr);
		NativeFieldInfoPtr_executionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr, "executionName");
		NativeFieldInfoPtr_currentFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr, "currentFrameIndex");
		NativeFieldInfoPtr_rendererListCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr, "rendererListCulling");
		NativeFieldInfoPtr_scriptableRenderContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr, "scriptableRenderContext");
		NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr, "commandBuffer");
		NativeFieldInfoPtr_invalidContextForTesting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr, "invalidContextForTesting");
	}

	public RenderGraphParameters(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RenderGraphParameters()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderGraphParameters>.NativeClassPtr))
	{
	}
}
