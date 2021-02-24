using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base interface for all objects that will use GUI to display their options.
/// </summary>
public interface IOptionsDisplayer<T>
{
    /// <summary>
    /// Creates an GUI options for given object.
    /// </summary>
    /// <param name="t">Subject of the option displaying</param>
    void DisplayOptions(T t);
}
