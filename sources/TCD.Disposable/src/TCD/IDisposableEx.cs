/***************************************************************************************************
 * FileName:             IDisposableEx.cs
 * Copyright:            Copyright © 2017-2019 Thomas Corwin, et al. All Rights Reserved.
 * License:              https://github.com/tom-corwin/tcdfx/blob/master/LICENSE.md
 **************************************************************************************************/

namespace TCD
{
    /// <summary>
    /// Provides added functionality on top of the <see cref="IDisposable"/> interface.
    /// </summary>
    public interface IDisposableEx : IDisposable
    {
        /// <summary>
        /// Occurs when this object is disposing.
        /// </summary>
        event DisposingEventHandler Disposing;

        /// <summary>
        /// Occurs when this object is disposed.
        /// </summary>
        event DisposedEventHandler Disposed;

        /// <summary>
        /// Safely performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources, invoking the specified action in the event of an exception.
        /// </summary>
        /// <param name="exceptionHandler">The action to be invoked in the event of an exception.</param>
        /// <returns><c>true</c> if properly disposed; otherwise, <c>false</c>.</returns>
        bool SafeDispose(Action<Exception> exceptionHandler = null);
    }
}