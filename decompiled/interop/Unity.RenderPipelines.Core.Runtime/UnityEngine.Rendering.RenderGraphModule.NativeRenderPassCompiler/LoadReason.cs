namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

public enum LoadReason
{
	InvalidReason,
	LoadImported,
	LoadPreviouslyWritten,
	ClearImported,
	ClearCreated,
	FullyRewritten,
	Count
}
