namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

public enum StoreReason
{
	InvalidReason,
	StoreImported,
	StoreUsedByLaterPass,
	DiscardImported,
	DiscardUnused,
	DiscardBindMs,
	NoMSAABuffer,
	Count
}
