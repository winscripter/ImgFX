namespace ImgFX.Bitmap.Operations.Tools.Abstractions;

/// <summary>
/// Specifies an object that can be rendered.
/// </summary>
public interface IRenderable<T>
{
    /// <summary>
    /// Renders the object
    /// </summary>
    /// <param name="obj">
    /// Object where to render on
    /// </param>
    void Render(T obj);
}
